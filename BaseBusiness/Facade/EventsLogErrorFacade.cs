
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class EventsLogErrorFacade : BaseFacade
	{
		protected static EventsLogErrorFacade instance = new EventsLogErrorFacade(new EventsLogErrorModel());
		protected EventsLogErrorFacade(EventsLogErrorModel model) : base(model)
		{
		}
		public static EventsLogErrorFacade Instance
		{
			get { return instance; }
		}
		protected EventsLogErrorFacade():base() 
		{ 
		} 
	
	}
}
	