
using System;
using BMS.BO;
namespace BMS.Model
{
	public class ActivityLogModel : BaseModel
	{
		private int iD;
		private string tableName;
		private int objectID;
		private int userID;
		private string userName;
        private DateTime changeDate;
		private string change;
		private string oldValue;
		private string newValue;
		private string description;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string TableName
		{
			get { return tableName; }
			set { tableName = value; }
		}
	
		public int ObjectID
		{
			get { return objectID; }
			set { objectID = value; }
		}
	
		public int UserID
		{
			get { return userID; }
			set { userID = value; }
		}
	
		public string UserName
		{
			get { return userName; }
			set { userName = value; }
		}

        public DateTime ChangeDate
		{
            get { return changeDate; }
            set { changeDate = value; }
		}
	
		public string Change
		{
			get { return change; }
			set { change = value; }
		}
	
		public string OldValue
		{
			get { return oldValue; }
			set { oldValue = value; }
		}
	
		public string NewValue
		{
			get { return newValue; }
			set { newValue = value; }
		}
	
		public string Description
		{
			get { return description; }
			set { description = value; }
		}
	
	}
}
	