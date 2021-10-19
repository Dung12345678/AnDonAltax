
using System;
namespace BMS.Model
{
	public class SettingRatioRoundModel : BaseModel
	{
		private int iD;
		private string ratioCode;
		private decimal frequencyNumber;
		private string roundValue;
		private string createdBy;
		private DateTime? createdDate;
		private string updatedBy;
		private DateTime? updatedDate;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string RatioCode
		{
			get { return ratioCode; }
			set { ratioCode = value; }
		}
	
		public decimal FrequencyNumber
		{
			get { return frequencyNumber; }
			set { frequencyNumber = value; }
		}
	
		public string RoundValue
		{
			get { return roundValue; }
			set { roundValue = value; }
		}
	
		public string CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}
	
		public DateTime? CreatedDate
		{
			get { return createdDate; }
			set { createdDate = value; }
		}
	
		public string UpdatedBy
		{
			get { return updatedBy; }
			set { updatedBy = value; }
		}
	
		public DateTime? UpdatedDate
		{
			get { return updatedDate; }
			set { updatedDate = value; }
		}
	
	}
}
	