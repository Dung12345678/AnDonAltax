
using System;
namespace BMS.Model
{
	public class EventsLogModel : BaseModel
	{
		private int iD;
		private DateTime logDate;
		private int userID;
		private string action;
		private int objectID;
		private string tableName;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public DateTime LogDate
		{
			get { return logDate; }
			set { logDate = value; }
		}
	
		public int UserID
		{
			get { return userID; }
			set { userID = value; }
		}
	
		public string Action
		{
			get { return action; }
			set { action = value; }
		}
	
		public int ObjectID
		{
			get { return objectID; }
			set { objectID = value; }
		}
	
		public string TableName
		{
			get { return tableName; }
			set { tableName = value; }
		}
	
	}
}
	