
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class ConfigServerFacade : BaseFacade
	{
		protected static ConfigServerFacade instance = new ConfigServerFacade(new ConfigServerModel());
		protected ConfigServerFacade(ConfigServerModel model) : base(model)
		{
		}
		public static ConfigServerFacade Instance
		{
			get { return instance; }
		}
		protected ConfigServerFacade():base() 
		{ 
		} 
	
	}
}
	