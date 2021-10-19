
using System;
namespace BMS.Model
{
	public class CustomerModel : BaseModel
	{
		private int iD;
		private string customerName;
		private string customerCode;
		private string address;
		private string phone;
		private string email;
		private string note;
		private int statusDisable;
		private string website;
		private string contactName;
		private string contactPhone;
		private string contactEmail;
		private string createdBy;
		private DateTime? createdDate;
		private string updatedBy;
		private DateTime? updatedDate;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string CustomerName
		{
			get { return customerName; }
			set { customerName = value; }
		}
	
		public string CustomerCode
		{
			get { return customerCode; }
			set { customerCode = value; }
		}
	
		public string Address
		{
			get { return address; }
			set { address = value; }
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
	
		public string Note
		{
			get { return note; }
			set { note = value; }
		}
	
		public int StatusDisable
		{
			get { return statusDisable; }
			set { statusDisable = value; }
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
	