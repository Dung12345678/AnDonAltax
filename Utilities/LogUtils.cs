using System;
using System.Collections.Generic;
using System.Text;
using BMS.Utils;
using System.Data;
using System.Net;

namespace BMS
{
    public static class LogUtils
    {
        static public void LoadFullSysInformation()
        {           
            // Load Exchange rate.
            Load_System_ExchangeRate();
            // Load Shift
            Load_Shift();
        }       

        static public void Load_System_ExchangeRate()
        {
            Global.ExchangeRate = 21000;            
        }

        public static void Load_Shift()
        {
            try
            {
                if (Global.SessionID != 0)
                {
                    DataTable dtCheck = TextUtils.Select("Select Status from Session where ID=" + Global.SessionID);
                    if ((dtCheck.Rows.Count > 0) && (Convert.ToBoolean(dtCheck.Rows[0][0]) == false))
                    {
                        Global.SessionID = 0;
                        Global.CashierNo = "";
                    }
                }
            }
            catch
            {
                return;
            }
        }

        static public string GetIpFromHostName(string _HostName)
        {
            try
            {
                string myIP = "";
                IPHostEntry ipList = System.Net.Dns.GetHostByName(_HostName);
                foreach (IPAddress ip in ipList.AddressList)
                {
                    myIP = ip.ToString();
                }
                return myIP;
            }
            catch { return ""; }
        }
    }
}
