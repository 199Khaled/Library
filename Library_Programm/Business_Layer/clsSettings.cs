
using System;
using System.Data;
using LibraryDb_DataLayer;

namespace LibraryDb_BusinessLayer
{
    public class clsSettings
    {
        //#nullable enable

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? SettingID { get; set; }
        public byte? DefaultBorrowingDays { get; set; }
        public byte? DefaultReservationDays { get; set; }
        public decimal? DefaultFilePerDay { get; set; }


        public clsSettings()
        {
            this.SettingID = null;
            this.DefaultBorrowingDays = default(byte);
            this.DefaultReservationDays = default(byte);
            this.DefaultFilePerDay = default(decimal);
            Mode = enMode.AddNew;
        }


        private clsSettings(
int? SettingID, byte? DefaultBorrowingDays, byte? DefaultReservationDays, decimal? DefaultFilePerDay)        {
            this.SettingID = SettingID;
            this.DefaultBorrowingDays = DefaultBorrowingDays;
            this.DefaultReservationDays = DefaultReservationDays;
            this.DefaultFilePerDay = DefaultFilePerDay;
            Mode = enMode.Update;
        }


       private bool _AddNewSettings()
       {
        this.SettingID = clsSettingsData.AddNewSettings(
this.DefaultBorrowingDays, this.DefaultReservationDays, this.DefaultFilePerDay);
        return (this.SettingID != null);
       }


       public static bool AddNewSettings(
ref int? SettingID, byte? DefaultBorrowingDays, byte? DefaultReservationDays, decimal? DefaultFilePerDay)        {
        SettingID = clsSettingsData.AddNewSettings(
DefaultBorrowingDays, DefaultReservationDays, DefaultFilePerDay);

        return (SettingID != null);

       }


       private bool _UpdateSettings()
       {
        return clsSettingsData.UpdateSettingsByID(
this.SettingID, this.DefaultBorrowingDays, this.DefaultReservationDays, this.DefaultFilePerDay);
       }


       public static bool UpdateSettingsByID(
int? SettingID, byte? DefaultBorrowingDays, byte? DefaultReservationDays, decimal? DefaultFilePerDay)        {
        return clsSettingsData.UpdateSettingsByID(
SettingID, DefaultBorrowingDays, DefaultReservationDays, DefaultFilePerDay);

        }


       public static clsSettings FindBySettingID(int? SettingID)

        {
            if (SettingID == null)
            {
                return null;
            }
            byte? DefaultBorrowingDays = default(byte);
            byte? DefaultReservationDays = default(byte);
            decimal? DefaultFilePerDay = default(decimal);
            bool IsFound = clsSettingsData.GetSettingsInfoByID(SettingID,
 ref DefaultBorrowingDays,  ref DefaultReservationDays,  ref DefaultFilePerDay);

           if (IsFound)
               return new clsSettings(
SettingID, DefaultBorrowingDays, DefaultReservationDays, DefaultFilePerDay);
            else
                return null;
            }


       public static DataTable GetAllSettings()
       {

        return clsSettingsData.GetAllSettings();

       }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewSettings())
                    {
                        Mode = enMode.Update;
                         return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateSettings();

            }
        
            return false;
        }



       public static bool DeleteSettings(int SettingID)
       {

        return clsSettingsData.DeleteSettings(SettingID);

       }


        public enum SettingsColumn
         {
            SettingID,
            DefaultBorrowingDays,
            DefaultReservationDays,
            DefaultFilePerDay
         }


        public enum SearchMode
        {
            Anywhere,
            StartsWith,
            EndsWith,
            ExactMatch
        }
    

        public static DataTable SearchData(SettingsColumn ChosenColumn, string SearchValue, SearchMode Mode = SearchMode.Anywhere)
        {
            if (string.IsNullOrWhiteSpace(SearchValue) || !SqlHelper.IsSafeInput(SearchValue))
                return new DataTable();

            string modeValue = Mode.ToString(); // Get the mode as string for passing to the stored procedure

            return clsSettingsData.SearchData(ChosenColumn.ToString(), SearchValue, modeValue);
        }        



    }
}
