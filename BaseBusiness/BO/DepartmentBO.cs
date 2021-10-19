
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class DepartmentBO : BaseBO
	{
		private DepartmentFacade facade = DepartmentFacade.Instance;
		protected static DepartmentBO instance = new DepartmentBO();

		protected DepartmentBO()
		{
			this.baseFacade = facade;
		}

		public static DepartmentBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	