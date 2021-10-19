
using System;
namespace BMS.Model
{
	public class CompanyModel : BaseModel
	{
		private int iD;
		private string companyCode;
		private string companyName;
		private bool active;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string CompanyCode
		{
			get { return companyCode; }
			set { companyCode = value; }
		}
	
		public string CompanyName
		{
			get { return companyName; }
			set { companyName = value; }
		}
	
		public bool Active
		{
			get { return active; }
			set { active = value; }
		}
	
	}
}
	