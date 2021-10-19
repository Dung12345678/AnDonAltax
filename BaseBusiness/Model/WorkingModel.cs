
using System;
namespace BMS.Model
{
	public class WorkingModel : BaseModel
	{
		private int iD;
		private int workingStepID;
		private string workingName;
		private int valueType;
		private string valueTypeName;
		private string periodValue;
		private decimal minValue;
		private decimal maxValue;
		private string unit;
		private int sortOrder;
		private bool isGetAutoValue;
		private int comport;
		private bool isDeleted;
		private string createdBy;
		private DateTime? createdDate;
		private string updatedBy;
		private DateTime? updatedDate;
		private int type;
		private string ipAddress;
		private int port;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public int WorkingStepID
		{
			get { return workingStepID; }
			set { workingStepID = value; }
		}
	
		public string WorkingName
		{
			get { return workingName; }
			set { workingName = value; }
		}
	
		public int ValueType
		{
			get { return valueType; }
			set { valueType = value; }
		}
	
		public string ValueTypeName
		{
			get { return valueTypeName; }
			set { valueTypeName = value; }
		}
	
		public string PeriodValue
		{
			get { return periodValue; }
			set { periodValue = value; }
		}
	
		public decimal MinValue
		{
			get { return minValue; }
			set { minValue = value; }
		}
	
		public decimal MaxValue
		{
			get { return maxValue; }
			set { maxValue = value; }
		}
	
		public string Unit
		{
			get { return unit; }
			set { unit = value; }
		}
	
		public int SortOrder
		{
			get { return sortOrder; }
			set { sortOrder = value; }
		}
	
		public bool IsGetAutoValue
		{
			get { return isGetAutoValue; }
			set { isGetAutoValue = value; }
		}
	
		public int Comport
		{
			get { return comport; }
			set { comport = value; }
		}
	
		public bool IsDeleted
		{
			get { return isDeleted; }
			set { isDeleted = value; }
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
	
		public int Type
		{
			get { return type; }
			set { type = value; }
		}
	
		public string IpAddress
		{
			get { return ipAddress; }
			set { ipAddress = value; }
		}
	
		public int Port
		{
			get { return port; }
			set { port = value; }
		}
	
	}
}
	