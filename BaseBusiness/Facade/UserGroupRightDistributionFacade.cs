
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class UserGroupRightDistributionFacade : BaseFacade
	{
		protected static UserGroupRightDistributionFacade instance = new UserGroupRightDistributionFacade(new UserGroupRightDistributionModel());
		protected UserGroupRightDistributionFacade(UserGroupRightDistributionModel model) : base(model)
		{
		}
		public static UserGroupRightDistributionFacade Instance
		{
			get { return instance; }
		}
		protected UserGroupRightDistributionFacade():base() 
		{ 
		} 
	
	}
}
	