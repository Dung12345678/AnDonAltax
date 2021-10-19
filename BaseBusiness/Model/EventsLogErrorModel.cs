
using System;
namespace BMS.Model
{
	public class EventsLogErrorModel : BaseModel
	{
		private int iD;
		private string messageCode;
		private string computerName;
		private DateTime errorDate;
		private string formName;
		private string eventName;
		private string errorContent;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string MessageCode
		{
			get { return messageCode; }
			set { messageCode = value; }
		}
	
		public string ComputerName
		{
			get { return computerName; }
			set { computerName = value; }
		}
	
		public DateTime ErrorDate
		{
			get { return errorDate; }
			set { errorDate = value; }
		}
	
		public string FormName
		{
			get { return formName; }
			set { formName = value; }
		}
	
		public string EventName
		{
			get { return eventName; }
			set { eventName = value; }
		}
	
		public string ErrorContent
		{
			get { return errorContent; }
			set { errorContent = value; }
		}
	
	}
}
	