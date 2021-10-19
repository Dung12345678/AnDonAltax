using System;
using System.Windows.Forms;  
namespace BMS
{
    public class NDateTimePicker : System.Windows.Forms.DateTimePicker
    {
        private DateTimePickerFormat oldFormat = DateTimePickerFormat.Long;
        private string oldCustomFormat = null;
        private bool bIsNull = false;

        public NDateTimePicker()
            : base()
        {
        }

        public new DateTime Value
        {
            get
            {
                if (bIsNull || base.Value == DateTime.MinValue)
                    //return DateTime.MinValue;
                    return DefValues.Sql_MinDate;
                else
                    return base.Value;
            }
            set
            {
                if (value == DateTime.MinValue || value == DefValues.Sql_MinDate)
                {
                    if (bIsNull == false)
                    {
                        oldFormat = this.Format;
                        oldCustomFormat = this.CustomFormat;
                        bIsNull = true;
                    }

                    this.Format = DateTimePickerFormat.Custom;
                    this.CustomFormat = " ";
                }
                else
                {
                    if (bIsNull)
                    {
                        this.Format = oldFormat;
                        this.CustomFormat = oldCustomFormat;
                        bIsNull = false;
                        
                    }
                    //base.Value = DateTime.Now;
                    base.Value = value;
                }
            }
        }

        protected override void OnCloseUp(EventArgs eventargs)
        {
            if (Control.MouseButtons == MouseButtons.None)
            {
                if (bIsNull)
                {
                    this.Format = oldFormat;
                    this.CustomFormat = oldCustomFormat;
                    bIsNull = false;
                }
            }
            base.OnCloseUp(eventargs);
        }

        protected override void OnValueChanged(EventArgs eventargs)
        {
            Value = base.Value;
            base.OnValueChanged(eventargs);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Delete)
                this.Value = DateTime.MinValue;
        }
    }

}
