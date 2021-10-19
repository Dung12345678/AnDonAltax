
using System;
namespace BMS.Model
{
	public class PlanModel : BaseModel
	{
		private int iD;
		private string orderCode;
		private string gearCode;
		private int qty;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string OrderCode
		{
			get { return orderCode; }
			set { orderCode = value; }
		}
	
		public string GearCode
		{
			get { return gearCode; }
			set { gearCode = value; }
		}
	
		public int Qty
		{
			get { return qty; }
			set { qty = value; }
		}
	
	}
}
	