
using System;
namespace BMS.Model
{
	public class ProductTypeModel : BaseModel
	{
		private int iD;
		private string productTypeCode;
		private string productTypeName;
		private string createdBy;
		private DateTime? createdDate;
		private string updatedBy;
		private DateTime? updatedDate;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string ProductTypeCode
		{
			get { return productTypeCode; }
			set { productTypeCode = value; }
		}
	
		public string ProductTypeName
		{
			get { return productTypeName; }
			set { productTypeName = value; }
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
	