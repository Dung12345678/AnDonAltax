
using System;
namespace BMS.Model
{
	public class DepartmentModel : BaseModel
	{
		private int iD;
		private string code;
		private string name;
		private string description;
		private string createdBy;
		private DateTime? createdDate;
		private string updatedBy;
		private DateTime? updatedDate;
		private int status;
		private string email;
		private int headofDepartment;
		private bool isShowHotline;
		private string pId;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string Code
		{
			get { return code; }
			set { code = value; }
		}
	
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	
		public string Description
		{
			get { return description; }
			set { description = value; }
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
	
		public int Status
		{
			get { return status; }
			set { status = value; }
		}
	
		public string Email
		{
			get { return email; }
			set { email = value; }
		}
	
		public int HeadofDepartment
		{
			get { return headofDepartment; }
			set { headofDepartment = value; }
		}
	
		public bool IsShowHotline
		{
			get { return isShowHotline; }
			set { isShowHotline = value; }
		}
	
		public string PId
		{
			get { return pId; }
			set { pId = value; }
		}
	
	}
}
	