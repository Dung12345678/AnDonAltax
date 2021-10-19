
using System;
namespace BMS.Model
{
	public class UserGroupLinkModel : BaseModel
	{
		private int iD;
		private int userGroupID;
		private int userID;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public int UserGroupID
		{
			get { return userGroupID; }
			set { userGroupID = value; }
		}
	
		public int UserID
		{
			get { return userID; }
			set { userID = value; }
		}
	
	}
}
	