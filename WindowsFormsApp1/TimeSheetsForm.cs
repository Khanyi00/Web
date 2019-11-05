using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TimeSheetsForm : Form
    {
        public TimeSheetsForm()
        {
            InitializeComponent();
            BindMonths();
            BindYears();
        }

        private void BindMonths()
        {
            var months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames;
            _monthComboBox.DataSource = months;
        }

        private void BindYears()
        {
            var currentYear = DateTime.Today.Year;

            for (int i = 3; i >= 0; i--)
            {
                _yearComboBox.Items.Add((currentYear - i).ToString());
            }
        }

        private void btnHoursPerPerson_Click(object sender, EventArgs e)
        {
            var year = _yearComboBox.Text;
            var month = _monthComboBox.Text;

            if ( year == "" || month == "")
            {
                MessageBox.Show("Enter Date.");
                return;
            }

            DateTime date = DateTime.Parse($"{year}-{month}");
            _timeSheetsGrid.DataSource = DataDB.GetTotalHoursPerPerson(date);
        }

        private void btnHoursPerProject_Click(object sender, EventArgs e)
        {
            var year = _yearComboBox.Text;
            var month = _monthComboBox.Text;
            if ( year == "" || month == "")
            {
                MessageBox.Show("Enter Date.");
                return;
            }
            DateTime date = DateTime.Parse($"{year}-{month}");
            _timeSheetsGrid.DataSource = DataDB.GetTotalHoursPerProject(date);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            var userName = _txtUserName.Text;

            if (userName == "")
            {
                MessageBox.Show("Enter UserName.");
                return;
            }

            _timeSheetsGrid.DataSource = DataDB.GetUsers(userName);
        }

        private void btnTimeslots_Click(object sender, EventArgs e)
        {
            var userName = _txtUserName.Text;
            var year = _yearComboBox.Text;
            var month = _monthComboBox.Text;

            if (userName == "" || year == "" || month == "")
            {
                MessageBox.Show("Enter UserName or Date.");
                return;
            }

            DateTime date = DateTime.Parse($"{year}-{month}");
            _timeSheetsGrid.DataSource = DataDB.GetFullTimeSlots(userName, date);
        }
    }
}
