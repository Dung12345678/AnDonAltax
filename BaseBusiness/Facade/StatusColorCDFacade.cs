
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class StatusColorCDFacade : BaseFacade
	{
		protected static StatusColorCDFacade instance = new StatusColorCDFacade(new StatusColorCDModel());
		protected StatusColorCDFacade(StatusColorCDModel model) : base(model)
		{
		}
		public static StatusColorCDFacade Instance
		{
			get { return instance; }
		}
		protected StatusColorCDFacade():base() 
		{ 
		} 
	
	}
}
	