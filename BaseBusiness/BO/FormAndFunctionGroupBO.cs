
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class FormAndFunctionGroupBO : BaseBO
	{
		private FormAndFunctionGroupFacade facade = FormAndFunctionGroupFacade.Instance;
		protected static FormAndFunctionGroupBO instance = new FormAndFunctionGroupBO();

		protected FormAndFunctionGroupBO()
		{
			this.baseFacade = facade;
		}

		public static FormAndFunctionGroupBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	