
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class ShiftConfigBO : BaseBO
	{
		private ShiftConfigFacade facade = ShiftConfigFacade.Instance;
		protected static ShiftConfigBO instance = new ShiftConfigBO();

		protected ShiftConfigBO()
		{
			this.baseFacade = facade;
		}

		public static ShiftConfigBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	