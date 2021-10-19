using BMS.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BMS
{
    public static class Global
    {
        //public static string Pass
        static int _AppUserID;
        static int _AppGroupID;
        static string _AppUserName = "";
        static string _AppFullName = "";
        static string _AppPassword;
        static int _AppRegionID;
        static bool _IsRoot = false;

        static string _ConnectionString = @"Server=LAPTOP-G3GTTN00\SQLEXPRESS;Database=SumitomoTest;uid=sa;pwd=123@123a;";
       // static string _ConnectionString = "";

        static string _AppUserCode;
        static int _StoreID;
        public static int DepartmentID = 1;

        static decimal _ExchangeRate = 0;
        static string _CashierNo = "";
        static int _ShiftID = 0;
        static bool _isNotCreateSession = true;

        static string _ServerName = "";
        static string _DatabaseName = "";

        static int _OutletID;
        static int _ZoneID;
        static int _ComputerID;

        static int _ExportPrice;

        static int _MainViewID;
        public static string ComputerName { get; set; }
        public static string ComputerMACAddresses { get; set; }
        public static bool IsTest { get; set; }

        static public int ExportPrice
        {
            get { return _ExportPrice; }
            set { _ExportPrice = value; }
        }

        static public int ComputerID
        {
            get { return _ComputerID; }
            set { _ComputerID = value; }
        }

        static public decimal ExchangeRate
        {
            get { return _ExchangeRate; }
            set { _ExchangeRate = value; }
        }

        /// <summary>
        /// Access routine for global variable.
        /// </summary>
        public static int ShiftID
        {
            get { return _ShiftID; }
            set { _ShiftID = value; }
        }

        /// <summary>
        /// Access routine for global variable.
        /// </summary>
        public static bool IsNotCreateSession
        {
            get { return _isNotCreateSession; }
            set { _isNotCreateSession = value; }
        }

        /// <summary>
        /// Access routine for global variable.
        /// </summary>
        public static string CashierNo
        {
            get { return _CashierNo; }
            set { _CashierNo = value; }
        }
        /// <summary>
        /// Access routine for global variable.
        /// </summary>
        public static string ServerName
        {
            get { return _ServerName; }
            set { _ServerName = value; }
        }
        /// <summary>
        /// Access routine for global variable.
        /// </summary>
        public static string DatabaseName
        {
            get { return _DatabaseName; }
            set { _DatabaseName = value; }
        }

        public static string LoginName
        {
            get { return Global._AppUserCode; }
            set { Global._AppUserCode = value; }
        }

        public static int UserID
        {
            get { return _AppUserID; }
            set { _AppUserID = value; }
        }

        public static int MainViewID
        {
            get { return _MainViewID; }
            set { _MainViewID = value; }
        }

        public static int RegionID
        {
            get { return _AppRegionID; }
            set { _AppRegionID = value; }
        }

        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(_ConnectionString))
                {
                    string strPath = Application.StartupPath.ToString() + @"\default.ini";
                    _ConnectionString = MD5.DecodeChecksum(File.ReadAllText(strPath));
                    //return _ConnectionString;
                }
                return _ConnectionString;
            }
            //set { _ConnectionString = value; }
        }

        public static int AppGroupID
        {
            get { return _AppGroupID; }
            set { _AppGroupID = value; }
        }

        public static string AppUserName
        {
            get { return _AppUserName; }
            set { _AppUserName = value; }
        }

        public static string AppFullName
        {
            get { return _AppFullName; }
            set { _AppFullName = value; }
        }

        public static string AppPassword
        {
            get { return _AppPassword; }
            set { _AppPassword = value; }
        }

        public static bool IsRoot
        {
            get { return _IsRoot; }
            set { _IsRoot = value; }
        }

        public static int StoreID
        {
            get { return _StoreID; }
            set { _StoreID = value; }
        }

        public static int OutlefID
        {
            get { return _OutletID; }
            set { _OutletID = value; }
        }

        public static int ZoneID
        {
            get { return _ZoneID; }
            set { _ZoneID = value; }
        }
        public static string DefaultFileName { get; set; }
        public static int SessionID { get; set; }
        public static int ChangePassType { get; set; }//0: bình thường, k đổi pass, 1: hết hạn đổi pass, 2: Reset pass

        public static bool IsInvStore { get; set; }

        public static string BPX_Ext { get; set; }

        public static string PBXNum { get; set; }

        public static string Default_PBX_Interface { get; set; }

        public static string SiteName { get; set; }

        public static string DebitNoteDetailPrintName { get; set; }

        public static string DebitNoteDetailPrintName_ENG { get; set; }
        public static int UserGroupID { get; set; }
    }
}
