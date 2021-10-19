
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class TesttaBO : BaseBO
	{
		private TesttaFacade facade = TesttaFacade.Instance;
		protected static TesttaBO instance = new TesttaBO();

		protected TesttaBO()
		{
			this.baseFacade = facade;
		}

		public static TesttaBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	