
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class AndonDetailFacade : BaseFacade
	{
		protected static AndonDetailFacade instance = new AndonDetailFacade(new AndonDetailModel());
		protected AndonDetailFacade(AndonDetailModel model) : base(model)
		{
		}
		public static AndonDetailFacade Instance
		{
			get { return instance; }
		}
		protected AndonDetailFacade():base() 
		{ 
		} 
	
	}
}
	