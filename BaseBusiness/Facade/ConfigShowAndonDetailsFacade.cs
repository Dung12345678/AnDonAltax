
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class ConfigShowAndonDetailsFacade : BaseFacade
	{
		protected static ConfigShowAndonDetailsFacade instance = new ConfigShowAndonDetailsFacade(new ConfigShowAndonDetailsModel());
		protected ConfigShowAndonDetailsFacade(ConfigShowAndonDetailsModel model) : base(model)
		{
		}
		public static ConfigShowAndonDetailsFacade Instance
		{
			get { return instance; }
		}
		protected ConfigShowAndonDetailsFacade():base() 
		{ 
		} 
	
	}
}
	