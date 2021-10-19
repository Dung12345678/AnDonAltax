
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class PlanFacade : BaseFacade
	{
		protected static PlanFacade instance = new PlanFacade(new PlanModel());
		protected PlanFacade(PlanModel model) : base(model)
		{
		}
		public static PlanFacade Instance
		{
			get { return instance; }
		}
		protected PlanFacade():base() 
		{ 
		} 
	
	}
}
	