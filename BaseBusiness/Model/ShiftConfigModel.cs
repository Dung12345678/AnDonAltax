
using System;
namespace BMS.Model
{
	public partial class ShiftConfigModel : BaseModel
	{
		public int ID {get; set;}
		
		public int ShiftID {get; set;}
		
		public DateTime? WorkingDate {get; set;}
		
	}
}
	