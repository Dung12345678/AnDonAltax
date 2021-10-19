
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class CompanyFacade : BaseFacade
	{
		protected static CompanyFacade instance = new CompanyFacade(new CompanyModel());
		protected CompanyFacade(CompanyModel model) : base(model)
		{
		}
		public static CompanyFacade Instance
		{
			get { return instance; }
		}
		protected CompanyFacade():base() 
		{ 
		} 
	
	}
}
	