
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class SessionFacade : BaseFacade
	{
		protected static SessionFacade instance = new SessionFacade(new SessionModel());
		protected SessionFacade(SessionModel model) : base(model)
		{
		}
		public static SessionFacade Instance
		{
			get { return instance; }
		}
		protected SessionFacade():base() 
		{ 
		} 
	
	}
}
	