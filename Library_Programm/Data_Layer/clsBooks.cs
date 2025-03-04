
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using Newtonsoft.Json;
using LibraryDb_DataAccess;

namespace LibraryDb_DataLayer
{
    public class clsBooksData
    {
        //#nullable enable

        public static bool GetBooksInfoByID(int? BookID , ref string Title, ref string ISBN, ref DateTime? PublicationDate, ref string Genre, ref string AdditionalDetails)
       {
    bool isFound = false;

    try
    {
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            string query = "SP_Get_Books_ByID";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Ensure correct parameter assignment
                command.Parameters.AddWithValue("@BookID", BookID ?? (object)DBNull.Value);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                { 
                    if (reader.Read())
                    {
                        // The record was found
                        isFound = true;

                                Title = (string)reader["Title"];
                                ISBN = (string)reader["ISBN"];
                                PublicationDate = (DateTime)reader["PublicationDate"];
                                Genre = (string)reader["Genre"];
                                AdditionalDetails = reader["AdditionalDetails"] != DBNull.Value ? reader["AdditionalDetails"].ToString() : null;

                    }
                }
            }
        }
    }
    catch (Exception ex)
    {
        // Handle all exceptions in a general way
        ErrorHandler.HandleException(ex, nameof(GetBooksInfoByID), $"Parameter: BookID = " + BookID);
    }

    return isFound;
}
        public static bool GetBooksInfoByCopyID(int? CopyID, ref int? BookID, ref string Title, ref string ISBN, ref DateTime? PublicationDate, ref string Genre, ref string AdditionalDetails)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SP_Get_BookDetails_ByCopyID";

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
                                Title = (string)reader["Title"];
                                ISBN = (string)reader["ISBN"];
                                PublicationDate = (DateTime)reader["PublicationDate"];
                                Genre = (string)reader["Genre"];
                                AdditionalDetails = reader["AdditionalDetails"] != DBNull.Value ? reader["AdditionalDetails"].ToString() : null;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle all exceptions in a general way
                ErrorHandler.HandleException(ex, nameof(GetBooksInfoByID), $"Parameter: BookID = " + BookID);
            }

            return isFound;
        }
        public static DataTable GetAllBooks()
{
    DataTable dt = new DataTable();

    try
    {
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            string query = "SP_Get_All_Books";

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
        ErrorHandler.HandleException(ex, nameof(GetAllBooks), "No parameters for this method.");
    }

    return dt;
}

        public static int? AddNewBooks(string Title, string ISBN, DateTime? PublicationDate, string Genre, string AdditionalDetails = null)
    {
        int? BookID = null;

        try
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SP_Add_Books";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Title", Title);
                    command.Parameters.AddWithValue("@ISBN", ISBN);
                    command.Parameters.AddWithValue("@PublicationDate", PublicationDate);
                    command.Parameters.AddWithValue("@Genre", Genre);
                    command.Parameters.AddWithValue("@AdditionalDetails", AdditionalDetails ?? (object)DBNull.Value);


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
                        BookID = (int)outputIdParam.Value;
                    }

                }
            }
        }
        catch (Exception ex)
        {
            // Handle all exceptions in a general way
            ErrorHandler.HandleException(ex, nameof(AddNewBooks), $"Parameters: string Title, string ISBN, DateTime? PublicationDate, string Genre, string AdditionalDetails = null");
        }

        return BookID;
    }

        public static bool UpdateBooksByID(int? BookID, string Title, string ISBN, DateTime? PublicationDate, string Genre, string AdditionalDetails = null)
{
    int rowsAffected = 0;

    try
    {
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            string query = $@"SP_Update_Books_ByID"; 

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Create the parameters for the stored procedure
                    command.Parameters.AddWithValue("@BookID", BookID);
                    command.Parameters.AddWithValue("@Title", Title);
                    command.Parameters.AddWithValue("@ISBN", ISBN);
                    command.Parameters.AddWithValue("@PublicationDate", PublicationDate);
                    command.Parameters.AddWithValue("@Genre", Genre);
                    command.Parameters.AddWithValue("@AdditionalDetails", AdditionalDetails ?? (object)DBNull.Value);


                // Open the connection and execute the update
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
        }
    }
    catch (Exception ex)
    {
        // Handle exceptions
        ErrorHandler.HandleException(ex, nameof(UpdateBooksByID), $"Parameter: BookID = " + BookID);
    }

    return (rowsAffected > 0);
}

        public static bool DeleteBooks(int BookID)
{
    int rowsAffected = 0;

    try
    {
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            string query = $@"SP_Delete_Books_ByID";  

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
        ErrorHandler.HandleException(ex, nameof(DeleteBooks), $"Parameter: BookID = " + BookID);
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
            string query = $@"SP_Search_Books_ByColumn";

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
