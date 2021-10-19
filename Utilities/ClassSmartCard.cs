using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CEFA.Utils;

namespace CEFA
{
    public class ClassSmartCard
    {
        public static string GetSplitString(string Name)
        {
            string paraName;
            string[] arrConfirmationNo = null;
            paraName = "";
            if (Name != "")
            {
                arrConfirmationNo = Name.Split(',');
                if (arrConfirmationNo.Length > 0)
                {
                    for (int i = 0; i < arrConfirmationNo.Length; i++)
                    {
                        if (i != 0)
                            paraName = paraName + "'" + "," + "'" + arrConfirmationNo[i].ToString().Trim();
                        else
                            paraName = arrConfirmationNo[i].ToString().Trim();
                    }
                }
            }
            return paraName;
        }
        public static string GetSplitString(string Name, bool a)
        {
            string paraName;
            string[] arrConfirmationNo = null;
            paraName = "";
            if (Name != "")
            {
                arrConfirmationNo = Name.Split(',');
                if (arrConfirmationNo.Length > 0)
                {
                    for (int i = 0; i < arrConfirmationNo.Length; i++)
                    {
                        if (i != 0)
                            paraName = paraName + "," + "'" + arrConfirmationNo[i].ToString().Trim() + "'";
                        else
                            paraName = "'" + arrConfirmationNo[i].ToString().Trim() + "'";
                    }
                }
            }
            return paraName;
        }

