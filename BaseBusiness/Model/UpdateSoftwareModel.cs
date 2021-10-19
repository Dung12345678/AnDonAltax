
using System;
namespace BMS.Model
{
	public class UpdateSoftwareModel : BaseModel
	{
		private long iD;
		private string code;
		private string name;
		private int userID;
		private DateTime? requestDate;
		private DateTime? ngayBaoGia;
		private DateTime? ngayBaoGiaConfirm;
		private DateTime? workStartDate;
		private DateTime? workEndDateDK;
		private DateTime? workEndDate;
		private DateTime? confirmDate;
		private int confirm;
		private int status;
		private string note;
		private string softwareCompany;
		private string softwareName;
		private bool complete;
		private int type;
		private decimal price;
		public long ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string Code
		{
			get { return code; }
			set { code = value; }
		}
	
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	
		public int UserID
		{
			get { return userID; }
			set { userID = value; }
		}
	
		public DateTime? RequestDate
		{
			get { return requestDate; }
			set { requestDate = value; }
		}
	
		public DateTime? NgayBaoGia
		{
			get { return ngayBaoGia; }
			set { ngayBaoGia = value; }
		}
	
		public DateTime? NgayBaoGiaConfirm
		{
			get { return ngayBaoGiaConfirm; }
			set { ngayBaoGiaConfirm = value; }
		}
	
		public DateTime? WorkStartDate
		{
			get { return workStartDate; }
			set { workStartDate = value; }
		}
	
		public DateTime? WorkEndDateDK
		{
			get { return workEndDateDK; }
			set { workEndDateDK = value; }
		}
	
		public DateTime? WorkEndDate
		{
			get { return workEndDate; }
			set { workEndDate = value; }
		}
	
		public DateTime? ConfirmDate
		{
			get { return confirmDate; }
			set { confirmDate = value; }
		}
	
		public int Confirm
		{
			get { return confirm; }
			set { confirm = value; }
		}
	
		public int Status
		{
			get { return status; }
			set { status = value; }
		}
	
		public string Note
		{
			get { return note; }
			set { note = value; }
		}
	
		public string SoftwareCompany
		{
			get { return softwareCompany; }
			set { softwareCompany = value; }
		}
	
		public string SoftwareName
		{
			get { return softwareName; }
			set { softwareName = value; }
		}
	
		public bool Complete
		{
			get { return complete; }
			set { complete = value; }
		}
	
		public int Type
		{
			get { return type; }
			set { type = value; }
		}
	
		public decimal Price
		{
			get { return price; }
			set { price = value; }
		}
	
	}
}
	