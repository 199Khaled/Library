-- Stored Procedures for Table: BorrowingRecords

Use [LibraryDb];
Go


CREATE OR ALTER PROCEDURE SP_Get_BorrowingRecords_ByID
(
    @BorrowingRecordID int
)
AS
BEGIN
    BEGIN TRY
        -- Attempt to retrieve data
        SELECT *
        FROM BorrowingRecords
        WHERE BorrowingRecordID = @BorrowingRecordID;
    END TRY
    BEGIN CATCH
        -- Call the centralized error handling procedure
        EXEC SP_HandleError;
    END CATCH
END;
GO

CREATE OR ALTER PROCEDURE SP_Get_All_BorrowingRecords
AS
BEGIN
    BEGIN TRY
        -- Attempt to retrieve all data from the table
        SELECT *
        FROM BorrowingRecords;
    END TRY
    BEGIN CATCH
        -- Call the centralized error handling procedure
        EXEC SP_HandleError;
    END CATCH
END;
GO


CREATE OR ALTER PROCEDURE SP_Add_BorrowingRecords
(
    @UserID int,
    @CopyID int,
    @BorrowingDate date,
    @DueDate date,
    @ActualReturnDate date = NULL,
    @NewID INT OUTPUT

)
AS
BEGIN
    BEGIN TRY
        -- Check if any required parameters are NULL
        IF LTRIM(RTRIM(@UserID)) IS NULL OR LTRIM(RTRIM(@CopyID)) IS NULL OR LTRIM(RTRIM(@BorrowingDate)) IS NULL OR LTRIM(RTRIM(@DueDate)) IS NULL
        BEGIN
            RAISERROR('One or more required parameters are NULL or have only whitespace.', 16, 1);
            RETURN;
        END

        -- Insert the data into the table
        INSERT INTO BorrowingRecords ([UserID],[CopyID],[BorrowingDate],[DueDate],[ActualReturnDate])
        VALUES (    LTRIM(RTRIM(@UserID)),
    LTRIM(RTRIM(@CopyID)),
    LTRIM(RTRIM(@BorrowingDate)),
    LTRIM(RTRIM(@DueDate)),
    LTRIM(RTRIM(@ActualReturnDate))
);

        -- Set the new ID
        SET @NewID = SCOPE_IDENTITY();  -- Get the last inserted ID
    END TRY
    BEGIN CATCH
        EXEC SP_HandleError; -- Error handling
    END CATCH
END;
GO


CREATE OR ALTER PROCEDURE SP_Update_BorrowingRecords_ByID
(
    @BorrowingRecordID int,
    @UserID int,
    @CopyID int,
    @BorrowingDate date,
    @DueDate date,
    @ActualReturnDate date = NULL

)
AS
BEGIN
    BEGIN TRY
        -- Check if required parameters are NULL or contain only whitespace after trimming
        IF LTRIM(RTRIM(@UserID)) IS NULL OR LTRIM(RTRIM(@UserID)) = '' OR LTRIM(RTRIM(@CopyID)) IS NULL OR LTRIM(RTRIM(@CopyID)) = '' OR LTRIM(RTRIM(@BorrowingDate)) IS NULL OR LTRIM(RTRIM(@BorrowingDate)) = '' OR LTRIM(RTRIM(@DueDate)) IS NULL OR LTRIM(RTRIM(@DueDate)) = ''
        BEGIN
            RAISERROR('One or more required parameters are NULL or have only whitespace.', 16, 1);
            RETURN;
        END

        -- Update the record in the table
        UPDATE BorrowingRecords
        SET     [UserID] = LTRIM(RTRIM(@UserID)),
    [CopyID] = LTRIM(RTRIM(@CopyID)),
    [BorrowingDate] = LTRIM(RTRIM(@BorrowingDate)),
    [DueDate] = LTRIM(RTRIM(@DueDate)),
    [ActualReturnDate] = LTRIM(RTRIM(@ActualReturnDate))

        WHERE BorrowingRecordID = @BorrowingRecordID;
        
        -- Optionally, you can check if the update was successful and raise an error if no rows were updated
        IF @@ROWCOUNT = 0
        BEGIN
            RAISERROR('No rows were updated. Please check the PersonID or other parameters.', 16, 1);
            RETURN;
        END
    END TRY
    BEGIN CATCH
        EXEC SP_HandleError; -- Handle errors
    END CATCH
