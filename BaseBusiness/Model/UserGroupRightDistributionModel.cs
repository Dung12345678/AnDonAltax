
using System;
namespace BMS.Model
{
	public class UserGroupRightDistributionModel : BaseModel
	{
		private int iD;
		private int formAndFunctionID;
		private int userGroupID;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public int FormAndFunctionID
		{
			get { return formAndFunctionID; }
			set { formAndFunctionID = value; }
		}
	
		public int UserGroupID
		{
			get { return userGroupID; }
			set { userGroupID = value; }
		}
	
	}
}
	