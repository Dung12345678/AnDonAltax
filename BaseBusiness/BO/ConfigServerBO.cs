
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class ConfigServerBO : BaseBO
	{
		private ConfigServerFacade facade = ConfigServerFacade.Instance;
		protected static ConfigServerBO instance = new ConfigServerBO();

		protected ConfigServerBO()
		{
			this.baseFacade = facade;
		}

		public static ConfigServerBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	