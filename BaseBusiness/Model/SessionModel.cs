
using System;
namespace BMS.Model
{
	public class SessionModel : BaseModel
	{
	
		public int ID { get; set; }
	
		public int UserID { get; set; }
	
		public string ComputerName { get; set; }
	
		public DateTime StartTime { get; set; }
	
		public DateTime EndTime { get; set; }
	
		public int Status { get; set; }
	
	}
}
	