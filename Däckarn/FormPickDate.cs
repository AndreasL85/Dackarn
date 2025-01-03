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

            MessageBox.Show(dates.ToList().ToString());
        }

        private void buttonPick_Click(object sender, EventArgs e)
        {

        }
    }
}
