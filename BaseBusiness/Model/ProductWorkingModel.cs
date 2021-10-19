
using System;
namespace BMS.Model
{
	public class ProductWorkingModel : BaseModel
	{
		private int iD;
		private int productID;
		private int productStepID;
		private int workingID;
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
		private int port;
		private string ipAddress;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public int ProductID
		{
			get { return productID; }
			set { productID = value; }
		}
	
		public int ProductStepID
		{
			get { return productStepID; }
			set { productStepID = value; }
		}
	
		public int WorkingID
		{
			get { return workingID; }
			set { workingID = value; }
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
	
		public int Port
		{
			get { return port; }
			set { port = value; }
		}
	
		public string IpAddress
		{
			get { return ipAddress; }
			set { ipAddress = value; }
		}
	
	}
}
	