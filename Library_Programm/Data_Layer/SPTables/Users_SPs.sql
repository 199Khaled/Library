-- Stored Procedures for Table: Users

Use [LibraryDb];
Go


CREATE OR ALTER PROCEDURE SP_Get_Users_ByID
(
    @UserID int
)
AS
BEGIN
    BEGIN TRY
        -- Attempt to retrieve data
        SELECT *
        FROM Users
        WHERE UserID = @UserID;
    END TRY
    BEGIN CATCH
        -- Call the centralized error handling procedure
        EXEC SP_HandleError;
    END CATCH
END;
GO

CREATE OR ALTER PROCEDURE SP_Get_All_Users
AS
BEGIN
    BEGIN TRY
        -- Attempt to retrieve all data from the table
        SELECT *
        FROM Users;
    END TRY
    BEGIN CATCH
        -- Call the centralized error handling procedure
        EXEC SP_HandleError;
    END CATCH
END;
GO


CREATE OR ALTER PROCEDURE SP_Add_Users
(
    @Firstname nvarchar(50),
    @Lastname nvarchar(50),
    @City nvarchar(30),
    @Telefon nvarchar(15) = NULL,
    @Email nvarchar(50) = NULL,
    @LibraryCardNumber nvarchar(50) = NULL,
    @NewID INT OUTPUT

)
AS
BEGIN
    BEGIN TRY
        -- Check if any required parameters are NULL
        IF LTRIM(RTRIM(@Firstname)) IS NULL OR LTRIM(RTRIM(@Lastname)) IS NULL OR LTRIM(RTRIM(@City)) IS NULL
        BEGIN
            RAISERROR('One or more required parameters are NULL or have only whitespace.', 16, 1);
            RETURN;
        END

        -- Insert the data into the table
        INSERT INTO Users ([Firstname],[Lastname],[City],[Telefon],[Email],[LibraryCardNumber])
        VALUES (    LTRIM(RTRIM(@Firstname)),
    LTRIM(RTRIM(@Lastname)),
    LTRIM(RTRIM(@City)),
    LTRIM(RTRIM(@Telefon)),
    LTRIM(RTRIM(@Email)),
    LTRIM(RTRIM(@LibraryCardNumber))
);

        -- Set the new ID
        SET @NewID = SCOPE_IDENTITY();  -- Get the last inserted ID
    END TRY
    BEGIN CATCH
        EXEC SP_HandleError; -- Error handling
    END CATCH
END;
GO


CREATE OR ALTER PROCEDURE SP_Update_Users_ByID
(
    @UserID int,
    @Firstname nvarchar(50),
    @Lastname nvarchar(50),
    @City nvarchar(30),
    @Telefon nvarchar(15) = NULL,
    @Email nvarchar(50) = NULL,
    @LibraryCardNumber nvarchar(50) = NULL

)
AS
BEGIN
    BEGIN TRY
        -- Check if required parameters are NULL or contain only whitespace after trimming
        IF LTRIM(RTRIM(@Firstname)) IS NULL OR LTRIM(RTRIM(@Firstname)) = '' OR LTRIM(RTRIM(@Lastname)) IS NULL OR LTRIM(RTRIM(@Lastname)) = '' OR LTRIM(RTRIM(@City)) IS NULL OR LTRIM(RTRIM(@City)) = ''
        BEGIN
            RAISERROR('One or more required parameters are NULL or have only whitespace.', 16, 1);
            RETURN;
        END

        -- Update the record in the table
        UPDATE Users
        SET     [Firstname] = LTRIM(RTRIM(@Firstname)),
    [Lastname] = LTRIM(RTRIM(@Lastname)),
    [City] = LTRIM(RTRIM(@City)),
    [Telefon] = LTRIM(RTRIM(@Telefon)),
    [Email] = LTRIM(RTRIM(@Email)),
    [LibraryCardNumber] = LTRIM(RTRIM(@LibraryCardNumber))

        WHERE UserID = @UserID;
        
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


CREATE OR ALTER PROCEDURE SP_Delete_Users_ByID
(
    @UserID int
)
AS
BEGIN

    BEGIN TRY
        -- Check if the record exists before attempting to delete
        IF NOT EXISTS (SELECT 1 FROM Users WHERE UserID = @UserID)
        BEGIN
            EXEC SP_HandleError;
            RETURN;
        END

        -- Attempt to delete the record
        DELETE FROM Users WHERE UserID = @UserID;

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


CREATE OR ALTER PROCEDURE SP_Search_Users_ByColumn
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
                WHEN 'UserID' THEN 'UserID'
        WHEN 'Firstname' THEN 'Firstname'
        WHEN 'Lastname' THEN 'Lastname'
        WHEN 'City' THEN 'City'
        WHEN 'Telefon' THEN 'Telefon'
        WHEN 'Email' THEN 'Email'
        WHEN 'LibraryCardNumber' THEN 'LibraryCardNumber'
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
        SET @SQL = N'SELECT * FROM ' + QUOTENAME('Users') + 
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
