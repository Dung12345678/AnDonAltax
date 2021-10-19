
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class ProductFacade : BaseFacade
	{
		protected static ProductFacade instance = new ProductFacade(new ProductModel());
		protected ProductFacade(ProductModel model) : base(model)
		{
		}
		public static ProductFacade Instance
		{
			get { return instance; }
		}
		protected ProductFacade():base() 
		{ 
		} 
	
	}
}
	