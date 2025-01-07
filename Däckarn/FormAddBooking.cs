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
            FillYears();
        }

        private void FillYears()
        {
            for (int i = 1930; i <= DateTime.Now.Year; i++)
            {
                comboBoxYear.Items.Add(i.ToString());
            }

            comboBoxYear.SelectedIndex = comboBoxYear.Items.Count - 1;
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

        private void buttonBoka_Click(object sender, EventArgs e)
        {
            if(ValidateBooking())
            {
                // We should have valid inputs here, create a new booking
                GlobalDataManager.BookingManager.AddNewBooking(textBoxName.Text, chkPremium.Checked, textBoxRegNr.Text, textBoxBrand.Text, textBoxModel.Text, Int32.Parse(comboBoxYear.SelectedItem.ToString()));
                FormMain form = (FormMain)Owner;
                form.UpdateBookings();
                Close();
            }
        }

        // Make sure all input fields have the correct data
        private bool ValidateBooking()
        {
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

        private bool  ValidateTextBox(TextBox textBox, int minLength = 2)
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

                if(!ValidateRegNr(textBox.Text))
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

                if(textBox.Text.Any(char.IsDigit))
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

        private void Error(string message)
        {
            MessageBox.Show(message, "Fel!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
