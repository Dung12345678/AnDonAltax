
using System;
namespace BMS.Model
{
	public class SupplierModel : BaseModel
	{
		private int iD;
		private string supplierName;
		private string supplierCode;
		private string phone;
		private string email;
		private string website;
		private string contactName;
		private string contactPhone;
		private string contactEmail;
		private string note;
		private string mST;
		private string bankName;
		private string bankAcount;
		private string bankAcountName;
		private string office;
		private string address;
		private string createdBy;
		private DateTime? createdDate;
		private string updatedBy;
		private DateTime? updatedDate;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string SupplierName
		{
			get { return supplierName; }
			set { supplierName = value; }
		}
	
		public string SupplierCode
		{
			get { return supplierCode; }
			set { supplierCode = value; }
		}
	
		public string Phone
		{
			get { return phone; }
			set { phone = value; }
		}
	
		public string Email
		{
			get { return email; }
			set { email = value; }
		}
	
		public string Website
		{
			get { return website; }
			set { website = value; }
		}
	
		public string ContactName
		{
			get { return contactName; }
			set { contactName = value; }
		}
	
		public string ContactPhone
		{
			get { return contactPhone; }
			set { contactPhone = value; }
		}
	
		public string ContactEmail
		{
			get { return contactEmail; }
			set { contactEmail = value; }
		}
	
		public string Note
		{
			get { return note; }
			set { note = value; }
		}
	
		public string MST
		{
			get { return mST; }
			set { mST = value; }
		}
	
		public string BankName
		{
			get { return bankName; }
			set { bankName = value; }
		}
	
		public string BankAcount
		{
			get { return bankAcount; }
			set { bankAcount = value; }
		}
	
		public string BankAcountName
		{
			get { return bankAcountName; }
			set { bankAcountName = value; }
		}
	
		public string Office
		{
			get { return office; }
			set { office = value; }
		}
	
		public string Address
		{
			get { return address; }
			set { address = value; }
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
	