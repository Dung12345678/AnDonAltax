
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class StatusCDBO : BaseBO
	{
		private StatusCDFacade facade = StatusCDFacade.Instance;
		protected static StatusCDBO instance = new StatusCDBO();

		protected StatusCDBO()
		{
			this.baseFacade = facade;
		}

		public static StatusCDBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	