
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class ShiftBO : BaseBO
	{
		private ShiftFacade facade = ShiftFacade.Instance;
		protected static ShiftBO instance = new ShiftBO();

		protected ShiftBO()
		{
			this.baseFacade = facade;
		}

		public static ShiftBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	