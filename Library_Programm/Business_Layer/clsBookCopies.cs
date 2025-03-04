
using System;
using System.Data;
using System.Runtime.CompilerServices;
using LibraryDb_DataLayer;

namespace LibraryDb_BusinessLayer
{
    public class clsBookCopies
    {
        //#nullable enable

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? CopyID { get; set; }
        public int? BookID { get; set; }
        public int? CopyCount { get; set; }
        public clsBooks BooksInfo { get; set; }
        public bool? AvailabilityStatus { get; set; }


        public clsBookCopies()
        {
            this.CopyID = null;
            this.BookID = null;
            this.CopyCount = null;
            this.AvailabilityStatus = false;
            Mode = enMode.AddNew;
        }


        private clsBookCopies(int? CopyID, int? BookID, int? CopyCount , bool? AvailabilityStatus)       
        {
            this.CopyID = CopyID;
            this.BookID = BookID;
            this.CopyCount = CopyCount; 
            this.BooksInfo = clsBooks.FindByBookID(BookID);
            this.AvailabilityStatus = AvailabilityStatus;
            Mode = enMode.Update;
        }


       private bool _AddNewBookCopies()
       {
        this.CopyID = clsBookCopiesData.AddNewBookCopies(this.BookID, this.CopyCount,  this.AvailabilityStatus);
        return (this.CopyID != null);
       }


       public static bool AddNewBookCopies(ref int? CopyID, int? BookID, int? CopyCount, bool? AvailabilityStatus)     
        {CopyID = clsBookCopiesData.AddNewBookCopies(BookID, CopyCount, AvailabilityStatus);

        return (CopyID != null);

       }


       private bool _UpdateBookCopies()
       {
        return clsBookCopiesData.UpdateBookCopiesByID(
this.CopyID, this.BookID, this.AvailabilityStatus);
       }


       public static bool UpdateBookCopiesByID(
int? CopyID, int? BookID, bool? AvailabilityStatus)        {
        return clsBookCopiesData.UpdateBookCopiesByID(
             CopyID, BookID, AvailabilityStatus);

        }


       public static clsBookCopies FindByCopyID(int? CopyID)

        {
            if (CopyID == null)
            {
                return null;
            }
            int? BookID = 0;
            int? CopyCount = 0;
            bool? AvailabilityStatus = false;
            bool IsFound = clsBookCopiesData.GetBookCopiesInfoByID(CopyID,ref BookID, ref CopyCount,  ref AvailabilityStatus);

           if (IsFound)
               return new clsBookCopies(CopyID, BookID, CopyCount, AvailabilityStatus);
            else
                return null;
       }
        public static DataTable GetAllBookCopiesByBookID(int? BookID)
        {
            return clsBookCopiesData.GetAllAvailableBookCopiesByBookID(BookID);
        }
        public static clsBookCopies FindByBookID(int? BookID)

        {
            if (BookID == null)
            {
                return null;
            }
            int? CopyID = 0;
            bool? AvailabilityStatus = false;
            bool IsFound = clsBookCopiesData.GetBookCopiesInfoByBookID(ref CopyID, BookID, ref AvailabilityStatus);

            if (IsFound)
                return new clsBookCopies(CopyID, BookID, 0, AvailabilityStatus); //we set null, because we do not have any column for CopyCout 
                                                             //it just will be used for adding new Copies by the loop.
            else
                return null;
        }


        public static DataTable GetAllBookCopies()
       {

        return clsBookCopiesData.GetAllBookCopies();

       }

        public static bool DoesBookCopyExistsAndAvailable(int copyID)
        {
            return clsBookCopiesData.DoesBookCopyExistAndAvailable(copyID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewBookCopies())
                    {
                        Mode = enMode.Update;
                         return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateBookCopies();

            }
        
            return false;
        }



       public static bool DeleteBookCopies(int CopyID)
       {

        return clsBookCopiesData.DeleteBookCopies(CopyID);

       }
        public static bool DeleteBookCopiesByBooKID(int BookID)
        {

            return clsBookCopiesData.DeleteBookCopiesByBookID(BookID);

        }

        public enum BookCopiesColumn
         {
            CopyID,
            BookID,
            AvailabilityStatus
         }


        public enum SearchMode
        {
            Anywhere,
            StartsWith,
            EndsWith,
            ExactMatch
        }
    

        public static DataTable SearchData(BookCopiesColumn ChosenColumn, string SearchValue, SearchMode Mode = SearchMode.Anywhere)
        {
            if (string.IsNullOrWhiteSpace(SearchValue) || !SqlHelper.IsSafeInput(SearchValue))
                return new DataTable();

            string modeValue = Mode.ToString(); // Get the mode as string for passing to the stored procedure

            return clsBookCopiesData.SearchData(ChosenColumn.ToString(), SearchValue, modeValue);
        }        



    }
}
