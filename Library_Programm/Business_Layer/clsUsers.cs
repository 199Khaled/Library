
using System;
using System.Data;
using LibraryDb_DataLayer;

namespace LibraryDb_BusinessLayer
{
    public class clsUsers
    {
        //#nullable enable

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? UserID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
        public string Telefon { get; set; } = null;
        public string Email { get; set; } = null;
        public string LibraryCardNumber { get; set; } = null;


        public clsUsers()
        {
            this.UserID = null;
            this.Firstname = "";
            this.Lastname = "";
            this.City = "";
            this.Telefon = null;
            this.Email = null;
            this.LibraryCardNumber = null;
            Mode = enMode.AddNew;
        }


        private clsUsers(
int? UserID, string Firstname, string Lastname, string City, string Telefon = null, string Email = null, string LibraryCardNumber = null)        {
            this.UserID = UserID;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.City = City;
            this.Telefon = Telefon;
            this.Email = Email;
            this.LibraryCardNumber = LibraryCardNumber;
            Mode = enMode.Update;
        }


       private bool _AddNewUsers()
       {
        this.UserID = clsUsersData.AddNewUsers(
this.Firstname, this.Lastname, this.City, this.Telefon, this.Email, this.LibraryCardNumber);
        return (this.UserID != null);
       }


       public static bool AddNewUsers(
ref int? UserID, string Firstname, string Lastname, string City, string Telefon = null, string Email = null, string LibraryCardNumber = null)        {
        UserID = clsUsersData.AddNewUsers(
Firstname, Lastname, City, Telefon, Email, LibraryCardNumber);

        return (UserID != null);

       }


       private bool _UpdateUsers()
       {
        return clsUsersData.UpdateUsersByID(
this.UserID, this.Firstname, this.Lastname, this.City, this.Telefon, this.Email, this.LibraryCardNumber);
       }


       public static bool UpdateUsersByID(
int? UserID, string Firstname, string Lastname, string City, string Telefon = null, string Email = null, string LibraryCardNumber = null)        {
        return clsUsersData.UpdateUsersByID(
UserID, Firstname, Lastname, City, Telefon, Email, LibraryCardNumber);

        }


       public static clsUsers FindByUserID(int? UserID)

        {
            if (UserID == null)
            {
                return null;
            }
            string Firstname = "";
            string Lastname = "";
            string City = "";
            string Telefon = "";
            string Email = "";
            string LibraryCardNumber = "";
            bool IsFound = clsUsersData.GetUsersInfoByID(UserID,
 ref Firstname,  ref Lastname,  ref City,  ref Telefon,  ref Email,  ref LibraryCardNumber);

           if (IsFound)
               return new clsUsers(
UserID, Firstname, Lastname, City, Telefon, Email, LibraryCardNumber);
            else
                return null;
            }


       public static DataTable GetAllUsers()
       {

        return clsUsersData.GetAllUsers();

       }
        public static bool IsCardNumberExists(string CardNumber)
        {
            return clsUsersData.IsCardNumberExists(CardNumber);
        }
       public static bool DoesUserExists(int userID)
        {
            return clsUsersData.DoesUserExist(userID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewUsers())
                    {
                        Mode = enMode.Update;
                         return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateUsers();

            }
        
            return false;
        }



       public static bool DeleteUsers(int UserID)
       {

        return clsUsersData.DeleteUsers(UserID);

       }


        public enum UsersColumn
         {
            UserID,
            Firstname,
            Lastname,
            City,
            Telefon,
            Email,
            LibraryCardNumber
         }


        public enum SearchMode
        {
            Anywhere,
            StartsWith,
            EndsWith,
            ExactMatch
        }
    

        public static DataTable SearchData(UsersColumn ChosenColumn, string SearchValue, SearchMode Mode = SearchMode.Anywhere)
        {
            if (string.IsNullOrWhiteSpace(SearchValue) || !SqlHelper.IsSafeInput(SearchValue))
                return new DataTable();

            string modeValue = Mode.ToString(); // Get the mode as string for passing to the stored procedure

            return clsUsersData.SearchData(ChosenColumn.ToString(), SearchValue, modeValue);
        }        



    }
}
