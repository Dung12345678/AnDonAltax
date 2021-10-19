
using System;
namespace BMS.Model
{
	public class GearModel : BaseModel
	{
		private int iD;
		private string hYP;
		private string gear1;
		private string gear2;
		private string gear3;
		private string lap;
		private int lotSize;
		private int gThieu;
		private int gGiaCongThem;
		private int wipG;
		private int onhandG;
		private int stockGCQT;
		private int wipGCQT;
		private int wipTruc;
		private int orderTrucMoi;
		private int hypNeed;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string HYP
		{
			get { return hYP; }
			set { hYP = value; }
		}
	
		public string Gear1
		{
			get { return gear1; }
			set { gear1 = value; }
		}
	
		public string Gear2
		{
			get { return gear2; }
			set { gear2 = value; }
		}
	
		public string Gear3
		{
			get { return gear3; }
			set { gear3 = value; }
		}
	
		public string Lap
		{
			get { return lap; }
			set { lap = value; }
		}
	
		public int LotSize
		{
			get { return lotSize; }
			set { lotSize = value; }
		}
	
		public int GThieu
		{
			get { return gThieu; }
			set { gThieu = value; }
		}
	
		public int GGiaCongThem
		{
			get { return gGiaCongThem; }
			set { gGiaCongThem = value; }
		}
	
		public int WipG
		{
			get { return wipG; }
			set { wipG = value; }
		}
	
		public int OnhandG
		{
			get { return onhandG; }
			set { onhandG = value; }
		}
	
		public int StockGCQT
		{
			get { return stockGCQT; }
			set { stockGCQT = value; }
		}
	
		public int WipGCQT
		{
			get { return wipGCQT; }
			set { wipGCQT = value; }
		}
	
		public int WipTruc
		{
			get { return wipTruc; }
			set { wipTruc = value; }
		}
	
		public int OrderTrucMoi
		{
			get { return orderTrucMoi; }
			set { orderTrucMoi = value; }
		}
	
		public int HypNeed
		{
			get { return hypNeed; }
			set { hypNeed = value; }
		}
	
	}
}
	