using System;
using System.Collections;
using BMS.BO;
using BMS.Exceptions;
using BMS.Utils;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class EventsLogBO : BaseBO
	{
		private EventsLogFacade facade = EventsLogFacade.Instance;
		protected static EventsLogBO instance = new EventsLogBO();

		protected EventsLogBO()
		{
			this.baseFacade = facade;
		}

		public static EventsLogBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	