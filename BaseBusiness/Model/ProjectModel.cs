
using System;
namespace BMS.Model
{
	public class ProjectModel : BaseModel
	{
		private int iD;
		private int customerID;
		private string projectCode;
		private string projectName;
		private int timeMake;
		private DateTime? startDate;
		private DateTime? dateFinishE;
		private DateTime? dateFinishF;
		private string note;
		private int status;
		private int projectType;
		private int userId;
		private DateTime? dateSingingContract;
		private DateTime? designDeadline;
		private DateTime? assemblyDeadline;
		private bool isAssembly;
		private string contactName;
		private string contactPhone;
		private string contactEmail;
		private string createdBy;
		private DateTime? createdDate;
		private string updatedBy;
		private DateTime? updatedDate;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public int CustomerID
		{
			get { return customerID; }
			set { customerID = value; }
		}
	
		public string ProjectCode
		{
			get { return projectCode; }
			set { projectCode = value; }
		}
	
		public string ProjectName
		{
			get { return projectName; }
			set { projectName = value; }
		}
	
		public int TimeMake
		{
			get { return timeMake; }
			set { timeMake = value; }
		}
	
		public DateTime? StartDate
		{
			get { return startDate; }
			set { startDate = value; }
		}
	
		public DateTime? DateFinishE
		{
			get { return dateFinishE; }
			set { dateFinishE = value; }
		}
	
		public DateTime? DateFinishF
		{
			get { return dateFinishF; }
			set { dateFinishF = value; }
		}
	
		public string Note
		{
			get { return note; }
			set { note = value; }
		}
	
		public int Status
		{
			get { return status; }
			set { status = value; }
		}
	
		public int ProjectType
		{
			get { return projectType; }
			set { projectType = value; }
		}
	
		public int UserId
		{
			get { return userId; }
			set { userId = value; }
		}
	
		public DateTime? DateSingingContract
		{
			get { return dateSingingContract; }
			set { dateSingingContract = value; }
		}
	
		public DateTime? DesignDeadline
		{
			get { return designDeadline; }
			set { designDeadline = value; }
		}
	
		public DateTime? AssemblyDeadline
		{
			get { return assemblyDeadline; }
			set { assemblyDeadline = value; }
		}
	
		public bool IsAssembly
		{
			get { return isAssembly; }
			set { isAssembly = value; }
		}
	
		public string ContactName
		{
			get { return contactName; }
			set { contactName = value; }
		}
	
		public string ContactPhone
		{
			get { return contactPhone; }
			set { contactPhone = value; }
		}
	
		public string ContactEmail
		{
			get { return contactEmail; }
			set { contactEmail = value; }
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
	