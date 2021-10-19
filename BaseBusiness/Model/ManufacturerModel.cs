
using System;
namespace BMS.Model
{
	public class ManufacturerModel : BaseModel
	{
		private int iD;
		private string manufacturerCode;
		private string manufacturerName;
		private string note;
		private string createdBy;
		private DateTime? createdDate;
		private string updatedBy;
		private DateTime? updatedDate;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string ManufacturerCode
		{
			get { return manufacturerCode; }
			set { manufacturerCode = value; }
		}
	
		public string ManufacturerName
		{
			get { return manufacturerName; }
			set { manufacturerName = value; }
		}
	
		public string Note
		{
			get { return note; }
			set { note = value; }
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
	