
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class TesttaFacade : BaseFacade
	{
		protected static TesttaFacade instance = new TesttaFacade(new TesttaModel());
		protected TesttaFacade(TesttaModel model) : base(model)
		{
		}
		public static TesttaFacade Instance
		{
			get { return instance; }
		}
		protected TesttaFacade():base() 
		{ 
		} 
	
	}
}
	