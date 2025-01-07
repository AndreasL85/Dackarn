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

        public void UpdateBookings()
        {
            listViewBookings.Items.Clear();

            foreach (var b in GlobalDataManager.BookingManager.GetAllBookings())
            {
                ListViewItem item = new ListViewItem(b.Done ? "Utförd" : "Ej Utförd");
                item.SubItems.Add(b.BookedCustomer.Name);
                item.SubItems.Add(b.BookedCustomer.PremiumCustomer ? "Ja" : "Nej");
                item.SubItems.Add($"{b.CustomerCar.RegistrationNumber.ToUpper()}");
                item.SubItems.Add($"{b.CustomerCar.Brand} {b.CustomerCar.Model} ({b.CustomerCar.Year})");
                listViewBookings.Items.Add(item);
            }
        }

        private void hanteraSchemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPickDate formPickDate = new FormPickDate();
            formPickDate.ShowDialog(this);
        }

        private void omToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog(this);
        }
    }
}