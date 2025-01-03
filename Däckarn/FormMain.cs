using System.Globalization;
using System.Text;
using DackarnAPI.DataTypes;

namespace Däckarn
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            UpdateCurrentDay();
        }

        private void läggTillBokningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddBooking form = new FormAddBooking();
            form.ShowDialog(this);
        }

        private void UpdateCurrentDay()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string dayOfWeek = DateTime.Now.ToString("dddd", culture);
            dayOfWeek = dayOfWeek[0].ToString().ToUpper() + dayOfWeek.Substring(1);
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.ToString("MMMM");
            month = month[0].ToString().ToUpper() + month.Substring(1);
            string year = DateTime.Now.Year.ToString();
            lblDay.Text = $"{dayOfWeek}, {day} {month} {year}";
        }

        private void hanteraSchemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPickDate formPickDate = new FormPickDate();
            formPickDate.ShowDialog(this);
        }
    }
}