
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class ShorcutKeyFacade : BaseFacade
	{
		protected static ShorcutKeyFacade instance = new ShorcutKeyFacade(new ShorcutKeyModel());
		protected ShorcutKeyFacade(ShorcutKeyModel model) : base(model)
		{
		}
		public static ShorcutKeyFacade Instance
		{
			get { return instance; }
		}
		protected ShorcutKeyFacade():base() 
		{ 
		} 
	
	}
}
	