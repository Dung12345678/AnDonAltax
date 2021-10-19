
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class StatusCDFacade : BaseFacade
	{
		protected static StatusCDFacade instance = new StatusCDFacade(new StatusCDModel());
		protected StatusCDFacade(StatusCDModel model) : base(model)
		{
		}
		public static StatusCDFacade Instance
		{
			get { return instance; }
		}
		protected StatusCDFacade():base() 
		{ 
		} 
	
	}
}
	