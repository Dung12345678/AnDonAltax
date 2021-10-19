
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class FormAndFunctionFacade : BaseFacade
	{
		protected static FormAndFunctionFacade instance = new FormAndFunctionFacade(new FormAndFunctionModel());
		protected FormAndFunctionFacade(FormAndFunctionModel model) : base(model)
		{
		}
		public static FormAndFunctionFacade Instance
		{
			get { return instance; }
		}
		protected FormAndFunctionFacade():base() 
		{ 
		} 
	
	}
}
	