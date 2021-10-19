
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class SettingFFTBO : BaseBO
	{
		private SettingFFTFacade facade = SettingFFTFacade.Instance;
		protected static SettingFFTBO instance = new SettingFFTBO();

		protected SettingFFTBO()
		{
			this.baseFacade = facade;
		}

		public static SettingFFTBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	