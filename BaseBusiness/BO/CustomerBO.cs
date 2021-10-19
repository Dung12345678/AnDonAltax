
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class CustomerBO : BaseBO
	{
		private CustomerFacade facade = CustomerFacade.Instance;
		protected static CustomerBO instance = new CustomerBO();

		protected CustomerBO()
		{
			this.baseFacade = facade;
		}

		public static CustomerBO Instance
		{
			get { return instance; }
		}
		
	    
	}
}
	