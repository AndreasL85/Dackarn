/*
 * Projektarbete i Objektorienterad programmering GIK299, HT24
 * 
 * Däckarn
 * 
 * Andreas Lindström
 * Ameer Abdelakhwa
 * 
 */
using DackarnAPI.DataTypes;
using DackarnAPI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Däckarn
{
    public partial class FormEditBooking : Form
    {
        private DateTime bookedDate;
        public FormEditBooking()
        {
            InitializeComponent();
        }

        // Update booked date
        private void UpdateDate(DateTime newDate)
        {
            bookedDate = newDate;

        }

        // Fill in the input fields in the form
        public void FillInForm(Booking? booking)
        {
            // If booking is null, clear the fields and set values to the default
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
                // Else fill in the fields with the booking information
                textBoxName.Text = booking.BookedCustomer.Name;
                chkPremium.Checked = booking.BookedCustomer.PremiumCustomer ? true : false;
                textBoxRegNr.Text = booking.CustomerCar.RegistrationNumber;
                textBoxBrand.Text = booking.CustomerCar.Brand;
                textBoxModel.Text = booking.CustomerCar.Model;
                comboBoxYear.Text = booking.CustomerCar.Year.ToString();
                comboBoxService.SelectedIndex = (int)booking.BookedCustomer.Service;
                // Set the booking date
                SetBookingDate(booking.BookedDate);
            }
        }

        // Sets the booking date
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
            UpdateDate(date);
        }

        // Fill in the years 1930 up to the current year in the comboBoxYear
        private void FillYears()
        {
            for (int i = 1930; i <= DateTime.Now.Year; i++)
            {
                comboBoxYear.Items.Add(i.ToString());
            }

            comboBoxYear.SelectedIndex = comboBoxYear.Items.Count - 1;
        }

        // Update the listview with bookings and available JobTimeFrames
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

        // Helper method to get the selected booking from the listview
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
            // Update necessary fields in the forms
            FillYears();
            UpdateBookings();
        }

        private void listViewBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the inputfields on the form with the selected items booking information, if any
            FillInForm(GetSelectedBooking());
        }

        private void buttonPickDate_Click(object sender, EventArgs e)
        {
            FormPickDate formPickDate = new FormPickDate();
            formPickDate.ShowDialog(this);

        }

        private void buttonUpdateBooking_Click(object sender, EventArgs e)
        {
            // Validate input for the booking
            if (ValidateBooking())
            {
                var booking = GetSelectedBooking();

                // Make sure we got a booking selected
                if (booking == null)
                {
                    MessageBox.Show("Kunde inte uppdatera bokningen!\nMarkera bokningen och försök igen.", "Fel!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int year;
                if (!Int32.TryParse(comboBoxYear.SelectedItem.ToString(), out year))
                {
                    Error("Årtal var felaktigt ifyllt!");
                    return;
                }

                // Update the old booking and set it to available, in case we changed the date
                GlobalDataManager.UpdateSchedule(booking.BookedDate, true);
                // Edit the booking with the new information
                GlobalDataManager.BookingManager.EditBooking(booking.ID, bookedDate, (CustomerService)comboBoxService.SelectedIndex, textBoxName.Text, chkPremium.Checked, textBoxRegNr.Text, textBoxBrand.Text, textBoxModel.Text, year);
                // Make the new edited booking unavailable for booking
                GlobalDataManager.UpdateSchedule(bookedDate, false);
                UpdateBookings();
                // Notify the user that the booking has been updated
                MessageBox.Show("Bokning uppdaterad!", "Bokning uppdaterad!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear the input fields
                FillInForm(null);
            }
        }
        // These validation methods are the exact same as those in FormAddBooking
        private bool ValidateBooking()
        {
            if (!ValidateTextBox(textBoxName))
            {
                return false;
            }

            if (!ValidateTextBox(textBoxRegNr, 6))
            {
                return false;
            }

            if (!ValidateTextBox(textBoxBrand))
            {
                return false;
            }

            if (!ValidateTextBox(textBoxModel))
            {
                return false;
            }

            return true;
        }

        private bool ValidateTextBox(TextBox textBox, int minLength = 2)
        {
            string? fieldName = textBox.Tag.ToString();

            if (textBox.Text == string.Empty)
            {
                Error($"Fyll i fältet {fieldName}!");
                return false;
            }

            if (textBox.Tag.ToString() == "Registreringsnummer")
            {
                if (textBox.Text.Length != 6)
                {
                    Error($"{fieldName} måste vara {minLength} bokstäver!");
                    return false;
                }

                if (!ValidateRegNr(textBox.Text))
                {
                    Error($"{fieldName} måste vara ett giltigt registreringsnummer!");
                    return false;
                }
            }
            else if (textBox.Tag.ToString() == "Namn")
            {
                if (textBox.Text.Length < minLength)
                {
                    Error($"{fieldName} måste vara längre än {minLength} bokstäver!");
                    return false;
                }

                if (textBox.Text.Any(char.IsDigit))
                {
                    Error($"{fieldName} får inte innehålla siffror!");
                    return false;
                }
            }
            else
            {
                if (textBox.Text.Length < minLength)
                {
                    Error($"{fieldName} måste vara längre än {minLength} bokstäver!");
                    return false;
                }
            }

            return true;
        }

        // Regulare Expression for Registration Number
        private bool ValidateRegNr(String regNr)
        {
            bool isValid = false;

            // Patterns to match
            // ------------------
            // standard = ABC123
            // newer    = ABC12A
            //
            Regex standard = new Regex("^[A-Za-z][A-Za-z][A-Za-z]\\d\\d\\d$", RegexOptions.IgnoreCase);
            Regex newer = new Regex("^[A-Za-z][A-Za-z][A-Za-z]\\d\\d[A-Za-z]$", RegexOptions.IgnoreCase);

            // If standard or newer match the pattern, set isValid to true
            if (standard.IsMatch(regNr) || newer.IsMatch(regNr))
            {
                isValid = true;
            }

            return isValid;
        }

        // Helper method to display error messages to the user
        private void Error(string message)
        {
            MessageBox.Show(message, "Fel!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormEditBooking_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain formMain = (FormMain)Owner;
            formMain.UpdateBookings();
        }

        private void buttonRemoveBooking_Click(object sender, EventArgs e)
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
    }
}
