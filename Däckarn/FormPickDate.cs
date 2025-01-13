/*
 * Projektarbete i Objektorienterad programmering GIK299, HT24
 * 
 * Däckarn
 * 
 * Andreas Lindström
 * Ameer Abdelakhwa
 * 
 */
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
            // Make sure we can only book 14 days ahead, we just picked a number out of the blue
            monthCalendar.MinDate = DateTime.Now;
            monthCalendar.MaxDate = DateTime.Now.AddDays(14);

            RefreshRadioButtons();
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            RefreshRadioButtons();
        }

        // Update all radio buttons
        private void RefreshRadioButtons()
        {
            if(GlobalDataManager.WorkSchedule == null)
            {
                return;
            }

            var jobTimeFrames = GlobalDataManager.WorkSchedule.GetJobTimeFrames(monthCalendar.SelectionStart);

            // Go over each timeFrame for the day
            foreach (var timeFrame in jobTimeFrames)
            {
                // If the timeframe is available, set the radioButton that represents that time, to enabled
                // Or disabled if not available.
                UpdateRadioEnabled(timeFrame.Time.Hour, timeFrame.Available);
            }
        }

        private void UpdateRadioEnabled(int hour, bool enabled = true)
        {
            // Make sure we are within JobTimeFrame limits, hardcoded values here...
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
            // Validate the input of the radioButtons
            // Loop through all Controls in the form
            foreach (var control in Controls)
            {
                // Make sure it is of the type RadioButton
                if (control is RadioButton)
                {
                    var radioButton = (RadioButton)control;
                    if (radioButton.Checked)
                    {
                        DateTime dt = monthCalendar.SelectionStart;
                        string? tagString = radioButton.Tag.ToString();

                        // We have gotten an unknown RadioButton here, return
                        if (tagString == null)
                        {
                            return;
                        }

                        // Parse the Tag value to an int to represent which JobTimeFrame is selected
                        int time = Int32.Parse(tagString);
                        TimeSpan newTime = new TimeSpan(time, 0, 0);

                        dt = dt.Date + newTime;

                        // We use this form from 2 different Forms
                        // Figure out which form called us...
                        // Then call the SetBookingDate() method from that form
                        if (Owner is FormAddBooking)
                        {
                            FormAddBooking parent = (FormAddBooking)Owner;
                            parent.SetBookingDate(dt);
                        }
                        else if (Owner is FormEditBooking)
                        {
                            FormEditBooking parent = (FormEditBooking)Owner;
                            parent.SetBookingDate(dt);
                        }

                        // We are done here, close and return from the method.
                        Close();
                        return;
                    }
                }
            }

            // No time was selected, notify the user
            MessageBox.Show("Välj en tid som du vill boka!", "Schema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            RefreshRadioButtons();
        }
    }
}
