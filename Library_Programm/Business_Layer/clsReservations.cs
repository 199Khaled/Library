
using System;
using System.Data;
using LibraryDb_DataLayer;

namespace LibraryDb_BusinessLayer
{
    public class clsReservations
    {
        //#nullable enable

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? ReservationID { get; set; }
        public int? UserID { get; set; }
        public clsUsers UsersInfo { get; set; }
        public int? CopyID { get; set; }
        public clsBookCopies BookCopiesInfo { get; set; }
        public DateTime? ReservationDate { get; set; }
        public bool? IsReserved { get; set; }

        public clsReservations()
        {
            this.ReservationID = null;
            this.UserID = 0;
            this.CopyID = 0;
            this.ReservationDate = DateTime.Now;
            this.IsReserved = true;
            Mode = enMode.AddNew;
        }


        private clsReservations(int? ReservationID, int? UserID, int? CopyID, DateTime? ReservationDate, bool? IsReserved)        {
            this.ReservationID = ReservationID;
            this.UserID = UserID;
            this.UsersInfo = clsUsers.FindByUserID(UserID);
            this.CopyID = CopyID;
            this.BookCopiesInfo = clsBookCopies.FindByCopyID(CopyID);
            this.ReservationDate = ReservationDate;
            this.IsReserved = IsReserved;
            Mode = enMode.Update;
        }


       private bool _AddNewReservations()
       {
        this.ReservationID = clsReservationsData.AddNewReservations(
this.UserID, this.CopyID, this.ReservationDate, this.IsReserved);
        return (this.ReservationID != null);
       }


       public static bool AddNewReservations(
ref int? ReservationID, int? UserID, int? CopyID, DateTime? ReservationDate, bool? IsReserved)        {
        ReservationID = clsReservationsData.AddNewReservations(
UserID, CopyID, ReservationDate, IsReserved);

        return (ReservationID != null);

       }


       private bool _UpdateReservations()
       {
        return clsReservationsData.UpdateReservationsByID(
this.ReservationID, this.UserID, this.CopyID, this.ReservationDate, this.IsReserved);
       }


       public static bool UpdateReservationsByID(
int? ReservationID, int? UserID, int? CopyID, DateTime? ReservationDate, bool? IsReserved)        {
        return clsReservationsData.UpdateReservationsByID(
ReservationID, UserID, CopyID, ReservationDate,IsReserved);

        }


       public static clsReservations FindByReservationID(int? ReservationID)

        {
            if (ReservationID == null)
            {
                return null;
            }
            int? UserID = 0;
            int? CopyID = 0;
            DateTime? ReservationDate = DateTime.Now;
            bool? IsReserved = true;
            bool IsFound = clsReservationsData.GetReservationsInfoByID(ReservationID,
 ref UserID,  ref CopyID,  ref ReservationDate, ref IsReserved);

           if (IsFound)
               return new clsReservations(
ReservationID, UserID, CopyID, ReservationDate, IsReserved);
            else
                return null;
            }


       public static DataTable GetAllReservations()
       {

        return clsReservationsData.GetAllReservations();

       }

        public static bool IsThis_BookCopyReserved(int? CopyID)
        {
            return clsReservationsData.IsThis_BookCopyReserved(CopyID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewReservations())
                    {
                        Mode = enMode.Update;
                         return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateReservations();

            }
        
            return false;
        }



       public static bool DeleteReservations(int ReservationID)
       {

        return clsReservationsData.DeleteReservations(ReservationID);

       }


        public enum ReservationsColumn
         {
            ReservationID,
            UserID,
            CopyID,
            ReservationDate
         }


        public enum SearchMode
        {
            Anywhere,
            StartsWith,
            EndsWith,
            ExactMatch
        }
    

        public static DataTable SearchData(ReservationsColumn ChosenColumn, string SearchValue, SearchMode Mode = SearchMode.Anywhere)
        {
            if (string.IsNullOrWhiteSpace(SearchValue) || !SqlHelper.IsSafeInput(SearchValue))
                return new DataTable();

            string modeValue = Mode.ToString(); // Get the mode as string for passing to the stored procedure

            return clsReservationsData.SearchData(ChosenColumn.ToString(), SearchValue, modeValue);
        }        



    }
}
