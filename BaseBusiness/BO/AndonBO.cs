
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class AndonBO : BaseBO
	{
		private AndonFacade facade = AndonFacade.Instance;
		protected static AndonBO instance = new AndonBO();

		protected AndonBO()
		{
			this.baseFacade = facade;
		}

		public static AndonBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	