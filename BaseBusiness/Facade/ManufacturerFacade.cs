
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class ManufacturerFacade : BaseFacade
	{
		protected static ManufacturerFacade instance = new ManufacturerFacade(new ManufacturerModel());
		protected ManufacturerFacade(ManufacturerModel model) : base(model)
		{
		}
		public static ManufacturerFacade Instance
		{
			get { return instance; }
		}
		protected ManufacturerFacade():base() 
		{ 
		} 
	
	}
}
	