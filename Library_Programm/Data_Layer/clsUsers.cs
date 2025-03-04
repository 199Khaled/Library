
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using LibraryDb_DataAccess;
using Newtonsoft.Json;

namespace LibraryDb_DataLayer
{
    public class clsUsersData
    {
        //#nullable enable

        public static bool GetUsersInfoByID(int? UserID , ref string Firstname, ref string Lastname, ref string City, ref string Telefon, ref string Email, ref string LibraryCardNumber)
{
    bool isFound = false;

    try
    {
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            string query = "SP_Get_Users_ByID";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Ensure correct parameter assignment
                command.Parameters.AddWithValue("@UserID", UserID ?? (object)DBNull.Value);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                { 
                    if (reader.Read())
                    {
                        // The record was found
                        isFound = true;

                                Firstname = (string)reader["Firstname"];
                                Lastname = (string)reader["Lastname"];
                                City = (string)reader["City"];
                                Telefon = reader["Telefon"] != DBNull.Value ? reader["Telefon"].ToString() : null;
                                Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : null;
                                LibraryCardNumber = reader["LibraryCardNumber"] != DBNull.Value ? reader["LibraryCardNumber"].ToString() : null;

                    }
                }
            }
        }
    }
    catch (Exception ex)
    {
        // Handle all exceptions in a general way
        ErrorHandler.HandleException(ex, nameof(GetUsersInfoByID), $"Parameter: UserID = " + UserID);
    }

    return isFound;
}

        public static DataTable GetAllUsers()
{
    DataTable dt = new DataTable();

    try
    {
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            string query = "SP_Get_All_Users";

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
        ErrorHandler.HandleException(ex, nameof(GetAllUsers), "No parameters for this method.");
    }

    return dt;
}
        public static bool DoesUserExist(int userID)
        {
            int result = -1;
            try
            {
                using (SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_Check_UserID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", userID);

                    con.Open();
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                // Handle all exceptions in a general way
                ErrorHandler.HandleException(ex, nameof(DoesUserExist), $"Parameter: UserID = " + userID);
            }
            return result == 1; // Gibt true zurück, wenn UserID existiert, sonst false
        }

        public static int? AddNewUsers(string Firstname, string Lastname, string City, string Telefon = null, string Email = null, string LibraryCardNumber = null)
    {
        int? UserID = null;

        try
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SP_Add_Users";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Firstname", Firstname);
                    command.Parameters.AddWithValue("@Lastname", Lastname);
                    command.Parameters.AddWithValue("@City", City);
                    command.Parameters.AddWithValue("@Telefon", Telefon ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Email", Email ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@LibraryCardNumber", LibraryCardNumber ?? (object)DBNull.Value);


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
                        UserID = (int)outputIdParam.Value;
                    }

                }
            }
        }
        catch (Exception ex)
        {
            // Handle all exceptions in a general way
            ErrorHandler.HandleException(ex, nameof(AddNewUsers), $"Parameters: string Firstname, string Lastname, string City, string Telefon = null, string Email = null, string LibraryCardNumber = null");
        }

        return UserID;
    }

        public static bool UpdateUsersByID(int? UserID, string Firstname, string Lastname, string City, string Telefon = null, string Email = null, string LibraryCardNumber = null)
{
    int rowsAffected = 0;

    try
    {
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            string query = $@"SP_Update_Users_ByID"; 

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Create the parameters for the stored procedure
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@Firstname", Firstname);
                    command.Parameters.AddWithValue("@Lastname", Lastname);
                    command.Parameters.AddWithValue("@City", City);
                    command.Parameters.AddWithValue("@Telefon", Telefon ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Email", Email ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@LibraryCardNumber", LibraryCardNumber ?? (object)DBNull.Value);


                // Open the connection and execute the update
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
        }
    }
    catch (Exception ex)
    {
        // Handle exceptions
        ErrorHandler.HandleException(ex, nameof(UpdateUsersByID), $"Parameter: UserID = " + UserID);
    }

    return (rowsAffected > 0);
}

        public static bool DeleteUsers(int UserID)
{
    int rowsAffected = 0;

    try
    {
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            string query = $@"SP_Delete_Users_ByID";  

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserID", UserID);

                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }
        }
    }
    catch (Exception ex)
    {
        // Handle all exceptions in a general way, this includes errors from SP_HandleError if any
        ErrorHandler.HandleException(ex, nameof(DeleteUsers), $"Parameter: UserID = " + UserID);
    }

    return (rowsAffected > 0);
}
        public static bool IsCardNumberExists(string CardNumber)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = $@"Select Find=1 From Users Where LibraryCardNumber = @CardNumber ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    { 

                        command.Parameters.AddWithValue("@CardNumber", CardNumber);

                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null)
                            rowsAffected = (int)result;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle all exceptions in a general way, this includes errors from SP_HandleError if any
                ErrorHandler.HandleException(ex, nameof(DeleteUsers), $"Parameter: CardNumber = " + CardNumber);
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
            string query = $@"SP_Search_Users_ByColumn";

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
