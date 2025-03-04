
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using LibraryDb_DataAccess;
using Newtonsoft.Json;

namespace LibraryDb_DataLayer
{
    public class clsBookCopiesData
    {
        //#nullable enable

        public static bool GetBookCopiesInfoByID(int? CopyID , ref int? BookID,ref int? CopyCount, ref bool? AvailabilityStatus)
        {
            bool isFound = false;

    try
    {
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            string query = "SP_Get_BookCopies_ByID";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Ensure correct parameter assignment
                command.Parameters.AddWithValue("@CopyID", CopyID ?? (object)DBNull.Value);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                { 
                    if (reader.Read())
                    {
                        // The record was found
                        isFound = true;

                                BookID = (int)reader["BookID"];
                                AvailabilityStatus = reader["AvailabilityStatus"] != DBNull.Value ? (bool?)reader["AvailabilityStatus"] : null;

                    }
                }
            }
        }
    }
    catch (Exception ex)
    {
        // Handle all exceptions in a general way
        ErrorHandler.HandleException(ex, nameof(GetBookCopiesInfoByID), $"Parameter: CopyID = " + CopyID);
    }

    return isFound;
}

        public static bool DoesBookCopyExistAndAvailable(int copyID)
        {
            int result = -1;
            try
            {
                using (SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_Check_CopyID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CopyID", copyID);

                    con.Open();
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                // Handle all exceptions in a general way
                ErrorHandler.HandleException(ex, nameof(DoesBookCopyExistAndAvailable), $"Parameter: CopyID = " + copyID);
            }
            return result == 1; // Gibt true zurück, wenn CopyID existiert and Available, sonst false
        }

        public static bool GetBookCopiesInfoByBookID(ref int? CopyID, int? BookID, ref bool? AvailabilityStatus)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"Select * from BookCopies where BookID = @BookID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        // Ensure correct parameter assignment
                        command.Parameters.AddWithValue("@BookID", BookID ?? (object)DBNull.Value);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                CopyID = (int)reader["CopyID"];
                                AvailabilityStatus = reader["AvailabilityStatus"] != DBNull.Value ? (bool?)reader["AvailabilityStatus"] : null;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle all exceptions in a general way
                ErrorHandler.HandleException(ex, nameof(GetBookCopiesInfoByID), $"Parameter: CopyID = " + CopyID);
            }

            return isFound;
        }

       
        public static DataTable GetAllBookCopies()
{
    DataTable dt = new DataTable();

    try
    {
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            string query = "SP_Get_All_BookCopies";

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
        ErrorHandler.HandleException(ex, nameof(GetAllBookCopies), "No parameters for this method.");
    }

    return dt;
}

        public static DataTable GetAllAvailableBookCopiesByBookID(int? BookID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"Select * from BookCopies where BookID = @BookID AND AvailabilityStatus = 1 "; 

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", BookID);

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
                ErrorHandler.HandleException(ex, nameof(GetAllBookCopies), "No parameters for this method.");
            }

            return dt;
        }

        public static int? AddNewBookCopies(int? BookID,int? CopyCount, bool? AvailabilityStatus)
    {
        int? CopyID = null;

        try
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SP_Add_BookCopies";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@BookID", BookID);
                        command.Parameters.AddWithValue("@CopyCount", CopyCount);
                        command.Parameters.AddWithValue("@AvailabilityStatus", AvailabilityStatus ?? (object)DBNull.Value);


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
                        CopyID = (int)outputIdParam.Value;
                    }

                }
            }
        }
        catch (Exception ex)
        {
            // Handle all exceptions in a general way
            ErrorHandler.HandleException(ex, nameof(AddNewBookCopies), $"Parameters: int? BookID, bool? AvailabilityStatus");
        }

        return CopyID;
    }

        public static bool UpdateBookCopiesByID(int? CopyID, int? BookID, bool? AvailabilityStatus)
{
    int rowsAffected = 0;

    try
    {
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            string query = $@"SP_Update_BookCopies_ByID"; 

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Create the parameters for the stored procedure
                    command.Parameters.AddWithValue("@CopyID", CopyID);
                    command.Parameters.AddWithValue("@BookID", BookID);
                    command.Parameters.AddWithValue("@AvailabilityStatus", AvailabilityStatus ?? (object)DBNull.Value);


                // Open the connection and execute the update
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
        }
    }
    catch (Exception ex)
    {
        // Handle exceptions
        ErrorHandler.HandleException(ex, nameof(UpdateBookCopiesByID), $"Parameter: CopyID = " + CopyID);
    }

    return (rowsAffected > 0);
}

 public static bool DeleteBookCopies(int CopyID)
{
    int rowsAffected = 0;

    try
    {
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            string query = $@"SP_Delete_BookCopies_ByID";  

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@CopyID", CopyID);

                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }
        }
    }
    catch (Exception ex)
    {
        // Handle all exceptions in a general way, this includes errors from SP_HandleError if any
        ErrorHandler.HandleException(ex, nameof(DeleteBookCopies), $"Parameter: CopyID = " + CopyID);
    }

    return (rowsAffected > 0);
}

        public static bool DeleteBookCopiesByBookID(int BookID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = $@"SP_Delete_BookCopies_ByBookID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BookID", BookID);

                        connection.Open();

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle all exceptions in a general way, this includes errors from SP_HandleError if any
                ErrorHandler.HandleException(ex, nameof(DeleteBookCopies), $"Parameter: CopyID = " + BookID);
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
            string query = $@"SP_Search_BookCopies_ByColumn";

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
