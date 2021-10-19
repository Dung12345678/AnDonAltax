
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class ShiftConfigFacade : BaseFacade
	{
		protected static ShiftConfigFacade instance = new ShiftConfigFacade(new ShiftConfigModel());
		protected ShiftConfigFacade(ShiftConfigModel model) : base(model)
		{
		}
		public static ShiftConfigFacade Instance
		{
			get { return instance; }
		}
		protected ShiftConfigFacade():base() 
		{ 
		} 
	
	}
}
	