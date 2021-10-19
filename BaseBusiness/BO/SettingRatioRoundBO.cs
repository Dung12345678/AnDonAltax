
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class SettingRatioRoundBO : BaseBO
	{
		private SettingRatioRoundFacade facade = SettingRatioRoundFacade.Instance;
		protected static SettingRatioRoundBO instance = new SettingRatioRoundBO();

		protected SettingRatioRoundBO()
		{
			this.baseFacade = facade;
		}

		public static SettingRatioRoundBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	