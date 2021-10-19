
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class ProductCheckHistoryDetailBO : BaseBO
	{
		private ProductCheckHistoryDetailFacade facade = ProductCheckHistoryDetailFacade.Instance;
		protected static ProductCheckHistoryDetailBO instance = new ProductCheckHistoryDetailBO();

		protected ProductCheckHistoryDetailBO()
		{
			this.baseFacade = facade;
		}

		public static ProductCheckHistoryDetailBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	