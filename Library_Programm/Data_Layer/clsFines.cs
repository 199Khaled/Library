
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using LibraryDb_DataAccess;
using Newtonsoft.Json;

namespace LibraryDb_DataLayer
{
    public class clsFinesData
    {
        //#nullable enable

        public static bool GetFinesInfoByID(int? FineID , ref int? UserID, ref int? BorrowingRecordID, ref short? NumberOfLateDays, ref decimal? FineAmount, ref bool? PaymentStatus)
{
    bool isFound = false;

    try
    {
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            string query = "SP_Get_Fines_ByID";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Ensure correct parameter assignment
                command.Parameters.AddWithValue("@FineID", FineID ?? (object)DBNull.Value);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                { 
                    if (reader.Read())
                    {
                        // The record was found
                        isFound = true;

                                UserID = (int)reader["UserID"];
                                BorrowingRecordID = (int)reader["BorrowingRecordID"];
                                NumberOfLateDays = (short)reader["NumberOfLateDays"];
                                FineAmount = (decimal)reader["FineAmount"];
                                PaymentStatus = (bool)reader["PaymentStatus"];

                    }
                }
            }
        }
    }
    catch (Exception ex)
    {
        // Handle all exceptions in a general way
        ErrorHandler.HandleException(ex, nameof(GetFinesInfoByID), $"Parameter: FineID = " + FineID);
    }

    return isFound;
}

        public static DataTable GetAllFines()
{
    DataTable dt = new DataTable();

    try
    {
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            string query = "SP_Get_All_Fines";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure; 

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }
                }
            }
        }
    }
    catch (Exception ex)
    {
        // Handle all exceptions in a general way
        ErrorHandler.HandleException(ex, nameof(GetAllFines), "No parameters for this method.");
    }

    return dt;
}

        public static int? AddNewFines(int? UserID, int? BorrowingRecordID, short? NumberOfLateDays, decimal? FineAmount, bool? PaymentStatus)
    {
        int? FineID = null;

        try
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SP_Add_Fines";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
                    command.Parameters.AddWithValue("@NumberOfLateDays", NumberOfLateDays);
                    command.Parameters.AddWithValue("@FineAmount", FineAmount);
                    command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);


                    SqlParameter outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputIdParam);

                    connection.Open();
                    command.ExecuteNonQuery();

                    // Bring added value
                    if (outputIdParam.Value != DBNull.Value)
                    {
                        FineID = (int)outputIdParam.Value;
                    }

                }
            }
        }
        catch (Exception ex)
        {
            // Handle all exceptions in a general way
            ErrorHandler.HandleException(ex, nameof(AddNewFines), $"Parameters: int? UserID, int? BorrowingRecordID, short? NumberOfLateDays, decimal? FineAmount, bool? PaymentStatus");
        }

        return FineID;
    }

        public static bool UpdateFinesByID(int? FineID, int? UserID, int? BorrowingRecordID, short? NumberOfLateDays, decimal? FineAmount, bool? PaymentStatus)
{
    int rowsAffected = 0;

    try
    {
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            string query = $@"SP_Update_Fines_ByID"; 

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Create the parameters for the stored procedure
                    command.Parameters.AddWithValue("@FineID", FineID);
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
                    command.Parameters.AddWithValue("@NumberOfLateDays", NumberOfLateDays);
                    command.Parameters.AddWithValue("@FineAmount", FineAmount);
                    command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);


                // Open the connection and execute the update
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
        }
    }
    catch (Exception ex)
    {
        // Handle exceptions
        ErrorHandler.HandleException(ex, nameof(UpdateFinesByID), $"Parameter: FineID = " + FineID);
    }

    return (rowsAffected > 0);
}

        public static bool DeleteFines(int FineID)
{
    int rowsAffected = 0;

    try
    {
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            string query = $@"SP_Delete_Fines_ByID";  

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FineID", FineID);

                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }
        }
    }
    catch (Exception ex)
    {
        // Handle all exceptions in a general way, this includes errors from SP_HandleError if any
        ErrorHandler.HandleException(ex, nameof(DeleteFines), $"Parameter: FineID = " + FineID);
    }

    return (rowsAffected > 0);
}
        
        public static DataTable SearchData(string ColumnName, string SearchValue, string Mode = "Anywhere")
{
    DataTable dt = new DataTable();

    try
    {
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            string query = $@"SP_Search_Fines_ByColumn";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ColumnName", ColumnName);
                command.Parameters.AddWithValue("@SearchValue", SearchValue);
                command.Parameters.AddWithValue("@Mode", Mode);  // Added Mode parameter

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }

                    reader.Close();
                }
            }
        }
    }
    catch (Exception ex)
    {
        // Handle all exceptions in a general way
        ErrorHandler.HandleException(ex, nameof(SearchData), $"ColumnName: {ColumnName}, SearchValue: {SearchValue}, Mode: {Mode}");
    }

    return dt;
}
    }
}
