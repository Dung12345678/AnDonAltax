
using System;
namespace BMS.Model
{
	public class UserRightDistributionModel : BaseModel
	{
		private int iD;
		private int formAndFunctionID;
		private int userID;
		private bool viewRight;
		private bool createRight;
		private bool modifyRight;
		private bool deleteRight;
		private bool specialRight;
		private int userInsertID;
		private DateTime? createDate;
		private int userUpdateID;
		private DateTime? updateDate;
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
	
		public int UserID
		{
			get { return userID; }
			set { userID = value; }
		}
	
		public bool ViewRight
		{
			get { return viewRight; }
			set { viewRight = value; }
		}
	
		public bool CreateRight
		{
			get { return createRight; }
			set { createRight = value; }
		}
	
		public bool ModifyRight
		{
			get { return modifyRight; }
			set { modifyRight = value; }
		}
	
		public bool DeleteRight
		{
			get { return deleteRight; }
			set { deleteRight = value; }
		}
	
		public bool SpecialRight
		{
			get { return specialRight; }
			set { specialRight = value; }
		}
	
		public int UserInsertID
		{
			get { return userInsertID; }
			set { userInsertID = value; }
		}
	
		public DateTime? CreateDate
		{
			get { return createDate; }
			set { createDate = value; }
		}
	
		public int UserUpdateID
		{
			get { return userUpdateID; }
			set { userUpdateID = value; }
		}
	
		public DateTime? UpdateDate
		{
			get { return updateDate; }
			set { updateDate = value; }
		}
	
	}
}
	