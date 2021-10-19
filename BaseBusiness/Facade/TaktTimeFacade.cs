
using System.Collections;
using BMS.Model;
namespace BMS.Facade
{
	
	public class TaktTimeFacade : BaseFacade
	{
		protected static TaktTimeFacade instance = new TaktTimeFacade(new TaktTimeModel());
		protected TaktTimeFacade(TaktTimeModel model) : base(model)
		{
		}
		public static TaktTimeFacade Instance
		{
			get { return instance; }
		}
		protected TaktTimeFacade():base() 
		{ 
		} 
	
	}
}
	