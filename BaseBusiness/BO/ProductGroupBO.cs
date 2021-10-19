
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class ProductGroupBO : BaseBO
	{
		private ProductGroupFacade facade = ProductGroupFacade.Instance;
		protected static ProductGroupBO instance = new ProductGroupBO();

		protected ProductGroupBO()
		{
			this.baseFacade = facade;
		}

		public static ProductGroupBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	