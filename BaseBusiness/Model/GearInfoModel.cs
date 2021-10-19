
using System;
namespace BMS.Model
{
	public class GearInfoModel : BaseModel
	{
		private int iD;
		private string gearCode;
		private decimal slitMin;
		private decimal slitMax;
		private decimal vibrateMin;
		private decimal vibrateMax;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string GearCode
		{
			get { return gearCode; }
			set { gearCode = value; }
		}
	
		public decimal SlitMin
		{
			get { return slitMin; }
			set { slitMin = value; }
		}
	
		public decimal SlitMax
		{
			get { return slitMax; }
			set { slitMax = value; }
		}
	
		public decimal VibrateMin
		{
			get { return vibrateMin; }
			set { vibrateMin = value; }
		}
	
		public decimal VibrateMax
		{
			get { return vibrateMax; }
			set { vibrateMax = value; }
		}
	
	}
}
	