using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Däckarn
{
    public partial class FormPickDate : Form
    {
        public FormPickDate()
        {
            InitializeComponent();
        }

        private void FormPickDate_Load(object sender, EventArgs e)
        {
            monthCalendar.MinDate = DateTime.Now;
            monthCalendar.MaxDate = DateTime.Now.AddDays(14);
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            var dates = GlobalDataManager.WorkSchedule.GetJobTimeFrames(monthCalendar.SelectionStart);

            foreach (var date in dates)
            {
                UpdateRadioEnabled(date.Time.Hour, date.Available);
            }
        }

        private void UpdateRadioEnabled(int hour, bool enabled = true)
        {
            if (hour < 8 || hour > 17 || hour == 13)
            {
                return;
            }

            switch (hour)
            {
                case 8:
                    radioButton8to9.Enabled = enabled;
                    break;
                case 9:
                    radioButton9to10.Enabled = enabled;
                    break;
                case 10:
                    radioButton10to11.Enabled = enabled;
                    break;
                case 11:
                    radioButton11to12.Enabled = enabled;
                    break;
                case 12:
                    radioButton12to13.Enabled = enabled;
                    break;
                case 14:
                    radioButton14to15.Enabled = enabled;
                    break;
                case 15:
                    radioButton15to16.Enabled = enabled;
                    break;
                case 16:
                    radioButton16to17.Enabled = enabled;
                    break;
            }
        }

        private void buttonPick_Click(object sender, EventArgs e)
        {
            foreach(var control in Controls)
            {
                if(control is RadioButton)
                {
                    var radioButton = (RadioButton)control;
                    if(radioButton.Checked)
                    {
                        DateTime dt = monthCalendar.SelectionStart;
                        string? tagString = radioButton.Tag.ToString();

                        if(tagString == null)
                        {
                            return;
                        }

                        int time = Int32.Parse(tagString);
                        TimeSpan newTime = new TimeSpan(time, 0, 0);

                        dt = dt.Date + newTime;
                        FormAddBooking parent = (FormAddBooking)Owner;
                        parent.SetBookingDate(dt);
                        Close();
                        return;
                    }
                }
            }

            MessageBox.Show("Välj en tid som du vill boka!", "Schema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
