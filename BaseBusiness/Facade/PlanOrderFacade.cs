
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class PlanOrderFacade : BaseFacade
	{
		protected static PlanOrderFacade instance = new PlanOrderFacade(new PlanOrderModel());
		protected PlanOrderFacade(PlanOrderModel model) : base(model)
		{
		}
		public static PlanOrderFacade Instance
		{
			get { return instance; }
		}
		protected PlanOrderFacade():base() 
		{ 
		} 
	
	}
}
	