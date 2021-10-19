
using System;
namespace BMS.Model
{
	public class ProductModel : BaseModel
	{
		private int iD;
		private int productGroupID;
		private int productTypeID;
		private string maVanBan;
		private string productCode;
		private string productName;
		private string ratioCode;
		private string slowSpeedShaftDimesion;
		private decimal doDao;
		private string mURATA;
		private string motorCode;
		private string mauSon;
		private string giamTocTong;
		private string tiengOn;
		private string pinNumber;
		private string loaiMo;
		private decimal luongMo;
		private DateTime? mEDEDAY;
		private string coilCode;
		private string lucCheckGearMotor;
		private string lucCheckGear;
		private string huongHopCau;
		private string createdBy;
		private DateTime? createdDate;
		private string updatedBy;
		private DateTime? updatedDate;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public int ProductGroupID
		{
			get { return productGroupID; }
			set { productGroupID = value; }
		}
	
		public int ProductTypeID
		{
			get { return productTypeID; }
			set { productTypeID = value; }
		}
	
		public string MaVanBan
		{
			get { return maVanBan; }
			set { maVanBan = value; }
		}
	
		public string ProductCode
		{
			get { return productCode; }
			set { productCode = value; }
		}
	
		public string ProductName
		{
			get { return productName; }
			set { productName = value; }
		}
	
		public string RatioCode
		{
			get { return ratioCode; }
			set { ratioCode = value; }
		}
	
		public string SlowSpeedShaftDimesion
		{
			get { return slowSpeedShaftDimesion; }
			set { slowSpeedShaftDimesion = value; }
		}
	
		public decimal DoDao
		{
			get { return doDao; }
			set { doDao = value; }
		}
	
		public string MURATA
		{
			get { return mURATA; }
			set { mURATA = value; }
		}
	
		public string MotorCode
		{
			get { return motorCode; }
			set { motorCode = value; }
		}
	
		public string MauSon
		{
			get { return mauSon; }
			set { mauSon = value; }
		}
	
		public string GiamTocTong
		{
			get { return giamTocTong; }
			set { giamTocTong = value; }
		}
	
		public string TiengOn
		{
			get { return tiengOn; }
			set { tiengOn = value; }
		}
	
		public string PinNumber
		{
			get { return pinNumber; }
			set { pinNumber = value; }
		}
	
		public string LoaiMo
		{
			get { return loaiMo; }
			set { loaiMo = value; }
		}
	
		public decimal LuongMo
		{
			get { return luongMo; }
			set { luongMo = value; }
		}
	
		public DateTime? MEDEDAY
		{
			get { return mEDEDAY; }
			set { mEDEDAY = value; }
		}
	
		public string CoilCode
		{
			get { return coilCode; }
			set { coilCode = value; }
		}
	
		public string LucCheckGearMotor
		{
			get { return lucCheckGearMotor; }
			set { lucCheckGearMotor = value; }
		}
	
		public string LucCheckGear
		{
			get { return lucCheckGear; }
			set { lucCheckGear = value; }
		}
	
		public string HuongHopCau
		{
			get { return huongHopCau; }
			set { huongHopCau = value; }
		}
	
		public string CreatedBy
		{
			get { return createdBy; }
			set { createdBy = value; }
		}
	
		public DateTime? CreatedDate
		{
			get { return createdDate; }
			set { createdDate = value; }
		}
	
		public string UpdatedBy
		{
			get { return updatedBy; }
			set { updatedBy = value; }
		}
	
		public DateTime? UpdatedDate
		{
			get { return updatedDate; }
			set { updatedDate = value; }
		}

        public string UnitMotor { get; set; }
        public DateTime? ProductDate { get; set; }
    }
}
	