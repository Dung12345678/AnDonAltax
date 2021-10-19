
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class GearInfoFacade : BaseFacade
	{
		protected static GearInfoFacade instance = new GearInfoFacade(new GearInfoModel());
		protected GearInfoFacade(GearInfoModel model) : base(model)
		{
		}
		public static GearInfoFacade Instance
		{
			get { return instance; }
		}
		protected GearInfoFacade():base() 
		{ 
		} 
	
	}
}
	