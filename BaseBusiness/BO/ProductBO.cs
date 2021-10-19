
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class ProductBO : BaseBO
	{
		private ProductFacade facade = ProductFacade.Instance;
		protected static ProductBO instance = new ProductBO();

		protected ProductBO()
		{
			this.baseFacade = facade;
		}

		public static ProductBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	