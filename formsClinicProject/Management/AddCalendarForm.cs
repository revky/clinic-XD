using formsClinicProject.DataAccess;
using formsClinicProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsClinicProject.Management
{
    public partial class AddCalendarForm : Form
    {
        public AddCalendarForm()
        {
            InitializeComponent();

            dateTimePickerSelectMonthAndYear.Format = DateTimePickerFormat.Custom;
            dateTimePickerSelectMonthAndYear.CustomFormat = "MM/yyyy";

            refreshData();

        }

        List<Calendar> calendars = CalendarDataAccess.AllCalendars();

        //Uzupełnia datagridview kalendarzami
        void refreshData()
        {
            calendars = CalendarDataAccess.AllCalendars();

            dataGridViewCalendars.Rows.Clear();

            calendars.ForEach(x =>           
            {
                if (x.Month < 10)
                    dataGridViewCalendars.Rows.Add($"0{x.Month}", $"{x.Year}", $"{x.Status}");
                else
                    dataGridViewCalendars.Rows.Add($"{x.Month}", $"{x.Year}", $"{x.Status}");
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CalendarDataAccess.CreateCalendar(dateTimePickerSelectMonthAndYear.Value);
                refreshData();
                MessageBox.Show("New calendar added succesfully.");

                User objectToSendEmail = new User();

                try
                {
                    foreach (Employee doctor in EmployeeDataAccess.GetEmployeeDataBasedOnRole(10))
                    {
                        objectToSendEmail.SendEmailToUser(doctor.Email, "New calendar has been created.", $"Administrator has created a new calendar for {dateTimePickerSelectMonthAndYear.Value.ToString("yyyy-MM")}");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Podany kalendarz już istnieje w bazie danych");
            }
        }

        private void dataGridViewCalendars_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCalendars.SelectedRows.Count == 1)
                buttonDelete.Visible = true;
            else
                buttonDelete.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int calendarId = calendars[dataGridViewCalendars.SelectedRows[0].Index].Id_calendar;

                if (CalendarDataAccess.CheckIfCalendarHasTerms(calendarId))
                    MessageBox.Show("Cannot delete calendar with planned terms.");
                else
                {
                    var result = MessageBox.Show($"Do you want to delete calendar for {dataGridViewCalendars.SelectedRows[0].Cells[0].Value}-{dataGridViewCalendars.SelectedRows[0].Cells[1].Value}?", "Removing calendar", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        CalendarDataAccess.DeleteCalendar(calendarId);

                        MessageBox.Show("Calendar has been removed.");

                        User objectToSendEmail = new User();

                        foreach (Employee doctor in EmployeeDataAccess.GetEmployeeDataBasedOnRole(10))
                        {
                            objectToSendEmail.SendEmailToUser(doctor.Email, "New calendar has been created.", $"Administrator has deleted calendar for {dateTimePickerSelectMonthAndYear.Value.ToString("MM-yyyy")}");
                        }

                        refreshData();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            refreshData();
        }
    }
}
