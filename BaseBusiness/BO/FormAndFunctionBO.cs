
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class FormAndFunctionBO : BaseBO
	{
		private FormAndFunctionFacade facade = FormAndFunctionFacade.Instance;
		protected static FormAndFunctionBO instance = new FormAndFunctionBO();

		protected FormAndFunctionBO()
		{
			this.baseFacade = facade;
		}

		public static FormAndFunctionBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	