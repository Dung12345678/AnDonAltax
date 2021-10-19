
using System;
namespace BMS.Model
{
	public class ProductCheckHistoryDetailModel : BaseModel
	{
		private long iD;
		private int productStepID;
		private int productWorkingID;
		private int workerID;
		private string workerCode;
		private string standardValue;
		private string realValue;
		private int valueType;
		private string editValue1;
		private string editValue2;
		private int statusResult;
		private bool isConnected;
		private int comport;
		private int productID;
		private string qRCode;
		private string orderCode;
		private string packageNumber;
		private string qtyInPackage;
		private string approved;
		private string monitor;
		private DateTime? dateLR;
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
	
		public int ProductStepID
		{
			get { return productStepID; }
			set { productStepID = value; }
		}
	
		public int ProductWorkingID
		{
			get { return productWorkingID; }
			set { productWorkingID = value; }
		}
	
		public int WorkerID
		{
			get { return workerID; }
			set { workerID = value; }
		}
	
		public string WorkerCode
		{
			get { return workerCode; }
			set { workerCode = value; }
		}
	
		public string StandardValue
		{
			get { return standardValue; }
			set { standardValue = value; }
		}
	
		public string RealValue
		{
			get { return realValue; }
			set { realValue = value; }
		}
	
		public int ValueType
		{
			get { return valueType; }
			set { valueType = value; }
		}
	
		public string EditValue1
		{
			get { return editValue1; }
			set { editValue1 = value; }
		}
	
		public string EditValue2
		{
			get { return editValue2; }
			set { editValue2 = value; }
		}
	
		public int StatusResult
		{
			get { return statusResult; }
			set { statusResult = value; }
		}
	
		public bool IsConnected
		{
			get { return isConnected; }
			set { isConnected = value; }
		}
	
		public int Comport
		{
			get { return comport; }
			set { comport = value; }
		}
	
		public int ProductID
		{
			get { return productID; }
			set { productID = value; }
		}
	
		public string QRCode
		{
			get { return qRCode; }
			set { qRCode = value; }
		}
	
		public string OrderCode
		{
			get { return orderCode; }
			set { orderCode = value; }
		}
	
		public string PackageNumber
		{
			get { return packageNumber; }
			set { packageNumber = value; }
		}
	
		public string QtyInPackage
		{
			get { return qtyInPackage; }
			set { qtyInPackage = value; }
		}
	
		public string Approved
		{
			get { return approved; }
			set { approved = value; }
		}
	
		public string Monitor
		{
			get { return monitor; }
			set { monitor = value; }
		}
	
		public DateTime? DateLR
		{
			get { return dateLR; }
			set { dateLR = value; }
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

        public string ProductOrder { get; set; }
    }
}
	