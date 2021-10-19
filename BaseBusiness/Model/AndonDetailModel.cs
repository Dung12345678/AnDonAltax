
using System;
namespace BMS.Model
{
	public partial class AndonDetailModel : BaseModel
	{
		public int ID {get; set;}
		
		public int AnDonID {get; set;}
		
		public int ShiftConfigID {get; set;}
		
		public int ShiftID {get; set;}
		
		public DateTime? ShiftStartTime {get; set;}
		
		public DateTime? ShiftEndTime {get; set;}
		
		public int ProductID {get; set;}
		
		public string ProductCode {get; set;}
		
		public string OrderCode {get; set;}
		
		public string QrCode {get; set;}
		
		public int ProductStepID {get; set;}
		
		public string ProductStepCode {get; set;}
		
		public int Type {get; set;}
		
		public int Takt {get; set;}
		
		public int MakeTime {get; set;}
		
		public int PeriodTime {get; set;}
		
		public DateTime? StartTime {get; set;}
		
		public DateTime? EndTime {get; set;}
		
		public bool FinishCD {get; set;}
		
		public int RiskID {get; set;}
		
		public string WorkerCode {get; set;}
		
		public int OkStatus {get; set;}
		
		public string RiskDescription {get; set;}
		
	}
}
	