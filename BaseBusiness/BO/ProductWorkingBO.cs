
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class ProductWorkingBO : BaseBO
	{
		//private ProductWorkingFacade facade = ProductWorkingFacade.Instance;
		protected static ProductWorkingBO instance = new ProductWorkingBO();

		protected ProductWorkingBO()
		{
			//this.baseFacade = facade;
		}

		public static ProductWorkingBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	