END;
GO


CREATE OR ALTER PROCEDURE SP_Delete_BorrowingRecords_ByID
(
    @BorrowingRecordID int
)
AS
BEGIN

    BEGIN TRY
        -- Check if the record exists before attempting to delete
        IF NOT EXISTS (SELECT 1 FROM BorrowingRecords WHERE BorrowingRecordID = @BorrowingRecordID)
        BEGIN
            EXEC SP_HandleError;
            RETURN;
        END

        -- Attempt to delete the record
        DELETE FROM BorrowingRecords WHERE BorrowingRecordID = @BorrowingRecordID;

        -- Ensure at least one row was deleted
        IF @@ROWCOUNT = 0
        BEGIN
            EXEC SP_HandleError;
            RETURN;
        END
    END TRY
    BEGIN CATCH
        -- Handle all errors (including FK constraint violations)
        EXEC SP_HandleError;
    END CATCH
END;
GO


CREATE OR ALTER PROCEDURE SP_Search_BorrowingRecords_ByColumn
(
    @ColumnName NVARCHAR(128),  -- Column name without spaces
    @SearchValue NVARCHAR(255), -- Value to search for
    @Mode NVARCHAR(20) = 'Anywhere' -- Search mode (default: Anywhere)
)
AS
BEGIN
    BEGIN TRY
        DECLARE @ActualColumn NVARCHAR(128);
        DECLARE @SQL NVARCHAR(MAX);
        DECLARE @SearchPattern NVARCHAR(255);

        -- Map input column name to actual database column name
        SET @ActualColumn = 
            CASE @ColumnName
                WHEN 'BorrowingRecordID' THEN 'BorrowingRecordID'
        WHEN 'UserID' THEN 'UserID'
        WHEN 'CopyID' THEN 'CopyID'
        WHEN 'BorrowingDate' THEN 'BorrowingDate'
        WHEN 'DueDate' THEN 'DueDate'
        WHEN 'ActualReturnDate' THEN 'ActualReturnDate'
                ELSE NULL
            END;

        -- Validate the column name
        IF @ActualColumn IS NULL
        BEGIN
            RAISERROR('Invalid Column Name provided.', 16, 1);
            RETURN;
        END

        -- Validate the search value (ensure it's not empty or NULL)
        IF ISNULL(LTRIM(RTRIM(@SearchValue)), '') = ''
        BEGIN
            RAISERROR('Search value cannot be empty.', 16, 1);
            RETURN;
        END

        -- Prepare the search pattern based on the mode
        SET @SearchPattern =
            CASE 
                WHEN @Mode = 'Anywhere' THEN '%' + LTRIM(RTRIM(@SearchValue)) + '%'
                WHEN @Mode = 'StartsWith' THEN LTRIM(RTRIM(@SearchValue)) + '%'
                WHEN @Mode = 'EndsWith' THEN '%' + LTRIM(RTRIM(@SearchValue))
                WHEN @Mode = 'ExactMatch' THEN LTRIM(RTRIM(@SearchValue))
                ELSE '%' + LTRIM(RTRIM(@SearchValue)) + '%'
            END;

        -- Build the dynamic SQL query safely
        SET @SQL = N'SELECT * FROM ' + QUOTENAME('BorrowingRecords') + 
                   N' WHERE ' + QUOTENAME(@ActualColumn) + N' LIKE @SearchPattern OPTION (RECOMPILE)';

        -- Execute the dynamic SQL with parameterized search pattern
        EXEC sp_executesql @SQL, N'@SearchPattern NVARCHAR(255)', @SearchPattern;
    END TRY
    BEGIN CATCH
        -- Handle errors
        EXEC SP_HandleError;
    END CATCH
END;
GO
