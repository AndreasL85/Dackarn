/*
 * Projektarbete i Objektorienterad programmering GIK299, HT24
 * 
 * Däckarn
 * 
 * Andreas Lindström
 * Ameer Abdelakhwa
 * 
 */
using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.Text;
using DackarnAPI.DataTypes;
using DackarnAPI.Services;

namespace Däckarn
{
    // Main form for the program
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit the program
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Update the current day so it is visible in the form
            UpdateCurrentDay();

            // Create a customer so we don't have to add a new customer each time we run the program to test functionallity
            DateTime dateTime = DateTime.Now;
            TimeSpan ts = new TimeSpan(10, 0, 0);
            dateTime = dateTime.Date + ts;

            // Add the customer
            GlobalDataManager.BookingManager.AddNewBooking(dateTime, CustomerService.SummerToWinter, "Anders Andersson", false, "BTG333", "Volvo", "740", 1989);
            // Update the schedule
            GlobalDataManager.UpdateSchedule(dateTime, false);
            // Update the listView of bookings
            UpdateBookings();
        }

        private void läggTillBokningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the AddBooking Form
            FormAddBooking form = new FormAddBooking();
            form.ShowDialog(this);
        }

        // Method to display the date in a specific way
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

        // Method to update the listViewBookings
        public void UpdateBookings()
        {
            // Clear the list
            listViewBookings.Items.Clear();

            // Loop through each booking we have and add it to the listview
            foreach (var booking in GlobalDataManager.BookingManager.GetAllBookings())
            {
                if (booking.BookedDate.Date == DateTime.Today.Date)
                {
                    ListViewItem item = new ListViewItem(booking.BookedDate.ToString("HH:mm"));
                    item.SubItems.Add(booking.Done ? "Utförd" : "Ej Utförd");
                    item.SubItems.Add(booking.BookedCustomer.Name);
                    item.SubItems.Add(booking.BookedCustomer.PremiumCustomer ? "Ja" : "Nej");
                    item.SubItems.Add(booking.BookedCustomer.GetCustomerServiceString());
                    item.SubItems.Add($"{booking.CustomerCar.RegistrationNumber.ToUpper()}");
                    item.SubItems.Add($"{booking.CustomerCar.Brand} {booking.CustomerCar.Model} ({booking.CustomerCar.Year})");
                    listViewBookings.Items.Add(item);
                }
            }
        }

        private void hanteraSchemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the Schedule Form
            FormSchedule formSchedule = new FormSchedule();
            formSchedule.ShowDialog(this);
        }

        private void omToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the About Form
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog(this);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            // Update the selected booking to know that it has been done
            var booking = GetSelectedBooking();

            if (booking != null)
            {
                booking.Done = true;
            }
            UpdateBookings();
        }

        // Helper method to return the selected Booking from the listview control
        private Booking? GetSelectedBooking()
        {
            if (listViewBookings.SelectedItems.Count > 0)
            {
                // Get the hour of the selected item
                if (Int32.TryParse(listViewBookings.SelectedItems[0].Text.Substring(0, 2), out int hour))
                {
                    // Parse it to a valid datetime object for today and the current time
                    DateTime selectedDateTime = DateTime.Now;
                    TimeSpan timeSpan = new TimeSpan(hour, 0, 0);
                    selectedDateTime = selectedDateTime.Date + timeSpan;
                    // return the booking with the selected date and time
                    return GlobalDataManager.BookingManager.GetBooking(selectedDateTime);
                }
            }

            // No booking where found
            return null;
        }

        // Remove booking
        private void taBortBokningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get the selected booking object
            var booking = GetSelectedBooking();

            if (booking == null)
            {
                return;
            }

            // Show a confirmation box, to make sure you want to remove the booking
            if (MessageBox.Show($"Är du säker på att du vill ta bort {booking.BookedCustomer.Name}'s bokning?", "Ta bort bokning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Set the schedule JobTimeFrame to available, because it is being removed.
                GlobalDataManager.UpdateSchedule(booking.BookedDate, true);
                // Remove the actual booking from the system
                GlobalDataManager.BookingManager.RemoveBooking(booking.ID);
                // Update the bookings list for the day
                UpdateBookings();
            }
        }

        private void hanteraBokningarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the EditBooking Form
            FormEditBooking formEdit = new FormEditBooking();
            formEdit.ShowDialog(this);
        }
    }
}