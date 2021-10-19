
using System;
using System.Collections;
using BMS.BO;
using BMS.Exceptions;
using BMS.Utils;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class ActivityLogBO : BaseBO
	{
		private ActivityLogFacade facade = ActivityLogFacade.Instance;
		protected static ActivityLogBO instance = new ActivityLogBO();

		protected ActivityLogBO()
		{
			this.baseFacade = facade;
		}

		public static ActivityLogBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	