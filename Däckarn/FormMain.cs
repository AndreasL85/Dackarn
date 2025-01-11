using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.Text;
using DackarnAPI.DataTypes;
using DackarnAPI.Services;

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

            DateTime dateTime = DateTime.Now;
            TimeSpan ts = new TimeSpan(10, 0, 0);
            dateTime = dateTime.Date + ts;

            GlobalDataManager.BookingManager.AddNewBooking(dateTime, CustomerService.SummerToWinter, "Anders Andersson", false, "LOL333", "Volvo", "740", 1989);
            GlobalDataManager.UpdateSchedule(dateTime, false);
            UpdateBookings();
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

            foreach (var booking in GlobalDataManager.BookingManager.GetAllBookings())
            {
                if (booking.BookedDate.Date == DateTime.Today.Date)
                {
                    ListViewItem item = new ListViewItem(booking.BookedDate.ToString("HH:mm"));
                    item.SubItems.Add(booking.Done ? "Utförd" : "Ej Utförd");
                    item.SubItems.Add(booking.BookedCustomer.Name);
                    item.SubItems.Add(booking.BookedCustomer.PremiumCustomer ? "Ja" : "Nej");
                    item.SubItems.Add($"{booking.CustomerCar.RegistrationNumber.ToUpper()}");
                    item.SubItems.Add($"{booking.CustomerCar.Brand} {booking.CustomerCar.Model} ({booking.CustomerCar.Year})");
                    listViewBookings.Items.Add(item);
                }
            }
        }

        private void hanteraSchemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSchedule formSchedule = new FormSchedule();
            formSchedule.ShowDialog(this);
        }

        private void omToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog(this);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            var booking = GetSelectedBooking();

            if (booking != null)
            {
                booking.Done = true;
            }
        }

        private Booking? GetSelectedBooking()
        {
            if (listViewBookings.SelectedItems.Count > 0)
            {
                if (Int32.TryParse(listViewBookings.SelectedItems[0].Text.Substring(0, 2), out int hour))
                {
                    DateTime selectedDateTime = DateTime.Now;
                    TimeSpan timeSpan = new TimeSpan(hour, 0, 0);
                    selectedDateTime = selectedDateTime.Date + timeSpan;
                    return GlobalDataManager.BookingManager.GetBooking(selectedDateTime);
                }
            }

            return null;
        }

        private void taBortBokningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var booking = GetSelectedBooking();

            if (booking == null)
            {
                return;
            }

            if (MessageBox.Show($"Är du säker på att du vill ta bort {booking.BookedCustomer.Name}'s bokning?", "Ta bort bokning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                GlobalDataManager.UpdateSchedule(booking.BookedDate, true);
                GlobalDataManager.BookingManager.RemoveBooking(booking.ID);
                UpdateBookings();
            }
        }

        private void hanteraBokningarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditBooking formEdit = new FormEditBooking();
            formEdit.ShowDialog(this);
        }
    }
}