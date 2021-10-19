
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class PlanBO : BaseBO
	{
		private PlanFacade facade = PlanFacade.Instance;
		protected static PlanBO instance = new PlanBO();

		protected PlanBO()
		{
			this.baseFacade = facade;
		}

		public static PlanBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	