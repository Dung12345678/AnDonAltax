
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class ConfigSystemFacade : BaseFacade
	{
		protected static ConfigSystemFacade instance = new ConfigSystemFacade(new ConfigSystemModel());
		protected ConfigSystemFacade(ConfigSystemModel model) : base(model)
		{
		}
		public static ConfigSystemFacade Instance
		{
			get { return instance; }
		}
		protected ConfigSystemFacade():base() 
		{ 
		} 
	
	}
}
	