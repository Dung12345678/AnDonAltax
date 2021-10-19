using System;
using System.Collections;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Xml;
using System.IO;
using System.Net;
using System.Data.SqlClient;
//using Formula;
using System.Reflection;
using CEFA.Model;
using CEFA.Exceptions;
using CEFA.Utils;
using CEFA.Facade;
using CEFA.Business;
//using RKLib.ExportData;
//using PMS.Business;
using System.Drawing;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;
using System.Threading;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace CEFA.Utils
{
    /// <summary>
    /// Summary description for TextUtils.
    /// </summary>
    public class TextUtilss
    {
        public const string CurrencyFormat = "###,###,###.00";
        public static string Caption = "CS Solution";
        private static DateTime EMPTY_DATE = new DateTime(1, 1, 1);
        private static DateTime CSS_MAX_DATE = DateTime.Parse("1/1/2099");
        private static DateTime MIN_DATE = DateTime.MinValue;
        private static DateTime MAX_DATE = DateTime.MaxValue;

        public static DateTimeFormatInfo VN_DTFI = new CultureInfo("fr-FR", false).DateTimeFormat;

        public TextUtilss()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        /// <summary>
        /// ---DuongNa---
        /// Convert từ một OBJ sang thuộc tính String
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToString(Object obj)
        {
            return (obj == null) ? null : obj.ToString();
        }

        /// <summary>
        /// ---DuongNA---
        /// Convert một chuỗi về kiểu int
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int ToInt(string x)
        {
            try
            {
                return int.Parse(x);
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        /// <summary>
        /// ---DuongNa---
        /// Convert một chuỗi về kiểu int 64
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static Int64 ToInt64(string x)
        {
            try
            {
                return Int64.Parse(x);
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        /// <summary>
        /// ---DuongNa---
        /// Convert một chuỗi về kiểu Decimal
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static Decimal ToDecimal(string x)
        {
            try
            {
                return Decimal.Parse(x);
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        /// <summary>
        /// ---DuongNA---
        /// Kiểm tra dữ liệu kiểu số khi nhập vào các ô textbox
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool CheckNumber(KeyPressEventArgs e)
        {
            //if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && (e.KeyChar != '-'))
            //    e.Handled = true;

            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && (e.KeyChar != '-'))
                return true;
            else
                return false;
        }

        /// <summary>
        /// ---DuongNA---
        /// Đổi từ số sang chữ
        /// </summary>
        /// <param name="Num"></param>
        /// <returns></returns>
        public static string NumericToString(decimal Num)
        {
            string[] Dvi = { "", "ngàn", "triệu", "tỷ", "ngàn" };
            string Result = "";
            long IntNum = (long)Num;
            for (int i = 0; i < 5; i++)
            {
                long Doc = (long)IntNum % 1000;
                if (Doc > 0) Result = NumericToString(Doc, IntNum < 1000) + " " + Dvi[i] + " " + Result;
                IntNum = (long)IntNum / 1000;
            }
            Result += "đồng" + ((((long)Num) % 1000 == 0) ? " chẵn" : "");
            if (Result.ToString().Trim().Substring(0, 1) == "m" && Result.ToString().Trim().Substring(3, 1) == "i")
                Result = "Mười " + Result.Remove(0, 5);
            return Result;
        }
        /// <summary>
        /// ---DuongNA---
        /// Dùng để đổi dấu phân biệt hàng nghìn, hàng đơn vị trong các câu lệnh UPDATE
        /// </summary>
        /// <param name="strNumber"></param>
        /// <returns></returns>
        public static string DoiDau(string strNumber)
        {
            int length = 0; int pos = 0; string st = ""; string DoiDau1 = "";
            st = strNumber;
            pos = st.IndexOf(".", 0);
            while (pos > 0)
            {
                st = st.Substring(0, pos) + st.Remove(0, pos);
                pos = st.IndexOf(".", 0);
            }
            length = st.Length;
            pos = st.IndexOf(",", 0);
            if (pos > 0)
                DoiDau1 = st.Substring(0, pos) + "." + st.Remove(0, pos + 1);
            else
                DoiDau1 = st;

            return DoiDau1;
        }



        public static string FormatDate(DateTime date, string format)
        {
            //if(date.Equals("1/1/2099") || date.Equals("1/1/1")) return "N/A";
            //if (date.Equals(EMPTY_DATE) || date.Equals(MIN_DATE) || date.Equals(CSS_MAX_DATE) || date.Equals(MAX_DATE)) return "N/A";
            if (date.Year < 1000 || date.Year >= 2099) return "N/A";
            return date.ToString(format, DateTimeFormatInfo.InvariantInfo);
        }

        public static string FormatDate(DateTime date)
        {
            return FormatDate(date, "MMM dd, yyyy");
        }

        public static string FormatDateTime(DateTime date)
        {
            //return FormatDate(date, "U");
            return FormatDate(date, "MMM dd, yyyy HH:mm:ss");
        }

        public static string FormatDateToMonthAndYear(string date)
        {
            return FormatDate(ToDate(date), "MMM, yyyy");
        }

        public static string FormatDate(string date)
        {
            return FormatDate(ToDate(date), "MMM dd, yyyy");
        }

        public static DateTime ToDate(string date)
        {
            return DateTime.Parse(date, new CultureInfo("en-US", true));
        }

        public static string ToString1(DateTime date)
        {
            return date.ToString("MM/dd/yyyy", new CultureInfo("en-US", true));
        }

        public static string GetFullMonth(DateTime date)
        {
            //return FormatDate(date, "U");
            return FormatDate(date, "MMMM");
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private static string[] Number_Patterns =
            new string[] { "{0:#,##0}", "{0:#,##0.0}", "{0:#,##0.00}", "{0:#,##0}.000", "{0:#,##0.0000}", "{0:#,##0.00000;#,##0.00000; }" };

        private static string[] Currency_Patterns =
            new string[] { "{0:$#,##0;($#,##0); }", "{0:$#,##0.0;($#,##0.0); }", "{0:$#,##0.00;($#,##0.00); }", "{0:$#,##0.000;($#,##0.000); }", "{0:$#,##0.0000;($#,##0.0000); }", "{0:$#,##0.00000;($#,##0.00000); }" };

        public static string FormatNumber(Decimal x, int digits)
        {
            return String.Format(Number_Patterns[digits], x);
        }

        public static string FormatCurrency(Decimal x, int digits)
        {
            return String.Format(Currency_Patterns[digits], x);
        }

        public static string FormatNumberZeroToDash(Decimal x)
        {
            return String.Format("{0:#,##0.00;(#,##0.00); }", x);
        }

        public static string FormatPercentNumber(Decimal x)
        {
            return String.Format("{0:#0.00}%", x);
        }

        public static ArrayList SplitPrefixes(string rawPref)
        {
            ArrayList prefList = new ArrayList();
            try
            {
                string[] prefParts = rawPref.Split(';');
                for (int i = 0; i < prefParts.Length; i++)
                {
                    string[] temp = prefParts[i].Split('-');
                    //string t = temp[0];string t1 = prefParts[i];
                    if (temp.Length == 1) //no "-"
                    {
                        if (!prefList.Contains(temp[0].Trim())) prefList.Add(temp[0].Trim());
                    }
                    else if (temp.Length == 2) //one "-"
                    {
                        int noOfPrefs = int.Parse(temp[1]) - int.Parse(temp[0]);
                        for (int j = 0; j <= noOfPrefs; j++)
                        {
                            if (!prefList.Contains((int.Parse(temp[0]) + j).ToString().Trim()))
                                prefList.Add((int.Parse(temp[0]) + j).ToString().Trim());
                        }
                    }
                    else//more than one "-"
                    {
                        prefList.Clear();
                    }
                }
            }
            catch
            {
                return prefList;
            }
            return prefList;
        }
        /// <summary>
        /// </summary>
        /// <param name="rawIncr"></param>
        /// <param name="isValid"></param>
        /// <returns></returns>
        public static string[] SplitBillingIncrement(string rawIncr, out bool isValid)
        {

            isValid = false;
            Double result;
            string[] incrParts = rawIncr.Split('+');
            if (incrParts.Length != 2) return incrParts;
            for (int i = 0; i < incrParts.Length; i++)
            {
                if (!Double.TryParse(incrParts[i].ToString(), NumberStyles.Number, NumberFormatInfo.CurrentInfo, out result))
                    return incrParts;
                if (result != int.Parse(result.ToString()) || result <= 0 || result > 60)
                    return incrParts;
            }
            isValid = true;
            return incrParts;
        }

        public static string Error(string msg)
        {
            return "ERROR: " + msg;
        }

        public static string Warn(string msg)
        {
            return "WARNING: " + msg;
        }

        public static string ToHTML(NameValueCollection list)
        {
            StringBuilder r = new StringBuilder();
            foreach (string key in list.AllKeys)
            {
                r.Append("<span class=subtitle2>" + key + "</span>: " + list.Get(key) + "<br>");
            }
            return r.ToString();
        }
        public static bool IsEmail(string str)
        {
            bool State = true;
            if (!Regex.IsMatch(str, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                State = false;
            }

            return State;
        }


        //		private static string NumberToString(int Num)
        //		{
        //			string[] Number = {"không","một","hai","ba","bốn","năm","sáu","bảy","tám","chín"};
        //			return Number[Num];
        //		}
        //
        //		public static string NumberToStringH(int Num)
        //		{
        //			string[] Number = {"không","Một","Hai","Ba","Bốn","Năm","Sáu","Bảy","Tám","Chín"};
        //			return Number[Num];
        //		}
        //		private static string NumericToString(int Num,bool Dau)
        //		{
        //			int Tram = (int) Num / 100;
        //			int Chuc = (int) (Num % 100) /10;
        //			int Dvi = Num % 10;
        //			
        //			string Doc = (((Tram==0)&&(Dau))?"":(" "+NumberToString(Tram)+" trăm"))+((Chuc==0)?(((Tram==0)&&Dau)?"":((Dvi==0)?"":" lẻ")):((Chuc==1)?" mươi":(" "+NumberToString(Chuc)+" mươi")))+(((Dvi==5)&&(Chuc>0))?" năm":((Dvi==0)?"":" "+NumberToString(Dvi)));
        //			return Doc;
        //		}
        //
        //		public static string NumericToString(double Num)
        //		{
        //			string[] Dvi = {"","ngàn","triệu","tỷ"};
        //			string Result = "";
        //			long IntNum = (long) Num;
        //			for (int i=0;i<4;i++)
        //			{
        //				int Doc = (int) IntNum % 1000;
        //				if (Doc>0) Result = NumericToString(Doc,IntNum<1000)+" "+Dvi[i] + " "+Result;
        //				IntNum = (long) IntNum /1000;
        //			}
        //			Result+= "đồng"+((((long) Num)%1000==0)?" chẵn":"");
        //			return Result;
        //		}

        private static string NumberToString(long Num)
        {
            string[] Number = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            return Number[Num];
        }

        public static string NumberToStringH(long Num)
        {
            string[] Number = { "không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
            return Number[Num];
        }

        private static string NumericToString(long Num, bool Dau)
        {
            long Tram = (long)Num / 100;
            long Chuc = (long)(Num % 100) / 10;
            long Dvi = Num % 10;

            string Doc = (((Tram == 0) && (Dau)) ? "" : (" " + NumberToString(Tram) + " trăm")) + ((Chuc == 0) ? (((Tram == 0) && Dau) ? "" : ((Dvi == 0) ? "" : " lẻ")) : ((Chuc == 1) ? " mươi" : (" " + NumberToString(Chuc) + " mươi"))) + (((Dvi == 5) && (Chuc > 0)) ? " năm" : ((Dvi == 0) ? "" : " " + NumberToString(Dvi)));
            return Doc;
        }
        //public static void ExportToExcel(DataTable dataTable)
        //{
        //    SaveFileDialog saveFile = new SaveFileDialog();
        //    saveFile.ShowDialog();
        //    string fileName = saveFile.FileName;
        //    try
        //    {
        //        if (fileName == "") return;
        //        Export objExport = new Export("Win");
        //        objExport.ExportDetails(dataTable, Export.ExportFormat.Excel, fileName + ".xls");
        //        DialogResult dlgR = MessageBox.Show("Would you like to open this file: " + fileName + ".xls?", "Successfully", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (dlgR == DialogResult.Yes)
        //        {                    
        //            Process.Start(fileName+".xls","open" );
        //        }
        //    }
        //    catch (Exception Ex)
        //    {
        //        throw new Exception(Ex.ToString());
        //    }

        //}
        static public DataTable getTable(string procedureName, SqlParameter mySqlParameter, string nameSetToTable)
        {
            DataTable table = new DataTable();
            try
            {
                if (connect())
                {
                    SqlCommand mySqlCommand = new SqlCommand(procedureName, mySqlConnection);
                    mySqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(mySqlCommand);
                    DataSet myDataSet = new DataSet();
                    if (mySqlParameter != null)
                        mySqlCommand.Parameters.Add(mySqlParameter);
                    //mySqlCommand.ExecuteNonQuery();
                    mySqlDataAdapter.Fill(myDataSet, nameSetToTable);
                    table = myDataSet.Tables[nameSetToTable];
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                disconnect();
            }
            return table;
        }


        /// <summary>
        /// Lấy dữ liệu đưa vào Data Table
        /// </summary>
        /// <param name="procedureName"></param>
        /// <param name="mySqlParameter"></param>
        /// <param name="nameSetToTable"></param>
        /// <returns></returns>
        static public DataTable getTable(string procedureName, string nameSetToTable, params SqlParameter[] mySqlParameter)
        {
            DataTable table = new DataTable();
            try
            {
                if (connect())
                {
                    SqlCommand mySqlCommand = new SqlCommand(procedureName, mySqlConnection);
                    mySqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(mySqlCommand);
                    DataSet myDataSet = new DataSet();
                    for (int i = 0; i < mySqlParameter.Length; i++)
                        mySqlCommand.Parameters.Add(mySqlParameter[i]);
                    mySqlCommand.ExecuteNonQuery();
                    mySqlDataAdapter.Fill(myDataSet, nameSetToTable);
                    table = myDataSet.Tables[nameSetToTable];
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                disconnect();
            }
            return table;
        }




        static private SqlConnection mySqlConnection;
        static private bool connect()
        {
            string str = DBUtils.GetDBConnectionString();
            try
            {
                mySqlConnection = new SqlConnection(str);
                mySqlConnection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        static private bool disconnect()
        {
            try
            {
                mySqlConnection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static DateTime GetBusinessDate()
        {
            try
            {
                return Convert.ToDateTime(TextUtilss.getTable("spGetDate", null, "Table").Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static int CompareDate(DateTime date1, DateTime date2)
        {
            if (date1.Day == date2.Day && date1.Month == date2.Month && date1.Year == date2.Year)
                return 0;
            if (date1.Year < date2.Year || (date1.Year == date2.Year && date1.Month < date2.Month) || (date1.Year == date2.Year && date1.Month == date2.Month && date1.Day < date2.Day))
                return -1;
            else
                return 1;

        }
        public static string[] Split(string inputString)
        {
            string[] tem = inputString.Split(',', ' ');
            return tem;
        }
        public static int getDayNumberOf(DateTimePicker Departure, DateTimePicker Arrival)
        {
            Departure.Format = Arrival.Format = DateTimePickerFormat.Custom;
            Departure.CustomFormat = Arrival.CustomFormat;//= "MM/dd/yyyy";
            System.TimeSpan timeSpan = Departure.Value - Arrival.Value;
            int n = (int)Math.Round(timeSpan.TotalDays);
            if (n == 0) return 1;
            return n;
        }
        public static DateTime GetSystemDate()
        {
            try
            {
                return Convert.ToDateTime(TextUtilss.getTable("spGetDateSystem", null, "Table").Rows[0][0]);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Phuong thuc Generate ra chuoi XML tu Model
        /// --- Nguyen Trung Kien 12/10/2009
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        static public string GetXmlContent(BaseModel model)
        {
            #region Lay ra TableName
            string tableName = model.GetType().Name;
            tableName = tableName.Substring(0, tableName.Length - 5);
            #endregion
            #region Lay ra File XMl
            string XMLWriter = "<?xml version='1.0'?>";
            PropertyInfo[] propertiesName = model.GetType().GetProperties();
            XMLWriter = XMLWriter + "<" + tableName + ">";
            for (int i = 0; i < propertiesName.Length; i++)
            {
                XMLWriter = XMLWriter + "<" + propertiesName[i].Name + ">";
                XMLWriter = XMLWriter + propertiesName[i].GetValue(model, null).ToString();
                XMLWriter = XMLWriter + "</" + propertiesName[i].Name + ">";
            }
            XMLWriter = XMLWriter + "</" + tableName + ">";
            return XMLWriter;
            #endregion
        }
        /// <summary>
        /// Phuong thuc do du lieu tu XML string ra model
        /// --- Nguyen Trung Kien 12/10/2009
        /// </summary>
        /// <param name="TableName">Ten bang</param>
        /// <param name="ObjectID">ID cua PK</param>
        /// <param name="SystemDate">Ngay he thong</param>
        /// <param name="BussinessDate">BussinessDate</param>
        /// <param name="UserID">User</param>
        /// <returns></returns>

        static public BaseModel GetModelFromXML(string TableName, string XmlContent)
        {
            #region Khởi tạo Model
            string fullname = "CEFA.Model." + ProcessTransaction.getClassName(TableName);
            BaseModel mB = (BaseModel)PropertyUtils.getObject(fullname);
            #endregion
            #region Doc du lieu
            XmlTextReader Reader = new XmlTextReader(new System.IO.StringReader(XmlContent));
            #endregion
            #region Khoi tao mang va gan gia tri vao do
            string[] paramName = new string[mB.GetType().GetProperties().Length];
            string[] paramValue = new string[mB.GetType().GetProperties().Length];
            int k = 0;
            while (Reader.Read())
            {
                if (Reader.NodeType == XmlNodeType.Element)
                {
                    if (!Reader.LocalName.Equals(TableName))
                    {
                        paramName[k] = Reader.LocalName;
                        paramValue[k] = Reader.ReadString();
                        k = k + 1;
                    }
                }
            }
            #endregion
            #region xu li va do du lieu vao model neu co
            PropertyInfo[] propertiesName = mB.GetType().GetProperties();
            for (int i = 0; i < propertiesName.Length; i++)
            {
                for (int j = 0; j < paramName.Length; j++)
                {
                    if (propertiesName[i].Name.Equals(paramName[j]))
                    {
                        if (propertiesName[i].PropertyType.Name.Equals("Int32"))
                        {
                            propertiesName[i].SetValue(mB, Convert.ToInt32(paramValue[j]), null);
                        }
                        else if (propertiesName[i].PropertyType.Name.Equals("Decimal"))
                        {
                            propertiesName[i].SetValue(mB, Convert.ToDecimal(paramValue[j]), null);
                        }
                        else if (propertiesName[i].PropertyType.Name.Equals("DateTime"))
                        {
                            propertiesName[i].SetValue(mB, Convert.ToDateTime(paramValue[j]), null);
                        }
                        else if (propertiesName[i].PropertyType.Name.Equals("Boolean"))
                        {
                            propertiesName[i].SetValue(mB, Convert.ToBoolean(paramValue[j]), null);
                        }
                        else if (propertiesName[i].PropertyType.Name.Equals("String"))
                        {
                            propertiesName[i].SetValue(mB, Convert.ToString(paramValue[j]), null);
                        }
                        //mo cho cac kieu du lieu khac
                    }
                }
            }
            #endregion
            return mB;
        }
        /// <summary>
        /// Ducnt 1/11/09
        /// hàm lưu history
        /// </summary>
        /// <param name="action">1:insert, 2: update, 3: delete</param>
        /// <param name="model">model của bảng thực hiện thao tác</param>
        /// <param name="tableName">tên bảng thực hiện thao tác</param>
        /// <param name="id">id của dữ liệu khi thực hiện thao tác</param>
        /// <param name="userID">id của người dùng</param>
        #region Cac ham xu li lien quan den History - Computer

        /// <summary>
        /// Phuong thuc Generate ra chuoi XML tu Model
        /// --- Nguyen Trung Kien 12/10/2009
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        //static public string GetXmlContent(BaseModel model)
        //{
        //    try
        //    {
        //        #region Lay ra TableName
        //        string tableName = model.GetType().Name;
        //        tableName = tableName.Substring(0, tableName.Length - 5);
        //        #endregion

        //        #region Lay ra File XMl
        //        string XMLWriter = "<?xml version='1.0'?>";
        //        PropertyInfo[] propertiesName = model.GetType().GetProperties();
        //        XMLWriter = XMLWriter + "<" + tableName + ">";
        //        for (int i = 0; i < propertiesName.Length; i++)
        //        {
        //            XMLWriter = XMLWriter + "<" + propertiesName[i].Name + ">";
        //            if (propertiesName[i].GetValue(model, null) != null)
        //                XMLWriter = XMLWriter + propertiesName[i].GetValue(model, null).ToString();
        //            XMLWriter = XMLWriter + "</" + propertiesName[i].Name + ">";
        //        }
        //        XMLWriter = XMLWriter + "</" + tableName + ">";
        //        return XMLWriter;
        //        #endregion
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        /// <summary>
        /// Phuong thuc do du lieu tu XML string ra model
        /// --- Nguyen Trung Kien 12/10/2009
        /// </summary>
        /// <param name="TableName">Ten bang</param>
        /// <param name="ObjectID">ID cua PK</param>
        /// <param name="SystemDate">Ngay he thong</param>
        /// <param name="BussinessDate">BussinessDate</param>
        /// <param name="UserID">User</param>
        /// <returns></returns>


        /// <summary>
        /// Hàm tr? d?a ch? IP ho?c tên máy hi?n t?i
        /// </summary>
        /// <param name="IP"></param>
        /// <returns>IP=true: Tr? l?i d?a ch? IP. IP=false: Tr? l?i tên máy</returns>
        public static string GetHostName()
        {
            return Dns.GetHostName();
        }

        /// <summary>
        /// Gán giá tr? cho Table
        /// </summary>
        /// <param name="mB">BaseModel</param>
        public static void PopupColumnNameFromModel(BaseModel mB, ref DataTable Source)
        {
            try
            {
                #region Khai bao table
                DataTable dt = new DataTable();
                #endregion

                #region Gan ten cot
                PropertyInfo[] propertiesName = mB.GetType().GetProperties();
                for (int i = 0; i < propertiesName.Length; i++)
                {
                    dt.Columns.Add(propertiesName[i].Name, propertiesName[i].PropertyType);
                }
                #endregion

                #region Tra ve Table
                Source = dt;
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Ð? d? li?u t? m?ng các model v? Table
        /// </summary>
        /// <param name="mB">M?ng các model d?u vào</param>
        /// <returns>DataTable</returns>
        public static DataTable PopupDataFromModel(BaseModel[] mB)
        {
            try
            {
                #region Khai bao bien
                DataTable Source = new DataTable();
                #endregion

                #region Gan ten cho cac cot cua Table
                PopupColumnNameFromModel(mB[0], ref Source);
                #endregion

                #region Ð? d? li?u vào DataTable

                DataRow dr;
                PropertyInfo[] propertiesName;
                for (int i = 0; i < mB.Length; i++)
                {
                    dr = Source.NewRow();
                    propertiesName = mB[i].GetType().GetProperties();
                    for (int j = 0; j < propertiesName.Length; j++)
                    {
                        dr[j] = propertiesName[j].GetValue(mB[i], null);
                    }
                    Source.Rows.Add(dr);
                }

                #endregion

                return Source;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Lay du lieu tu History
        /// </summary>
        /// <param name="TableName">Ten cua Table </param>
        /// <param name="ObjectID">ID cua Object</param>
        /// <param name="UserID">UserID cua User thuc hien hanh dong</param>
        /// <param name="UserName">UserName cua User thuc hien hanh dong</param>
        /// <returns>DataTable</returns>
        public static DataTable GetHistory(string TableName, int ObjectID, int UserID, string UserName)
        {
            //try
            //{
            //    #region Khai bao bien
            //    DataTable Source = new DataTable();
            //    DataTable Result = new DataTable();
            //    #endregion

            //    #region Lay ra DataTable

            //    string[] ParamName = new string[4];
            //    object[] ParamValue = new object[4];

            //    ParamName[0] = "@TableName"; ParamValue[0] = TableName;
            //    ParamName[1] = "@ObjectID"; ParamValue[1] = ObjectID;
            //    ParamName[2] = "@UserID"; ParamValue[2] = UserID;
            //    ParamName[3] = "@UserName"; ParamValue[3] = UserName;

            //    Source = HistoryBO.Instance.LoadDataFromSP("spSearchHistory", "Table", ParamName, ParamValue);
            //    #endregion

            //    #region Nhat ra mang cac model
            //    BaseModel[] mB = new BaseModel[Source.Rows.Count];
            //    for (int i = 0; i < Source.Rows.Count; i++)
            //    {
            //        mB[i] = GetModelFromXML(TableName, Source.Rows[i]["Content"].ToString());
            //    }
            //    #endregion

            //    #region Lay ra gia tri tra ve
            //    Result = PopupDataFromModel(mB);
            //    #endregion

            //    #region Them cot de gan cac thong tin khac
            //    Result.Columns.Add("H_UserID", typeof(System.Int32));
            //    Result.Columns.Add("H_UserName", typeof(System.String));
            //    Result.Columns.Add("H_ComputerName", typeof(System.String));
            //    Result.Columns.Add("H_Action", typeof(System.String));
            //    Result.Columns.Add("H_BusinessDate", typeof(System.DateTime));
            //    Result.Columns.Add("H_SystemDate", typeof(System.DateTime));

            //    for (int i = 0; i < Result.Rows.Count; i++)
            //    {
            //        Result.Rows[i]["H_UserID"] = Source.Rows[i]["UserID"];
            //        Result.Rows[i]["H_UserName"] = Source.Rows[i]["UserName"];
            //        Result.Rows[i]["H_ComputerName"] = Source.Rows[i]["ComputerName"];
            //        Result.Rows[i]["H_Action"] = Source.Rows[i]["Action"];
            //        Result.Rows[i]["H_BusinessDate"] = Source.Rows[i]["BusinessDate"];
            //        Result.Rows[i]["H_SystemDate"] = Source.Rows[i]["SystemDate"];
            //    }
            //    #endregion

            //    #region Return ket qua tra ve
            //    return Result;
            //    #endregion
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
            DataTable dt = new DataTable();
            return dt;
        }

        /// <summary>
        /// Insert du lieu vao History
        /// </summary>
        /// <param name="Action">Hanh dong "Insert" - "Update" - "Delete"</param>
        /// <param name="Model">Model cua doi tuong can ghi</param>
        public static void InsertHistory(string Action, BaseModel Model)
        {
            //#region Khai bao model History

            //DateTime SysDate = GetSystemDate();
            //DateTime BusinessDate = GetBusinessDate();
            //PropertyInfo[] propertiesName = Model.GetType().GetProperties();

            //HistoryModel mH = new HistoryModel();
            //mH.Action = Action;
            //mH.BusinessDate = BusinessDate;
            //mH.ComputerName = GetHostName();
            //mH.Content = TextUtils.GetXmlContent(Model);
            //mH.CreateDate = SysDate;
            //mH.ObjectID = Convert.ToInt32(propertiesName[0].GetValue(Model, null));
            //mH.SystemDate = SysDate;
            //mH.TableName = Model.GetType().Name.Substring(0, Model.GetType().Name.Length - 5);
            //mH.UpdateDate = SysDate;
            //mH.UserID = Global.UserID;
            //mH.UserName = Global.UserName;
            //mH.UserInsertID = Global.UserID;
            //mH.UserUpdateID = Global.UserID;

            //#endregion

            //#region Insert to history

            //HistoryBO.Instance.Insert(mH);

            //#endregion
        }

        /// <summary>
        /// Insert du lieu vao History
        /// </summary>
        /// <param name="Action">Hanh dong "Insert" - "Update" - "Delete"</param>
        /// <param name="Model">Model cua doi tuong can ghi</param>
        /// <param name="pt">ProcessTransaction</param>
        public static void InsertHistory(string Action, BaseModel Model, ProcessTransaction pt)
        {
            //#region Khai bao model History

            //DateTime SysDate = GetSystemDate();
            //DateTime BusinessDate = GetBusinessDate();
            //PropertyInfo[] propertiesName = Model.GetType().GetProperties();

            //HistoryModel mH = new HistoryModel();
            //mH.Action = Action;
            //mH.BusinessDate = BusinessDate;
            //mH.ComputerName = GetHostName();
            //mH.Content = TextUtils.GetXmlContent(Model);
            //mH.CreateDate = SysDate;
            //mH.ObjectID = Convert.ToInt32(propertiesName[0].GetValue(Model, null));
            //mH.SystemDate = SysDate;
            //mH.TableName = Model.GetType().Name.Substring(0, Model.GetType().Name.Length - 5);
            //mH.UpdateDate = SysDate;
            //mH.UserID = Global.UserID;
            //mH.UserName = Global.UserName;
            //mH.UserInsertID = Global.UserID;
            //mH.UserUpdateID = Global.UserID;

            //#endregion

            //#region Insert to history

            //pt.Insert(mH);

            //#endregion
        }
        static public string generateCode()
        {
            DateTime Date = TextUtilss.GetSystemDate();
            return Date.Year.ToString() + Date.Month.ToString() + Date.Day.ToString() + Date.Hour.ToString()
            + Date.Minute.ToString() + Date.Second.ToString() + Date.Millisecond.ToString();
        }

        #endregion
        static public void DailyCutOff()
        {
            //DateTime businessDate = TextUtils.GetBusinessDate();
            //string[] arrName = new string[] { "@BusinessDate" };
            //object[] arrValue = new object[] { businessDate };
            //DataTable dtBBDetail = BusinessBlockDetailBO.Instance.LoadDataFromSP("spFindRoomInventIDCutOff", "BBDetailCutOff", arrName, arrValue);
            //for (int i = 0; i < dtBBDetail.Rows.Count; i++)
            //{
            //    int BBDetailID = int.Parse(dtBBDetail.Rows[i][0].ToString());
            //    SqlConnection cnn = new SqlConnection(DBUtils.GetDBConnectionString());
            //    try
            //    {
            //        cnn.Open();
            //        SqlCommand sqlCustomerBalance = new SqlCommand("spDailyCutOff");
            //        sqlCustomerBalance.Parameters.Add("@RoomInventID", SqlDbType.Int).Value = BBDetailID;                   
            //        sqlCustomerBalance.Connection = cnn;
            //        sqlCustomerBalance.CommandType = CommandType.StoredProcedure;
            //        sqlCustomerBalance.ExecuteNonQuery();
            //    }
            //    catch
            //    { }
            //}
        }


        /// <summary>
        /// Hàm kiểm tra sự tồn tại của một trường
        ///  - Nguyễn Trung Kiên - 2/10/2009
        /// </summary>
        /// <param name="Table">Tên Table</param>
        /// <param name="Field">Tên trường cần kiểm tra</param>
        /// <param name="ValueCheck">Giá trị đầu vào</param>
        /// <returns>True , False</returns>
        static public bool CheckFieldNo(string Table, string Field, string ValueCheck)
        {
            //string[] paramName = new string[1];
            //paramName[0] = "@sqlCommand";
            //string[] paramValue = new string[1];
            //paramValue[0] = "select " + Field + " from [" + Table + "] where Convert(nvarchar," + Field + ")='" + ValueCheck + "'";
            //try
            //{
            //    if (FolioBO.Instance.LoadDataFromSP("spGenSearchWithCommand", "Table", paramName, paramValue).Rows.Count != 0)
            //        return true;
            //    else
            //        return false;
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
            return true;
        }
        public const string FomatShortDate = "dd.MM.yy";
        public const string FormatLongDate = "dd/MM/yyyy hh:mm:ss";
        public static void ExcuteSQL(string strSQL)
        {
            SqlConnection cn = new SqlConnection(DBUtils.GetDBConnectionString());
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            cmd.CommandType = CommandType.Text;
            cn.Open();
            cmd.CommandText = strSQL;
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static Color[] getStatusColor(string statusName)
        {
            Color[] arrColor = new Color[2];
            return arrColor;
            //ArrayList mS = HKPStatusColorBO.Instance.FindByAttribute("StatusName",statusName);
            //if (mS.Count <= 0)
            //{
            //    arrColor[0] = Color.White;
            //    arrColor[1] = Color.Black;
            //    return arrColor;
            //}
            //else
            //{
            //    HKPStatusColorModel modelS = (HKPStatusColorModel)mS[0];
            //    Color BGColor = modelS==null? Color.White:  Color.FromArgb(int.Parse(modelS.ColorName));
            //    Color FontColor = modelS==null? Color.Black: Color.FromArgb(int.Parse(modelS.FontColorName));
            //    arrColor[0] = BGColor;
            //    arrColor[1] = FontColor;
            //    return arrColor;//Color.FromArgb(int.Parse(modelS.ColorName));
            //}
        }

        public static string ShowSaveFileDialog(string title, string filter, string FileHeader)
        {
            string name = string.Empty;
            SaveFileDialog dlg = new SaveFileDialog();
            name = string.Format("{0}_{1}", FileHeader, DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString());
            //name = Application.ProductName;
            //int n = name.LastIndexOf(".") + 1;
            //if (n > 0) name = name.Substring(n, name.Length - n);
            dlg.Title = "Xuất ra excel... " + title;
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dlg.FileName = name;
            dlg.Filter = filter;
            if (dlg.ShowDialog() == DialogResult.OK) return dlg.FileName;
            return "";
        }

        public static void OpenFile(string fileName)
        {
            if (MessageBox.Show("Do you want to open file?", "Export to excel... ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = fileName;
                    process.StartInfo.Verb = "Open";
                    process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                    process.Start();
                }
                catch
                {
                    MessageBox.Show("File not found.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Hàm xuất excel
        /// </summary>
        /// <param name="gridName">Gridview của DevExpress</param>
        /// <param name="fileHeader">Tên file</param>
        public static void ExportExcelForDevexpress(GridView gridName, string fileHeader)
        {
            string fileName = ShowSaveFileDialog("Microsoft Excel Document", "Microsoft Excel|*.xls", fileHeader);
            if (fileName != "")
            {
                try
                {
                    gridName.ExportToXls(fileName);

                }
                catch
                {
                    gridName.ExportToExcelOld(fileName);
                }
                if (File.Exists(fileName) == false) gridName.ExportToXls(fileName); ;
                OpenFile(fileName);
            }
        }
        static public DataTable Select(string strComm)
        {
            SqlConnection cnn = new SqlConnection(DBUtils.GetDBConnectionString());
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                cnn.Open();
                cmd = new SqlCommand("spSearchAllForTrans", cnn);
                cmd.CommandTimeout = 6000;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@sqlCommand", strComm));
                //cmd.ExecuteNonQuery();

                da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch (SqlException se)
            {
                throw new Exception("Sellect error :" + se.Message);
            }
            finally
            {
                cnn.Close();
            }

        }
        /// <summary>
        /// lấy trạng thái phòng (HKStatusID) sau khi checkout
        /// </summary>
        /// <param name="roomID">Số phòng</param>
        /// <param name="businessDate">ngày BussinessDate hiện tại</param>
        /// <returns>HKStatusID(=2:Dirty, =5:OOO, =6:OOS)</returns>
        static public int getHKStatusIDAfterCheckOut(int roomID, DateTime businessDate)
        {
            try
            {
                string strDateTime = businessDate.ToString("MM/dd/yyyy");
                DataTable dt = Select("Select OOOStatus from BusinessBlock where RoomID=" + roomID.ToString() + " and datediff(day,FromDateOOO," + strDateTime + ")=0 ");
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["OOOStatus"].ToString() == "1") return 5; //OOO
                    else return 6;
                }
                else return 2;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        /// <summary>
        /// Đóng mở điện thoại
        /// Create By: DucNT
        /// Create Date: 6/12/10
        /// </summary>
        /// <param name="roomNo">phòng</param>
        /// <param name="mainGuestName">tên main guest nếu có khách trong phòng</param>
        /// <param name="isOn">True:mở điện thoại, False: đóng điện thoại</param>
        public static void insertToTelephoneSwitch(string roomNo, string mainGuestName, bool isOn)
        {
            //try
            //{
            //    TelephoneSwitchModel model = new TelephoneSwitchModel();
            //    model.RoomNo = roomNo;
            //    model.GuestName = mainGuestName;
            //    model.Status = isOn == true ? 1 : 0;
            //    model.CreateDate = GetSystemDate();
            //    TelephoneSwitchBO.Instance.Insert(model);
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.ToString());
            //}
        }
        public static DateTime ConvertStringDateTime(string strDate)
        {
            DateTime result = new DateTime();
            string[] arrStrDate = strDate.Split('/');
            string day = arrStrDate[0];
            string month = arrStrDate[1];
            string yearAndTime = arrStrDate[2];
            try
            {
                DateTime test = Convert.ToDateTime("12/13/2010");
                //chạy qua đây tức là định dạng MM/dd/yyyy
                string strResult = month + "/" + day + "/" + yearAndTime;
                result = Convert.ToDateTime(strResult);
            }
            catch
            {
                //chạy vào đây tức là định dạng dd/MM/yyyy
                string strResult = day + "/" + month + "/" + yearAndTime;
                result = Convert.ToDateTime(strResult);
            }
            return result;
        }
        /// <summary>
        /// Kiểm xem có xóa được ID này với điều kiện ID không tồn tài ở các bảng đầu vào
        ///  - Nguyễn Trung Kiên - 2/10/2009
        /// </summary>
        /// <param name="IdDelete">Giá trị ID cần xóa</param>
        /// <param name="Field">Danh sách tên các Field cần so sánh </param>
        /// <param name="Table">Danh sách tên các Table cần so sánh</param>
        /// <returns>True: nếu được xóa,False: nếu không được xóa.</returns>
        /// 

        static public bool CheckDelete(int IdDelete, string[] Field, string[] Table)
        {
            int count = 0;
            string[] paramName = new string[1];
            paramName[0] = "@sqlCommand";
            string[] paramValue = new string[1];
            try
            {
                for (int i = 0; i < Field.Length; i++)
                {
                    paramValue[0] = "select ID from " + Table[i] + " where Convert(nvarchar," + Field[i] + ")='" + IdDelete + "'";
                    if (EventsLogErrorBO.Instance.LoadDataFromSP("spGenSearchWithCommand", "Table", paramName, paramValue).Rows.Count != 0)
                    {
                        count = count + 1;
                    }
                }
                if (count != 0)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void FormatDateColumnGrid(ref CEFA.DatagridView grvData, string ColoumnName)
        {
            grvData.Columns[ColoumnName].DefaultCellStyle.Format = FomatShortDate;
        }

    }
}