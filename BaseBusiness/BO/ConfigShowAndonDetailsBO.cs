
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class ConfigShowAndonDetailsBO : BaseBO
	{
		private ConfigShowAndonDetailsFacade facade = ConfigShowAndonDetailsFacade.Instance;
		protected static ConfigShowAndonDetailsBO instance = new ConfigShowAndonDetailsBO();

		protected ConfigShowAndonDetailsBO()
		{
			this.baseFacade = facade;
		}

		public static ConfigShowAndonDetailsBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	