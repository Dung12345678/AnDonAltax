using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BMS.Model
{
	public class ShiftAndonModel
	{
		private int id;
		private string code;
		private string name;
		private DateTime startTime;
		private DateTime endTime;
		private string delShiftTime;


        //public ShiftAndonModel(DataRow row)
        //{
        //    this.id = (int)row["ID"];
        //    this.code = row["Code"].ToString();
        //    this.name = row["Name"].ToString();
        //    this.startTime = Convert.ToDateTime(row["StartTime"]);
        //    this.endTime = Convert.ToDateTime(row["EndTime"]);
        //    this.DelShiftTime = this.name + ": ( " + this.startTime.ToString("HH:mm") + " - " + this.endTime.ToString("HH:mm") + " )";
        //}

		
        //public int Id { get => id; set => id = value; }
        //public string Code { get => code; set => code = value; }
        //public string Name { get => name; set => name = value; }
        //public DateTime StartTime { get => startTime; set => startTime = value; }
        //public DateTime EndTime { get => endTime; set => endTime = value; }
        //public string DelShiftTime { get => delShiftTime; set => delShiftTime = value; }
        ////public string DelShiftTime { get => delShiftTime; set => delShiftTime = value; }


	}
}
