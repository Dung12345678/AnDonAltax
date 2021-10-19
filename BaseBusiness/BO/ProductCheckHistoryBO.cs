
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class ProductCheckHistoryBO : BaseBO
	{
		private ProductCheckHistoryFacade facade = ProductCheckHistoryFacade.Instance;
		protected static ProductCheckHistoryBO instance = new ProductCheckHistoryBO();

		protected ProductCheckHistoryBO()
		{
			this.baseFacade = facade;
		}

		public static ProductCheckHistoryBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	