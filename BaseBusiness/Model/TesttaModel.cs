
using System;
namespace BMS.Model
{
	public class TesttaModel : BaseModel
	{
		private long iD;
		private string orderCode;
		private int number;
		private decimal clockDial11;
		private decimal clockDial12;
		private decimal vibrationForward1;
		private decimal vibrationReverse1;
		private decimal checkEye11;
		private decimal checkEye12;
		private string result1;
		private decimal vibrate11;
		private decimal vibrate12;
		private decimal vibrate13;
		private decimal clockDial21;
		private decimal clockDial22;
		private decimal vibrationForward2;
		private decimal vibrationReverse2;
		private decimal checkEye21;
		private decimal checkEye22;
		private string result2;
		private decimal vibrate21;
		private decimal vibrate22;
		private decimal vibrate23;
		private DateTime? dateWork;
		private string workerName;
		private string measureName;
		private string leader;
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string OrderCode
		{
			get { return orderCode; }
			set { orderCode = value; }
		}
	
		public int Number
		{
			get { return number; }
			set { number = value; }
		}
	
		public decimal ClockDial11
		{
			get { return clockDial11; }
			set { clockDial11 = value; }
		}
	
		public decimal ClockDial12
		{
			get { return clockDial12; }
			set { clockDial12 = value; }
		}
	
		public decimal VibrationForward1
		{
			get { return vibrationForward1; }
			set { vibrationForward1 = value; }
		}
	
		public decimal VibrationReverse1
		{
			get { return vibrationReverse1; }
			set { vibrationReverse1 = value; }
		}
	
		public string CheckEye11 { get; set; }
	
		public string CheckEye12 { get; set; }

        public string Result1
		{
			get { return result1; }
			set { result1 = value; }
		}
	
		public decimal Vibrate11
		{
			get { return vibrate11; }
			set { vibrate11 = value; }
		}
	
		public decimal Vibrate12
		{
			get { return vibrate12; }
			set { vibrate12 = value; }
		}
	
		public decimal Vibrate13
		{
			get { return vibrate13; }
			set { vibrate13 = value; }
		}
	
		public decimal ClockDial21
		{
			get { return clockDial21; }
			set { clockDial21 = value; }
		}
	
		public decimal ClockDial22
		{
			get { return clockDial22; }
			set { clockDial22 = value; }
		}
	
		public decimal VibrationForward2
		{
			get { return vibrationForward2; }
			set { vibrationForward2 = value; }
		}
	
		public decimal VibrationReverse2
		{
			get { return vibrationReverse2; }
			set { vibrationReverse2 = value; }
		}
	
		public string CheckEye21 { get; set; }

        public string CheckEye22 { get; set; }

        public string Result2
		{
			get { return result2; }
			set { result2 = value; }
		}
	
		public decimal Vibrate21
		{
			get { return vibrate21; }
			set { vibrate21 = value; }
		}
	
		public decimal Vibrate22
		{
			get { return vibrate22; }
			set { vibrate22 = value; }
		}
	
		public decimal Vibrate23
		{
			get { return vibrate23; }
			set { vibrate23 = value; }
		}
	
		public DateTime? DateWork
		{
			get { return dateWork; }
			set { dateWork = value; }
		}
	
		public string WorkerName
		{
			get { return workerName; }
			set { workerName = value; }
		}
	
		public string MeasureName
		{
			get { return measureName; }
			set { measureName = value; }
		}
	
		public string Leader
		{
			get { return leader; }
			set { leader = value; }
		}
	
	}
}
	