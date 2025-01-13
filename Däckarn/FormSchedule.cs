/*
 * Projektarbete i Objektorienterad programmering GIK299, HT24
 * 
 * Däckarn
 * 
 * Andreas Lindström
 * Ameer Abdelakhwa
 * 
 */
using DackarnAPI.Services;
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
    public partial class FormSchedule : Form
    {
        public FormSchedule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSchedule_Load(object sender, EventArgs e)
        {
            UpdateBookings();
        }

        public void UpdateBookings()
        {
            listViewBookings.Items.Clear();

            if (GlobalDataManager.WorkSchedule == null)
            {
                return;
            }

            // Loop through each JobTimeFrame
            foreach (var jobFrame in GlobalDataManager.WorkSchedule.GetAllJobTimeFrames())
            {
                // If available, this means that we have no booking here
                // Only display the JobTimeFrame with it's Date and Time
                if (jobFrame.Available)
                {
                    ListViewItem item = new ListViewItem(jobFrame.Time.ToString("yyyy/MM/dd HH:mm"));
                    listViewBookings.Items.Add(item);
                }
                else
                {
                    // If it's not available, there is a booking, get the booking for the specific JobTimeFrame
                    var booking = GlobalDataManager.BookingManager.GetBooking(jobFrame.Time);

                    if (booking == null)
                    {
                        // This should never happen, but it happend one time during development
                        // So we keep it just to guard for eventual bugs.
                        throw new Exception("Critical Error! Corrupt booking data!");
                    }

                    // Add a ListViewItem to the list with the booking information
                    ListViewItem item = new ListViewItem(booking.BookedDate.ToString("yyyy/MM/dd HH:mm"));
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
    }
}
