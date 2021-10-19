
using System;
namespace BMS.Model
{
	public class SettingFFTModel : BaseModel
	{
		private int iD;
		private int productGroupID;
		private int productTypeID;
		private string ratioCode;
		private string fFTValue;
		private string noiseValue;
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
	
		public string RatioCode
		{
			get { return ratioCode; }
			set { ratioCode = value; }
		}
	
		public string FFTValue
		{
			get { return fFTValue; }
			set { fFTValue = value; }
		}
	
		public string NoiseValue
		{
			get { return noiseValue; }
			set { noiseValue = value; }
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
	
	}
}
	