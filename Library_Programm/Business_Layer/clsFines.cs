
using System;
using System.Data;
using LibraryDb_DataLayer;

namespace LibraryDb_BusinessLayer
{
    public class clsFines
    {
        //#nullable enable

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? FineID { get; set; }
        public int? UserID { get; set; }
        public clsUsers UsersInfo { get; set; }
        public int? BorrowingRecordID { get; set; }
        public clsBorrowingRecords BorrowingRecordsInfo { get; set; }
        public short? NumberOfLateDays { get; set; }
        public decimal? FineAmount { get; set; }
        public bool? PaymentStatus { get; set; }


        public clsFines()
        {
            this.FineID = null;
            this.UserID = 0;
            this.BorrowingRecordID = 0;
            this.NumberOfLateDays = 0;
            this.FineAmount = 0m;
            this.PaymentStatus = false;
            Mode = enMode.AddNew;
        }


        private clsFines(
int? FineID, int? UserID, int? BorrowingRecordID, short? NumberOfLateDays, decimal? FineAmount, bool? PaymentStatus)        {
            this.FineID = FineID;
            this.UserID = UserID;
            this.UsersInfo = clsUsers.FindByUserID(UserID);
            this.BorrowingRecordID = BorrowingRecordID;
            this.BorrowingRecordsInfo = clsBorrowingRecords.FindByBorrowingRecordID(BorrowingRecordID);
            this.NumberOfLateDays = NumberOfLateDays;
            this.FineAmount = FineAmount;
            this.PaymentStatus = PaymentStatus;
            Mode = enMode.Update;
        }


       private bool _AddNewFines()
       {
        this.FineID = clsFinesData.AddNewFines(
this.UserID, this.BorrowingRecordID, this.NumberOfLateDays, this.FineAmount, this.PaymentStatus);
        return (this.FineID != null);
       }


       public static bool AddNewFines(
ref int? FineID, int? UserID, int? BorrowingRecordID, short? NumberOfLateDays, decimal? FineAmount, bool? PaymentStatus)        {
        FineID = clsFinesData.AddNewFines(
UserID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentStatus);

        return (FineID != null);

       }


       private bool _UpdateFines()
       {
        return clsFinesData.UpdateFinesByID(
this.FineID, this.UserID, this.BorrowingRecordID, this.NumberOfLateDays, this.FineAmount, this.PaymentStatus);
       }


       public static bool UpdateFinesByID(
int? FineID, int? UserID, int? BorrowingRecordID, short? NumberOfLateDays, decimal? FineAmount, bool? PaymentStatus)        {
        return clsFinesData.UpdateFinesByID(
FineID, UserID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentStatus);

        }


       public static clsFines FindByFineID(int? FineID)

        {
            if (FineID == null)
            {
                return null;
            }
            int? UserID = 0;
            int? BorrowingRecordID = 0;
            short? NumberOfLateDays = 0;
            decimal? FineAmount = 0m;
            bool? PaymentStatus = false;
            bool IsFound = clsFinesData.GetFinesInfoByID(FineID,
 ref UserID,  ref BorrowingRecordID,  ref NumberOfLateDays,  ref FineAmount,  ref PaymentStatus);

           if (IsFound)
               return new clsFines(
FineID, UserID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentStatus);
            else
                return null;
            }


       public static DataTable GetAllFines()
       {

        return clsFinesData.GetAllFines();

       }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewFines())
                    {
                        Mode = enMode.Update;
                         return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateFines();

            }
        
            return false;
        }



       public static bool DeleteFines(int FineID)
       {

        return clsFinesData.DeleteFines(FineID);

       }


        public enum FinesColumn
         {
            FineID,
            UserID,
            BorrowingRecordID,
            NumberOfLateDays,
            FineAmount,
            PaymentStatus
         }


        public enum SearchMode
        {
            Anywhere,
            StartsWith,
            EndsWith,
            ExactMatch
        }
    

        public static DataTable SearchData(FinesColumn ChosenColumn, string SearchValue, SearchMode Mode = SearchMode.Anywhere)
        {
            if (string.IsNullOrWhiteSpace(SearchValue) || !SqlHelper.IsSafeInput(SearchValue))
                return new DataTable();

            string modeValue = Mode.ToString(); // Get the mode as string for passing to the stored procedure

            return clsFinesData.SearchData(ChosenColumn.ToString(), SearchValue, modeValue);
        }        



    }
}
