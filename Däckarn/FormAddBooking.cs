/*
 * Projektarbete i Objektorienterad programmering GIK299, HT24
 * 
 * Däckarn
 * 
 * Andreas Lindström
 * Ameer Abdelakhwa
 * 
 */
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
using DackarnAPI.Services;
using DackarnAPI.DataTypes;

namespace Däckarn
{
    public partial class FormAddBooking : Form
    {
        // Declare a DateTime object to keep track of the bookedDate
        private DateTime bookedDate = DateTime.Now;
        public FormAddBooking()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Close the Form
            Close();
        }

        private void buttonPickDate_Click(object sender, EventArgs e)
        {
            // Show the PickDate Form
            FormPickDate formPickDate = new FormPickDate();
            formPickDate.ShowDialog(this);
        }

        private void FormAddBooking_Load(object sender, EventArgs e)
        {
            // Update the ComboBoxes 
            FillYears();
            comboBoxService.SelectedIndex = 0;
        }

        // Fill in the years from 1930 up to Current Date to the comboBoxYear
        private void FillYears()
        {
            for (int i = 1930; i <= DateTime.Now.Year; i++)
            {
                comboBoxYear.Items.Add(i.ToString());
            }

            comboBoxYear.SelectedIndex = comboBoxYear.Items.Count - 1;
        }

        // Method to set a booking date, this is called to transer data from another form
        public void SetBookingDate(DateTime date)
        {
            // Configure the output data of the date
            CultureInfo culture = CultureInfo.CurrentCulture;
            string dayOfWeek = date.ToString("dddd", culture);
            dayOfWeek = dayOfWeek[0].ToString().ToUpper() + dayOfWeek.Substring(1);
            string day = date.Day.ToString();
            string month = date.ToString("MMMM");
            month = month[0].ToString().ToUpper() + month.Substring(1);
            string year = date.Year.ToString();
            // Update the label with the data
            labelBookingDate.Text = $"{dayOfWeek}, den {day} {month} {year} Kl: {date.Hour}:{date.ToString("mm")}";
            // Set the bookedDate to the date specified
            bookedDate = date;
        }

        private void buttonBoka_Click(object sender, EventArgs e)
        {
            // Check if all input components are filled in correctly
            if(ValidateBooking())
            {
                // We should have valid inputs here, create a new booking
                // Extract the selected year from comboBoxYear
                int year;
                if(!Int32.TryParse(comboBoxYear.SelectedItem.ToString(), out year))
                {
                    Error("Årtal var felaktigt ifyllt!");
                    return;
                }

                // Add a new booking with the formular data
                GlobalDataManager.BookingManager.AddNewBooking(bookedDate, (CustomerService)comboBoxService.SelectedIndex, textBoxName.Text, chkPremium.Checked, textBoxRegNr.Text, textBoxBrand.Text, textBoxModel.Text, year);
                // Update the schedule and make the current JobTimeFrame not available
                GlobalDataManager.UpdateSchedule(bookedDate, false);
                string premium = chkPremium.Checked ? "Ja" : "Nej";
                // Show a confirmation box that the booking went through
                MessageBox.Show($"Bokning genomförd!\n\nNamn: {textBoxName.Text}\nPremium Medlem: {premium}\nReg. Nr: {textBoxRegNr.Text}\nBil: {textBoxBrand.Text} {textBoxModel.Text} ({year})", "Ny Bokning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Update Bookings in the Main Form, in case we have made a booking today
                FormMain form = (FormMain)Owner;
                form.UpdateBookings();
                Close();
            }
        }

        // Make sure all input fields have the correct data
        private bool ValidateBooking()
        {
            // If any Textbox has invalid input, return false
            // We don't want to continue if an invalid input was given.
            if(!ValidateTextBox(textBoxName))
            {
                return false;
            }

            if(!ValidateTextBox(textBoxRegNr, 6))
            {
                return false;
            }

            if(!ValidateTextBox(textBoxBrand))
            {
                return false;
            }

            if(!ValidateTextBox(textBoxModel))
            {
                return false;
            }

            return true;
        }

        // Helper method to validate a textbox with certain inputs
        private bool  ValidateTextBox(TextBox textBox, int minLength = 2)
        {
            // Grab the Tag value as string, to see which textBox we are working with
            string? fieldName = textBox.Tag.ToString();
            
            // Trim away any leading or ending whitespaces
            textBox.Text = textBox.Text.Trim();

            // First check that we have some input in the textbox
            if (textBox.Text == string.Empty)
            {
                Error($"Fyll i fältet {fieldName}!");
                return false;
            }

            // If we are in Registreringsnummer
            if (textBox.Tag.ToString() == "Registreringsnummer")
            {
                // Make sure that the length is 6 characters long
                if (textBox.Text.Length != 6)
                {
                    Error($"{fieldName} måste vara {minLength} bokstäver!");
                    return false;
                }

                // Validate the input to be a somewhat accurate registration number
                if(!ValidateRegNr(textBox.Text))
                {
                    Error($"{fieldName} måste vara ett giltigt registreringsnummer!");
                    return false;
                }
            }
            // if namn
            else if (textBox.Tag.ToString() == "Namn")
            {
                // Make sure the length is atleast minLength long
                if (textBox.Text.Length < minLength)
                {
                    Error($"{fieldName} måste vara längre än {minLength} bokstäver!");
                    return false;
                }

                // Make sure there are no digits in the name
                if(textBox.Text.Any(char.IsDigit))
                {
                    Error($"{fieldName} får inte innehålla siffror!");
                    return false;
                }

                // NOTE: We are aware of a problem where there it is possible to have multiple whitespaces
                // this was noted a bit late and due to time constrains etc, we let it be ok for this project.
            }
            else
            {
                // Any other textbox, we just make sure that there is some data in it
                if (textBox.Text.Length < minLength)
                {
                    Error($"{fieldName} måste vara längre än {minLength} bokstäver!");
                    return false;
                }
            }

            return true;
        }

        // Regulare Expression for Swedish Registration Number
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

        // Helper method to display an error where there is invalid input
        private void Error(string message)
        {
            MessageBox.Show(message, "Fel!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
