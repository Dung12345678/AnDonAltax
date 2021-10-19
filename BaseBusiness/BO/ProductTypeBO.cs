
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class ProductTypeBO : BaseBO
	{
		private ProductTypeFacade facade = ProductTypeFacade.Instance;
		protected static ProductTypeBO instance = new ProductTypeBO();

		protected ProductTypeBO()
		{
			this.baseFacade = facade;
		}

		public static ProductTypeBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	