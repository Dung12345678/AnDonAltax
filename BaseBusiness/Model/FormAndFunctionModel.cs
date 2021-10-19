
using System;
namespace BMS.Model
{
	public class FormAndFunctionModel : BaseModel
	{
		private int iD;
		private string code;
		private string name;
		private string description;
		private bool shiftKey;
		private bool ctrlKey;
		private bool altKey;
		private string shortcutKey;
		private int formAndFunctionGroupID;
		private string createdBy;
		private DateTime? createdDate;
		private string updatedBy;
		private DateTime? updatedDate;
		private bool isHide;
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
	
		public bool ShiftKey
		{
			get { return shiftKey; }
			set { shiftKey = value; }
		}
	
		public bool CtrlKey
		{
			get { return ctrlKey; }
			set { ctrlKey = value; }
		}
	
		public bool AltKey
		{
			get { return altKey; }
			set { altKey = value; }
		}
	
		public string ShortcutKey
		{
			get { return shortcutKey; }
			set { shortcutKey = value; }
		}
	
		public int FormAndFunctionGroupID
		{
			get { return formAndFunctionGroupID; }
			set { formAndFunctionGroupID = value; }
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
	
		public bool IsHide
		{
			get { return isHide; }
			set { isHide = value; }
		}
	
	}
}
	