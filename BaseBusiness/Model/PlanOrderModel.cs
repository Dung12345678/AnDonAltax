
using System;
namespace BMS.Model
{
	public partial class PlanOrderModel : BaseModel
	{
		public int ID {get; set;}
		
		public string OrderCode {get; set;}
		
		public string GearCode {get; set;}
		
		public int Qty {get; set;}
		
		public string CreatedBy {get; set;}
		
		public DateTime? CreatedDate {get; set;}
		
		public string UpdatedBy {get; set;}
		
		public DateTime? UpdatedDate {get; set;}
		
	}
}
	