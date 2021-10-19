
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class ConfigPLCFacade : BaseFacade
	{
		protected static ConfigPLCFacade instance = new ConfigPLCFacade(new ConfigPLCModel());
		protected ConfigPLCFacade(ConfigPLCModel model) : base(model)
		{
		}
		public static ConfigPLCFacade Instance
		{
			get { return instance; }
		}
		protected ConfigPLCFacade():base() 
		{ 
		} 
	
	}
}
	