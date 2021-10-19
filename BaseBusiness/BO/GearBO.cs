
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class GearBO : BaseBO
	{
		private GearFacade facade = GearFacade.Instance;
		protected static GearBO instance = new GearBO();

		protected GearBO()
		{
			this.baseFacade = facade;
		}

		public static GearBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	