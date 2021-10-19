using System;

namespace BMS.Utils
{
	/// <summary>
	/// Summary description for Expression.
	/// </summary>
	public class Expression
	{
		public Expression()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		private Object exp1;
		private Object exp2;
		private String op;

		public Expression(Object exp1, Object exp2) : this(exp1, exp2, "=")
		{
		}

		public Expression(string exp1, string exp2, string Operator) : this((Object) exp1, (Object) exp2, Operator)
		{
		}

		public Expression(string exp1, int exp2, string Operator) : this((Object) exp1, (Object) exp2, Operator)
		{
		}

		public Expression(Object exp1, Object exp2, String op)
		{
			if (exp1 is string)
			{
				this.exp1 = "$" + (string) exp1;
			}
			else
			{
				this.exp1 = exp1;
			}
			if (op.Equals("IN"))
			{
				this.exp2 = "(" + exp2 + ")";
			}
            if (op.ToUpper()=="LIKE")
            {
                this.exp2 = "%" + exp2 + "%";
            }
			else
			{
				this.exp2 = exp2;
			}

			this.op = op;
		}


		public Expression And(Expression exp2)
		{
			return new Expression(this, exp2, "AND");
		}

		public Expression Or(Expression exp2)
		{
			return new Expression(this, exp2, "OR");
		}

		public override string ToString()
		{
			return ToString(exp1) + " " + op + " " + ToString(exp2);
		}

		private String ToString(Object exp)
		{
			if (exp == null) return " ";
			if (exp is string)
			{
				string tmp = exp.ToString();
				tmp = tmp;
				if (tmp.StartsWith("$")) return tmp.Substring(1);
				if (tmp.StartsWith("(")) return tmp;
				else return "N'" + exp.ToString().Replace("'", "''") + "'";
			}
			else if (exp is Expression)
			{
				return "(" + exp.ToString() + ")";
			}
			return exp.ToString();
		}
	}
}