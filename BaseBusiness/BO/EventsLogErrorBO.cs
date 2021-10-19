
using System;
using System.Collections;
using BMS.Exceptions;
using BMS.Utils;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class EventsLogErrorBO : BaseBO
	{
		private EventsLogErrorFacade facade = EventsLogErrorFacade.Instance;
		protected static EventsLogErrorBO instance = new EventsLogErrorBO();

		protected EventsLogErrorBO()
		{
			this.baseFacade = facade;
		}

		public static EventsLogErrorBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	