
using System;
namespace BMS.Model
{
	public partial class ShiftModel : BaseModel
	{
		public int ID {get; set;}
		
		public string Code {get; set;}
		
		public string Name {get; set;}
		
		public DateTime? StartTime {get; set;}
		
		public DateTime? EndTime {get; set;}
		
		public DateTime? TotalTime {get; set;}
		
		public DateTime? StartTimeBreak1 {get; set;}
		
		public DateTime? StartTimeBreak2 {get; set;}
		
		public DateTime? StartTimeBreak3 {get; set;}
		
		public DateTime? StartTimeBreak4 {get; set;}
		
		public DateTime? EndTimeBreak1 {get; set;}
		
		public DateTime? EndTimeBreak2 {get; set;}
		
		public DateTime? EndTimeBreak3 {get; set;}
		
		public DateTime? EndTimeBreak4 {get; set;}
		
	}
}
	