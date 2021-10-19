
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class AndonConfigFacade : BaseFacade
	{
		protected static AndonConfigFacade instance = new AndonConfigFacade(new AndonConfigModel());
		protected AndonConfigFacade(AndonConfigModel model) : base(model)
		{
		}
		public static AndonConfigFacade Instance
		{
			get { return instance; }
		}
		protected AndonConfigFacade():base() 
		{ 
		} 
	
	}
}
	