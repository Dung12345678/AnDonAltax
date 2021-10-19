
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class RiskFacade : BaseFacade
	{
		protected static RiskFacade instance = new RiskFacade(new RiskModel());
		protected RiskFacade(RiskModel model) : base(model)
		{
		}
		public static RiskFacade Instance
		{
			get { return instance; }
		}
		protected RiskFacade():base() 
		{ 
		} 
	
	}
}
	