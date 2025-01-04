using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Däckarn
{
    public partial class FormAddBooking : Form
    {
        public FormAddBooking()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPickDate_Click(object sender, EventArgs e)
        {
            FormPickDate formPickDate = new FormPickDate();
            formPickDate.ShowDialog(this);
        }

        private void FormAddBooking_Load(object sender, EventArgs e)
        {

        }

        public void SetBookingDate(DateTime date)
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string dayOfWeek = date.ToString("dddd", culture);
            dayOfWeek = dayOfWeek[0].ToString().ToUpper() + dayOfWeek.Substring(1);
            string day = date.Day.ToString();
            string month = date.ToString("MMMM");
            month = month[0].ToString().ToUpper() + month.Substring(1);
            string year = date.Year.ToString();
            labelBookingDate.Text = $"{dayOfWeek}, den {day} {month} {year} Kl: {date.Hour}:{date.ToString("mm")}";
        }


    }
}
