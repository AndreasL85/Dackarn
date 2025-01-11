using DackarnAPI.Services;
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
    public partial class FormEditBooking : Form
    {
        public FormEditBooking()
        {
            InitializeComponent();
        }

        public void FillInForm(Booking booking)
        {
            if (booking == null)
            {
                textBoxName.Text = string.Empty;
                chkPremium.Checked = false;
                textBoxRegNr.Text = string.Empty;
                textBoxBrand.Text = string.Empty;
                textBoxModel.Text = string.Empty;
                comboBoxService.SelectedIndex = 0;
                comboBoxYear.SelectedIndex = comboBoxYear.Items.Count - 1;
            }
            else
            {
                textBoxName.Text = booking.BookedCustomer.Name;
                chkPremium.Checked = booking.BookedCustomer.PremiumCustomer ? true : false;
                textBoxRegNr.Text = booking.CustomerCar.RegistrationNumber;
                textBoxBrand.Text = booking.CustomerCar.Brand;
                textBoxModel.Text = booking.CustomerCar.Model;
                comboBoxYear.Text = booking.CustomerCar.Year.ToString();
                comboBoxService.SelectedIndex = (int)booking.BookedCustomer.Service;
                SetBookingDate(booking.BookedDate);
            }
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

        private void FillYears()
        {
            for (int i = 1930; i <= DateTime.Now.Year; i++)
            {
                comboBoxYear.Items.Add(i.ToString());
            }

            comboBoxYear.SelectedIndex = comboBoxYear.Items.Count - 1;
        }

        public void UpdateBookings()
        {
            listViewBookings.Items.Clear();

            if (GlobalDataManager.WorkSchedule == null)
            {
                return;
            }

            foreach (var jobFrame in GlobalDataManager.WorkSchedule.GetAllJobTimeFrames())
            {
                if (jobFrame.Available)
                {
                    ListViewItem item = new ListViewItem(jobFrame.Time.ToString("yyyy/MM/dd HH:mm"));
                    listViewBookings.Items.Add(item);
                }
                else
                {
                    var booking = GlobalDataManager.BookingManager.GetBooking(jobFrame.Time);

                    if (booking == null)
                    {
                        throw new Exception("Critical Error! Corrupt booking data!");
                    }

                    ListViewItem item = new ListViewItem(booking.BookedDate.ToString("yyyy/MM/dd HH:mm"));
                    item.SubItems.Add(booking.Done ? "Utförd" : "Ej Utförd");
                    item.SubItems.Add(booking.BookedCustomer.Name);
                    item.SubItems.Add(booking.BookedCustomer.PremiumCustomer ? "Ja" : "Nej");
                    item.SubItems.Add($"{booking.CustomerCar.RegistrationNumber.ToUpper()}");
                    item.SubItems.Add($"{booking.CustomerCar.Brand} {booking.CustomerCar.Model} ({booking.CustomerCar.Year})");
                    listViewBookings.Items.Add(item);
                }
            }
        }

        private Booking? GetSelectedBooking()
        {
            if (listViewBookings.SelectedItems.Count > 0)
            {
                if (DateTime.TryParse(listViewBookings.SelectedItems[0].Text, out var bookingDate))
                {
                    return GlobalDataManager.BookingManager.GetBooking(bookingDate);
                }
            }

            return null;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormEditBooking_Load(object sender, EventArgs e)
        {
            FillYears();
            UpdateBookings();
        }

        private void listViewBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillInForm(GetSelectedBooking()!);
        }
    }
}
