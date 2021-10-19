using System.Collections;
using BMS.Model;
namespace BMS.Facade
{

    public class EventsLogFacade : BaseFacade
    {
        protected static EventsLogFacade instance = new EventsLogFacade(new EventsLogModel());
        protected EventsLogFacade(EventsLogModel model)
            : base(model)
        {
        }
        public static EventsLogFacade Instance
        {
            get { return instance; }
        }
        protected EventsLogFacade()
            : base()
        {
        }

    }
}