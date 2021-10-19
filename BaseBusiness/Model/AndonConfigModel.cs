
using System;
namespace BMS.Model
{
	public partial class AndonConfigModel : BaseModel
	{
		public int ID {get; set;}
		
		public decimal FontSize1 {get; set;}
		
		public decimal FontSize2 {get; set;}
		
		public decimal FontSize3 {get; set;}
		
		public decimal FontSize4 {get; set;}
		
		public decimal FontSize5 {get; set;}
		
		public decimal FontSize6 {get; set;}
		
		public decimal FontSize7 {get; set;}
		
		public int Takt {get; set;}
		
		public string TcpIp {get; set;}
		
		public int SocketPort {get; set;}
		
		public int IsStopCD8 {get; set;}
		
		public string ComPLC {get; set;}
		
		public string AreaDelayPLC {get; set;}
		
		public string AreaRiskPLC {get; set;}
		
	}
}
	