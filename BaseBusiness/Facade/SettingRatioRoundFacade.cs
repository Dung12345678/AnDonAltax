
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class SettingRatioRoundFacade : BaseFacade
	{
		protected static SettingRatioRoundFacade instance = new SettingRatioRoundFacade(new SettingRatioRoundModel());
		protected SettingRatioRoundFacade(SettingRatioRoundModel model) : base(model)
		{
		}
		public static SettingRatioRoundFacade Instance
		{
			get { return instance; }
		}
		protected SettingRatioRoundFacade():base() 
		{ 
		} 
	
	}
}
	