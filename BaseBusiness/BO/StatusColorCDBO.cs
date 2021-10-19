
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class StatusColorCDBO : BaseBO
	{
		private StatusColorCDFacade facade = StatusColorCDFacade.Instance;
		protected static StatusColorCDBO instance = new StatusColorCDBO();

		protected StatusColorCDBO()
		{
			this.baseFacade = facade;
		}

		public static StatusColorCDBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	