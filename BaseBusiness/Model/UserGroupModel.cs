
using System;
namespace BMS.Model
{
	public class UserGroupModel : BaseModel
	{
		private int iD;
		private string name;
		private string code;
		private int leader;
		private int departmentID;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	
		public string Code
		{
			get { return code; }
			set { code = value; }
		}
	
		public int Leader
		{
			get { return leader; }
			set { leader = value; }
		}
	
		public int DepartmentID
		{
			get { return departmentID; }
			set { departmentID = value; }
		}
	
	}
}
	