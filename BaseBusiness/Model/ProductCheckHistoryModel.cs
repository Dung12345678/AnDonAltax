
using System;
namespace BMS.Model
{
	public class ProductCheckHistoryModel : BaseModel
	{
		private long iD;
		private int productID;
		private int approvedID;
		private int monitorID;
		private DateTime? dateLR;
		private string qRCode;
		private string editContent;
		private DateTime? editDate;
		private string createdBy;
		private DateTime? createdDate;
		private string updatedBy;
		private DateTime? updatedDate;
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public int ProductID
		{
			get { return productID; }
			set { productID = value; }
		}
	
		public int ApprovedID
		{
			get { return approvedID; }
			set { approvedID = value; }
		}
	
		public int MonitorID
		{
			get { return monitorID; }
			set { monitorID = value; }
		}
	
		public DateTime? DateLR
		{
			get { return dateLR; }
			set { dateLR = value; }
		}
	
		public string QRCode
		{
			get { return qRCode; }
			set { qRCode = value; }
		}
	
		public string EditContent
		{
			get { return editContent; }
			set { editContent = value; }
		}
	
		public DateTime? EditDate
		{
			get { return editDate; }
			set { editDate = value; }
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
	