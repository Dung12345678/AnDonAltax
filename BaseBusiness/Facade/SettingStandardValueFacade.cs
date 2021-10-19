
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class SettingStandardValueFacade : BaseFacade
	{
		protected static SettingStandardValueFacade instance = new SettingStandardValueFacade(new SettingStandardValueModel());
		protected SettingStandardValueFacade(SettingStandardValueModel model) : base(model)
		{
		}
		public static SettingStandardValueFacade Instance
		{
			get { return instance; }
		}
		protected SettingStandardValueFacade():base() 
		{ 
		} 
	
	}
}
	