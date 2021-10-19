using System;

namespace BMS.Utils
{
	/// <summary>
	/// Summary description for BetweenExpression.
	/// </summary>
	public class BetweenExpression : Expression
	{
		private string tmp;
		private object from;

		public object From
		{
			get { return from; }
		}

		public object To
		{
			get { return to; }
		}

		private object to;

		public BetweenExpression(string field, DateTime from, DateTime to)
		{
			this.from = from;
			this.to = to;
			setField(field);
		}

		public BetweenExpression(DateTime from, DateTime to) : this("FromDateTime", from, to)
		{
		}

		public void setField(string name)
		{
			/*if(from is DateTime)
                this.tmp ="('" + TextUtils.ToString1((DateTime)from) + "' <=" + name + " AND " + name + "< '" + TextUtils.ToString1((DateTime)to) + "')";
			else
				this.tmp ="('" + from + "' <=" + name + " AND " + name + "< '" + to + "')";
				this.tmp ="(@FromDate <=" + name + " AND " + name + "< @ToDate)";
			*/
			this.tmp = "('" + From + "' <=" + name + " AND " + name + "< '" + To + "')";

		}

		public override string ToString()
		{
			return tmp;
		}

		public string ToString(string field)
		{
			setField(field);
			return tmp;
		}

//		public string setParameter1(string field, SqlCommand cmd)
//		{
//			setField(field);
//			setParameter(cmd);
//			return tmp;
//		}
//
//		public void setParameter1(SqlCommand cmd)
//		{
//			cmd.Parameters.Add("@FromDate",SqlDbType.DateTime).Value = from;
//			cmd.Parameters.Add("@ToDate",SqlDbType.DateTime).Value = to;
//		}
	}
}