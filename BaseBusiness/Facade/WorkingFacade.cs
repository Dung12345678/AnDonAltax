
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class WorkingFacade : BaseFacade
	{
		protected static WorkingFacade instance = new WorkingFacade(new WorkingModel());
		protected WorkingFacade(WorkingModel model) : base(model)
		{
		}
		public static WorkingFacade Instance
		{
			get { return instance; }
		}
		protected WorkingFacade():base() 
		{ 
		} 
	
	}
}
	