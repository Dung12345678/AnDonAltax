
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class AndonConfigBO : BaseBO
	{
		private AndonConfigFacade facade = AndonConfigFacade.Instance;
		protected static AndonConfigBO instance = new AndonConfigBO();

		protected AndonConfigBO()
		{
			this.baseFacade = facade;
		}

		public static AndonConfigBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	