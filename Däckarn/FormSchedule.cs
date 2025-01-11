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
            if (GlobalDataManager.WorkSchedule == null)
            {
                return;
            }

            listViewBookings.Items.Clear();

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
    }
}
