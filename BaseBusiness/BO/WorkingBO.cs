
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class WorkingBO : BaseBO
	{
		private WorkingFacade facade = WorkingFacade.Instance;
		protected static WorkingBO instance = new WorkingBO();

		protected WorkingBO()
		{
			this.baseFacade = facade;
		}

		public static WorkingBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	