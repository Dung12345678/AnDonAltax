using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace BMS
{
	public class ThreadCD
	{
		public ThreadCD()
		{

		}

		public void CD1()
		{
			string sql = string.Format("SELECT * FROM dbo.Altax WHERE Ca = '{0}' and MaCD = '{1}' and CreateAt = '{2}'", 1, 1, Convert.ToDateTime("2007/05/08"));
			DataTable dt = TextUtils.Select(sql);
			
		}		
	}
}
