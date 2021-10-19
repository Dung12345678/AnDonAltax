
using System;
namespace BMS.Model
{
	public class ProductGroupModel : BaseModel
	{
		private int iD;
		private string productGroupCode;
		private string productGroupName;
		private string sizeBB;
		private string createdBy;
		private DateTime? createdDate;
		private string updatedBy;
		private DateTime? updatedDate;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string ProductGroupCode
		{
			get { return productGroupCode; }
			set { productGroupCode = value; }
		}
	
		public string ProductGroupName
		{
			get { return productGroupName; }
			set { productGroupName = value; }
		}
	
		public string SizeBB
		{
			get { return sizeBB; }
			set { sizeBB = value; }
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
	