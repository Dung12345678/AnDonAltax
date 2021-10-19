
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class ConfigPLCBO : BaseBO
	{
		private ConfigPLCFacade facade = ConfigPLCFacade.Instance;
		protected static ConfigPLCBO instance = new ConfigPLCBO();

		protected ConfigPLCBO()
		{
			this.baseFacade = facade;
		}

		public static ConfigPLCBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	