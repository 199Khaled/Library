
using System;
using System.Data;
using LibraryDb_DataLayer;

namespace LibraryDb_BusinessLayer
{
    public class clsBorrowingRecords
    {
        //#nullable enable

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? BorrowingRecordID { get; set; }
        public int? UserID { get; set; }
        public clsUsers UsersInfo { get; set; }
        public int? CopyID { get; set; }
        public clsBookCopies BookCopiesInfo { get; set; }
        public DateTime? BorrowingDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }


        public clsBorrowingRecords()
        {
            this.BorrowingRecordID = null;
            this.UserID = 0;
            this.CopyID = 0;
            this.BorrowingDate = DateTime.Now;
            this.DueDate = DateTime.Now;

            Mode = enMode.AddNew;
        }


        private clsBorrowingRecords(
     int? BorrowingRecordID, int? UserID, int? CopyID, DateTime? BorrowingDate, DateTime? DueDate, DateTime? ActualReturnDate)        {
            this.BorrowingRecordID = BorrowingRecordID;
            this.UserID = UserID;
            this.UsersInfo = clsUsers.FindByUserID(UserID);
            this.CopyID = CopyID;
            this.BookCopiesInfo = clsBookCopies.FindByCopyID(CopyID);
            this.BorrowingDate = BorrowingDate;
            this.DueDate = DueDate;
            this.ActualReturnDate = ActualReturnDate;
            Mode = enMode.Update;
        }


       private bool _AddNewBorrowingRecords()
       {
        this.BorrowingRecordID = clsBorrowingRecordsData.AddNewBorrowingRecords(
this.UserID, this.CopyID, this.BorrowingDate, this.DueDate, this.ActualReturnDate);
        return (this.BorrowingRecordID != null);
       }


       public static bool AddNewBorrowingRecords(
ref int? BorrowingRecordID, int? UserID, int? CopyID, DateTime? BorrowingDate, DateTime? DueDate, DateTime? ActualReturnDate)        {
        BorrowingRecordID = clsBorrowingRecordsData.AddNewBorrowingRecords(
UserID, CopyID, BorrowingDate, DueDate, ActualReturnDate);

        return (BorrowingRecordID != null);

       }


       private bool _UpdateBorrowingRecords()
       {
        return clsBorrowingRecordsData.UpdateBorrowingRecordsByID(
this.BorrowingRecordID, this.UserID, this.CopyID, this.BorrowingDate, this.DueDate, this.ActualReturnDate);
       }


       public static bool UpdateBorrowingRecordsByID(
int? BorrowingRecordID, int? UserID, int? CopyID, DateTime? BorrowingDate, DateTime? DueDate, DateTime? ActualReturnDate)        {
        return clsBorrowingRecordsData.UpdateBorrowingRecordsByID(
BorrowingRecordID, UserID, CopyID, BorrowingDate, DueDate, ActualReturnDate);

        }


       public static clsBorrowingRecords FindByBorrowingRecordID(int? BorrowingRecordID)

        {
            if (BorrowingRecordID == null)
            {
                return null;
            }
            int? UserID = 0;
            int? CopyID = 0;
            DateTime? BorrowingDate = DateTime.Now;
            DateTime? DueDate = DateTime.Now;
            DateTime? ActualReturnDate = null;
            bool IsFound = clsBorrowingRecordsData.GetBorrowingRecordsInfoByID(BorrowingRecordID,
 ref UserID,  ref CopyID,  ref BorrowingDate,  ref DueDate,  ref ActualReturnDate);

           if (IsFound)
               return new clsBorrowingRecords(
BorrowingRecordID, UserID, CopyID, BorrowingDate, DueDate, ActualReturnDate);
            else
                return null;
            }


       public static DataTable GetAllBorrowingRecords()
       {

        return clsBorrowingRecordsData.GetAllBorrowingRecords();

       }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewBorrowingRecords())
                    {
                        Mode = enMode.Update;
                         return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateBorrowingRecords();

            }
        
            return false;
        }



       public static bool DeleteBorrowingRecords(int BorrowingRecordID)
       {

        return clsBorrowingRecordsData.DeleteBorrowingRecords(BorrowingRecordID);

       }


        public enum BorrowingRecordsColumn
         {
            BorrowingRecordID,
            UserID,
            CopyID,
            BorrowingDate,
            DueDate,
            ActualReturnDate
         }


        public enum SearchMode
        {
            Anywhere,
            StartsWith,
            EndsWith,
            ExactMatch
        }
    

        public static DataTable SearchData(BorrowingRecordsColumn ChosenColumn, string SearchValue, SearchMode Mode = SearchMode.Anywhere)
        {
            if (string.IsNullOrWhiteSpace(SearchValue) || !SqlHelper.IsSafeInput(SearchValue))
                return new DataTable();

            string modeValue = Mode.ToString(); // Get the mode as string for passing to the stored procedure

            return clsBorrowingRecordsData.SearchData(ChosenColumn.ToString(), SearchValue, modeValue);
        }        



    }
}
