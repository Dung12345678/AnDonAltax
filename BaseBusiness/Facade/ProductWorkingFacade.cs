
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class ProductWorkingFacade : BaseFacade
	{
		protected static ProductWorkingFacade instance = new ProductWorkingFacade(new ProductWorkingModel());
		protected ProductWorkingFacade(ProductWorkingModel model) : base(model)
		{
		}
		public static ProductWorkingFacade Instance
		{
			get { return instance; }
		}
		protected ProductWorkingFacade():base() 
		{ 
		} 
	
	}
}
	