        /// <summary>
        /// Lấy ra dịch vụ được trừ vào tiền thưởng
        /// </summary>
        /// <returns></returns>
        public static string GetBonusService()
        {
            DataTable dt = TextUtils.Select("SELECT KeyValue FROM dbo.SystemInfo WITH (NOLOCK) WHERE KeyName = 'BONUS_SERVICE'");
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["KeyValue"].ToString();
            else
                return "";
        }
        /// <summary>
        /// Lấy ra thông tin tk thưởng
        /// </summary>
        /// <returns></returns>
        public static string GetBonusAccount()
        {
            DataTable dt = TextUtils.Select("SELECT KeyValue FROM dbo.SystemInfo WITH (NOLOCK) WHERE KeyName = 'BONUS_ACCOUNT'");
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["KeyValue"].ToString();
            else
                return "";
        }
        /// <summary>
        /// True - Đã phát sinh giao dịch dịch vụ trừ tiền thưởng
        /// false - Chưa phát sinh
        /// </summary>
        /// <param name="_CardID"></param>
        /// <returns></returns>
        public static bool CheckUsingBonus(string _CardID, string _BonusService)
        {
            bool _IsOK = false;
            if (_BonusService != "")
            {
                //19521807
                DataTable dt = TextUtils.Select("SELECT a.ID FROM dbo.AccountUsingDetail a WITH (NOLOCK), dbo.Service b WITH (NOLOCK), dbo.ServiceType c WITH (NOLOCK) " +
                                                "WHERE a.ServiceID = b.ID AND b.ServiceTypeID = c.ID AND c.ID IN (" + _BonusService + ") AND CardID ='" + _CardID + "'");
                if (dt.Rows.Count > 0)
                    _IsOK = true;
            }
            return _IsOK;
        }
        /// <summary>
        /// 0 - Tổng tiền trong tk thẻ; 
        /// 1 - Tổng tiền không bao gồm tk thưởng
        /// 2 - Tổng tiền của tk thưởng
        /// </summary>
        /// <param name="_CardNumber"></param>
        /// <param name="_IsBonus"></param>
        /// <returns></returns>
        public static Decimal[] GetAmountByCard(string _CardNumber, string _BonusAccount, DateTime _SysDate, int _day)
        {
            decimal[] _amount = new decimal[3]; _amount[0] = _amount[1] = _amount[2] = 0;
            DataTable dt = TextUtils.Select("SELECT a.CardID, SUM(CASE WHEN (a.Status IN (0,1)) THEN b.TotalMoney ELSE 0 END) AS TotalAmount, " +
                                            "SUM(CASE WHEN (a.Status IN (0,1) AND b.AccountTypeID NOT IN (" + _BonusAccount + ")) THEN b.TotalMoney  ELSE 0 END) AS Amount, " +
                                            "SUM(CASE WHEN (a.Status IN (0,1) AND b.AccountTypeID IN (" + _BonusAccount + ")) THEN b.TotalMoney  ELSE 0 END) AS Bonus " +
                                            "FROM dbo.Account a WITH (NOLOCK), dbo.AccountDetail b WITH (NOLOCK) " +
                                            "WHERE a.ID = b.AccountID AND a.CardID ='" + _CardNumber + "' AND a.Status IN (0,1) " +
                                            "AND DATEDIFF(DAY, a.IssuedDate,'" + _SysDate.ToString("yyyy/MM/dd") + "') >= 0 AND DATEDIFF(DAY, (a.ExpirationDate+ " + _day + "),'" + _SysDate.ToString("yyyy/MM/dd") + "') <= 0 " +
                                            "GROUP BY a.CardID ");
            if (dt.Rows.Count > 0)
            {
                _amount[0] = TextUtils.ToDecimal(dt.Rows[0]["TotalAmount"].ToString());
                _amount[1] = TextUtils.ToDecimal(dt.Rows[0]["Amount"].ToString());
                _amount[2] = TextUtils.ToDecimal(dt.Rows[0]["Bonus"].ToString());
            }
            //Return value
            return _amount;
        }
        /// <summary>
        /// Lấy Account đang Activie tại thời điểm hiện tại
        /// </summary>
        /// <param name="_CardNumber"></param>
        /// <param name="_SysDate"></param>
        /// <returns></returns>
        public static int GetAccountByCardID(string _CardNumber, DateTime _SysDate, ref int _day)
        {
            int _accID = 0; _day = 0;
            DataTable dt = TextUtils.Select("SELECT a.ID FROM dbo.Account a WITH (NOLOCK) WHERE a.CardID = '" + _CardNumber + "' AND a.Status = 1 " +
                                            "AND DATEDIFF(DAY, a.IssuedDate,'" + _SysDate.ToString("yyyy/MM/dd") + "') >= 0 AND DATEDIFF(DAY, a.ExpirationDate,'" + _SysDate.ToString("yyyy/MM/dd") + "') <= 0");
            if (dt.Rows.Count > 0)
                _accID = TextUtils.ToInt(dt.Rows[0]["ID"].ToString());
            else
            {
                //Get Acount chưa active                
                DataTable dtCT = TextUtils.Select("SELECT a.ID, b.NumberOfExpirationDay FROM dbo.Account a WITH (NOLOCK), dbo.CardType b WITH (NOLOCK) WHERE a.CardTypeID =b.ID AND a.Status = 0 AND a.CardID = '" + _CardNumber + "' ORDER BY a.IssuedDate");
                if (dtCT.Rows.Count > 0)
                {
                    _accID = TextUtils.ToInt(dtCT.Rows[0]["ID"].ToString());
                    _day = TextUtils.ToInt(dtCT.Rows[0]["NumberOfExpirationDay"].ToString());
                }
            }
            return _accID;
        }
        /// <summary>
        /// Lấy Account của tài khoản Bonus
        /// </summary>
        /// <param name="_AccountID"></param>
        /// <param name="_BonusAccount"></param>
        /// <param name="pt"></param>
        /// <returns></returns>
        public static int GetAccountBonusID(int _AccountID, string _BonusAccount, ProcessTransaction pt)
        {
            DataTable dt = null;
            int _id = 0;
            if (pt != null)
                dt = pt.Select("SELECT ID FROM dbo.AccountDetail WITH (NOLOCK) WHERE AccountID =" + _AccountID + " AND AccountTypeID IN (" + _BonusAccount + ")");
            else
                dt = TextUtils.Select("SELECT ID FROM dbo.AccountDetail WITH (NOLOCK) WHERE AccountID =" + _AccountID + " AND AccountTypeID IN (" + _BonusAccount + ")");

            if (dt.Rows.Count > 0)
                _id = TextUtils.ToInt(dt.Rows[0]["ID"].ToString());

            return _id;
        }
        public static int GetAccountServiceID(int _AccountID, string _BonusAccount, ProcessTransaction pt)
        {
            DataTable dt = null;
            int _id = 0;
            if (pt != null)
                dt = pt.Select("SELECT ID FROM dbo.AccountDetail WITH (NOLOCK) WHERE AccountID =" + _AccountID + " AND AccountTypeID NOT IN (" + _BonusAccount + ")");
            else
                dt = TextUtils.Select("SELECT ID FROM dbo.AccountDetail WITH (NOLOCK) WHERE AccountID =" + _AccountID + " AND AccountTypeID NOT IN (" + _BonusAccount + ")");

            if (dt.Rows.Count > 0)
                _id = TextUtils.ToInt(dt.Rows[0]["ID"].ToString());

            return _id;
        }
    }
}
