
using System;
using System.Data;
using System.Runtime.InteropServices;
using LibraryDb_DataLayer;

namespace LibraryDb_BusinessLayer
{
    public class clsBooks
    {
        //#nullable enable

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? BookID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public DateTime? PublicationDate { get; set; }
        public string Genre { get; set; }
        public string AdditionalDetails { get; set; } = null;


        public clsBooks()
        {
            this.BookID = null;
            this.Title = "";
            this.ISBN = "";
            this.PublicationDate = DateTime.Now;
            this.Genre = "";
            this.AdditionalDetails = null;
            Mode = enMode.AddNew;
        }


        private clsBooks(
int? BookID, string Title, string ISBN, DateTime? PublicationDate, string Genre, string AdditionalDetails = null)        {
            this.BookID = BookID;
            this.Title = Title;
            this.ISBN = ISBN;
            this.PublicationDate = PublicationDate;
            this.Genre = Genre;
            this.AdditionalDetails = AdditionalDetails;
            Mode = enMode.Update;
        }


       private bool _AddNewBooks()
       {
        this.BookID = clsBooksData.AddNewBooks(
this.Title, this.ISBN, this.PublicationDate, this.Genre, this.AdditionalDetails);
        return (this.BookID != null);
       }


       public static bool AddNewBooks(
ref int? BookID, string Title, string ISBN, DateTime? PublicationDate, string Genre, string AdditionalDetails = null)        {
        BookID = clsBooksData.AddNewBooks(
Title, ISBN, PublicationDate, Genre, AdditionalDetails);

        return (BookID != null);

       }


       private bool _UpdateBooks()
       {
        return clsBooksData.UpdateBooksByID(
this.BookID, this.Title, this.ISBN, this.PublicationDate, this.Genre, this.AdditionalDetails);
       }


       public static bool UpdateBooksByID(
int? BookID, string Title, string ISBN, DateTime? PublicationDate, string Genre, string AdditionalDetails = null)        {
        return clsBooksData.UpdateBooksByID(
BookID, Title, ISBN, PublicationDate, Genre, AdditionalDetails);

        }


       public static clsBooks FindByBookID(int? BookID)

        {
            if (BookID == null)
            {
                return null;
            }
            string Title = "";
            string ISBN = "";
            DateTime? PublicationDate = DateTime.Now;
            string Genre = "";
            string AdditionalDetails = "";
            bool IsFound = clsBooksData.GetBooksInfoByID(BookID,
                  ref Title,  ref ISBN,  ref PublicationDate,  ref Genre,  ref AdditionalDetails);

           if (IsFound)
               return new clsBooks(
                BookID, Title, ISBN, PublicationDate, Genre, AdditionalDetails);
            else
                return null;
       }

        public static clsBooks FindBookByCopyID(int? CopyID)

        {
            if (CopyID == null)
            {
                return null;
            }
            int? BookID = null;
            string Title = "";
            string ISBN = "";
            DateTime? PublicationDate = DateTime.Now;
            string Genre = "";
            string AdditionalDetails = "";
            bool IsFound = clsBooksData.GetBooksInfoByCopyID(CopyID, ref BookID,
                  ref Title, ref ISBN, ref PublicationDate, ref Genre, ref AdditionalDetails);

            if (IsFound)
                return new clsBooks(
                 BookID, Title, ISBN, PublicationDate, Genre, AdditionalDetails);
            else
                return null;
        }


        public static DataTable GetAllBooks()
       {

        return clsBooksData.GetAllBooks();

       }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewBooks())
                    {
                        Mode = enMode.Update;
                         return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateBooks();

            }
        
            return false;
        }



       public static bool DeleteBooks(int BookID)
       {
            bool copyDeletedSuccessfully = clsBookCopies.DeleteBookCopiesByBooKID(BookID);
            //we make sure, that all Copies of the book have been deleted successfully.
            if (!copyDeletedSuccessfully)
                return false;

              return clsBooksData.DeleteBooks(BookID);
       }


        public enum BooksColumn
         {
            BookID,
            Title,
            ISBN,
            PublicationDate,
            Genre,
            AdditionalDetails
         }


        public enum SearchMode
        {
            Anywhere,
            StartsWith,
            EndsWith,
            ExactMatch
        }
    

        public static DataTable SearchData(BooksColumn ChosenColumn, string SearchValue, SearchMode Mode = SearchMode.Anywhere)
        {
            if (string.IsNullOrWhiteSpace(SearchValue) || !SqlHelper.IsSafeInput(SearchValue))
                return new DataTable();

            string modeValue = Mode.ToString(); // Get the mode as string for passing to the stored procedure

            return clsBooksData.SearchData(ChosenColumn.ToString(), SearchValue, modeValue);
        }        



    }
}
