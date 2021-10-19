
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class RiskBO : BaseBO
	{
		private RiskFacade facade = RiskFacade.Instance;
		protected static RiskBO instance = new RiskBO();

		protected RiskBO()
		{
			this.baseFacade = facade;
		}

		public static RiskBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	