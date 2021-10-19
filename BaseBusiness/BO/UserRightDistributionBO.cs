
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class UserRightDistributionBO : BaseBO
	{
		private UserRightDistributionFacade facade = UserRightDistributionFacade.Instance;
		protected static UserRightDistributionBO instance = new UserRightDistributionBO();

		protected UserRightDistributionBO()
		{
			this.baseFacade = facade;
		}

		public static UserRightDistributionBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	