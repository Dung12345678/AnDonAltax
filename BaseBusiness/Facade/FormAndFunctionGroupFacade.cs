
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class FormAndFunctionGroupFacade : BaseFacade
	{
		protected static FormAndFunctionGroupFacade instance = new FormAndFunctionGroupFacade(new FormAndFunctionGroupModel());
		protected FormAndFunctionGroupFacade(FormAndFunctionGroupModel model) : base(model)
		{
		}
		public static FormAndFunctionGroupFacade Instance
		{
			get { return instance; }
		}
		protected FormAndFunctionGroupFacade():base() 
		{ 
		} 
	
	}
}
	