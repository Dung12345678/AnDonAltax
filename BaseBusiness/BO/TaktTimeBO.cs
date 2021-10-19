
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class TaktTimeBO : BaseBO
	{
		private TaktTimeFacade facade = TaktTimeFacade.Instance;
		protected static TaktTimeBO instance = new TaktTimeBO();

		protected TaktTimeBO()
		{
			this.baseFacade = facade;
		}

		public static TaktTimeBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	