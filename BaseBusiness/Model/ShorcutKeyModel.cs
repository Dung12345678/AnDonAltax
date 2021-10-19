
using System;

namespace BMS.Model
{
	public class ShorcutKeyModel : BaseModel
	{
		private string name;
		private int index;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	
		public int Index
		{
			get { return index; }
			set { index = value; }
		}
	
	}
}
	