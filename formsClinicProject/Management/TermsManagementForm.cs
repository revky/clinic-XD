using formsClinicProject.DataAccess;
using formsClinicProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsClinicProject.Management
{
    public partial class TermsManagementForm : Form
    {
        public TermsManagementForm()
        {
            InitializeComponent();

        }

        List<Calendar> calendars = CalendarDataAccess.AllCalendars();
        List<Employee> doctors = EmployeeDataAccess.GetEmployeeDataBasedOnRole(10);
        

        //załadowanie formatki
        private void TermsManagementForm_Load(object sender, EventArgs e)
        {   
            //dla każdego doktora w liście wszystkich doktorów (employee z id_role 10) uzupełnia combobox imieniem i nazwiskiem
            doctors.ForEach(x => comboBoxEmployee.Items.Add($"{x.First_name} {x.Last_name}"));
            
            //Uzupełnia combobox miesiącem i rokiem w odpowiednim formacie
            calendars.ForEach(x => comboBoxCalendar.Items.Add($"{x.Month}/{x.Year}"));

            List<Term> terminy = CalendarDataAccess.TermsForOneEmployee(12, 8, new DateTime(2021, 5, 27));
        }

        //combobox od wybierania kalendarzy
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewTerms.Rows.Clear();

            //jeżeli jest wybrany jakiś kalendarz to pokazuje się monthCalendar 
            //który jest zablokowany odrazu na date danego kalendarza
            if (comboBoxCalendar.SelectedIndex < 0)
                monthCalendar.Visible = false;
            else
            {
                monthCalendar.Visible = true;
                refreshData();
            }

            //typuje wybrany w combobox kalendarz
            //mają one te same indexy więc na łatwiutko można pobrać index z combobox i odpowiada mu index w liście
            Calendar selectedCalendar = calendars[comboBoxCalendar.SelectedIndex];

            DateTime min = new DateTime(selectedCalendar.Year, selectedCalendar.Month, 1);
            DateTime max = new DateTime(selectedCalendar.Year, selectedCalendar.Month, DateTime.DaysInMonth(selectedCalendar.Year, selectedCalendar.Month));

            monthCalendar.MinDate = new DateTime (1900, 1, 1);
            monthCalendar.MaxDate = new DateTime(2200, 1, 1);

            monthCalendar.MinDate = min;
            monthCalendar.MaxDate = max;
        }

        //zmiana indexu combobox w którym wybieramy pracownika
        private void comboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            //czyści datagridview aby przy zmiane pracownika nie pokazywalo terminów dla poprzedniego
            dataGridViewTerms.Rows.Clear();

            //pokazuje combobox wyboru kalendarza jeżeli wybrany jest jakikolwiek pracownik
            //drugi warunek służy do tego aby odświeżały sie dane w przypadku gdy zmieniamy pracownika
            //podczas gdy kalendarz był już wcześniej wybrany
            if (comboBoxEmployee.SelectedIndex < 0)
            {
                comboBoxCalendar.Visible = false;
                labelCalendar.Visible = false;
            }
            else if (comboBoxEmployee.SelectedIndex > -1 && comboBoxCalendar.SelectedIndex > -1)
            {
                refreshData();
            }
            else
            {
                comboBoxCalendar.Visible = true;
                labelCalendar.Visible = true;
            }
        }

        //zmiana wybranej daty w kalendarzu powoduje odświeżenie informacji o terminach
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            refreshData();
        }

        //funkcja która ładuje dane do datagridview
        //pobiera kolejno date i wszystkie potrzebne id z list doktorów, kalendarzy
        void refreshData()
        {
            dataGridViewTerms.Rows.Clear();

            //pobranie terminów
            List<Term> terminy = CalendarDataAccess.TermsForOneEmployee(doctors[comboBoxEmployee.SelectedIndex].Id_employee, calendars[comboBoxCalendar.SelectedIndex].Id_calendar, monthCalendar.SelectionStart.Date);

            //LAMBDAAAAAAAAAAAAAAAAAAAAA
            //załadowanie listy terminów do datagridview
            //i przy okazji uzupełnienie minut 0 o dodatkowe 0 (w bazie przechowywane są int więc stąd konieczność dodania)
            terminy.ForEach(x =>
            {
                if (x.Start_time_minute == "0")
                    x.Start_time_minute = "00";
                dataGridViewTerms.Rows.Add($"{x.date.ToShortDateString()}", $"{x.Start_time_hour}:{x.Start_time_minute}", $"{x.Number}");
            });

            //wybranie odpowiednich komponentów formatki
            //jeżeli nie ma żadnych terminów to formatka przystosowuje się do dodania terminów
            //jezeli terminy są to formatka przystosowuje się do usunięcia terminów
            if (terminy.Count == 0)
                prepareFormToCreate();
            else
                prepareFormToDelete();
        }

        //Przygotowanie formatki do dodawania nowych terminów
        void prepareFormToCreate()
        {
            //pokazuje elementy konieczne do dodania terminu
            numericUpDownStartHour.Visible = true;
            numericUpDownEndHour.Visible = true;
            buttonConfirm.Visible = true;
            comboBoxCabinets.Visible = true;
            labelStartHour.Visible = true;
            labelFinalHour.Visible = true;
            label1.Visible = true;

            //ukrycie komponentów do usuwania terminów
            buttonDelete.Visible = false;

            //czyszczenie combobox gabinetów
            //oraz uzupełnienie go numerami gabinetów
            //TO DO: użycie funkcji która zwraca wolne danego dnia gabinety 
            comboBoxCabinets.Items.Clear();
            comboBoxCabinets.SelectedIndex = -1;

            List<Cabinet> cabinets = CabinetDataAccess.ListOfAvalibleCabinets(monthCalendar.SelectionStart);

            cabinets.ForEach(x => comboBoxCabinets.Items.Add(x.Number));

            //string[] startHourString = maskedTextBoxStartHour.Text.Split(':');
            //string[] endHourString = maskedTextBoxStartHour.Text.Split(':');
        }

        //Przygotowanie formatki do usuwania terminów
        void prepareFormToDelete()
        {
            //ukrycie komponentów do dodawania terminów
            numericUpDownStartHour.Visible = false;
            numericUpDownEndHour.Visible = false;
            buttonConfirm.Visible = false;
            comboBoxCabinets.Visible = false;
            label1.Visible = false;
            labelStartHour.Visible = false;
            labelFinalHour.Visible = false;
            buttonDelete.Visible = true;
        }

        //button dodający terminy
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //warunek czy godzina startu jest na pewno mniejsza niż końca
            if (numericUpDownStartHour.Value >= numericUpDownEndHour.Value)
            {
                MessageBox.Show("Start hour can't be bigger or equal to end hour.");
                return;
            }

            //warunek czy wybrano gabinet
            if(comboBoxCabinets.SelectedIndex < 0)
            {
                MessageBox.Show("Choose cabinet.");
                return;
            }

            try
            {
                //funkcja dodania termów do kalendarza
                //odwołuje się do procedury przechowywanej bazy która dodaje 20 minutowe termy
                List<Cabinet> cabinets = CabinetDataAccess.ListOfAvalibleCabinets(monthCalendar.SelectionStart);

                CalendarDataAccess.CreateTerms(monthCalendar.SelectionStart, (int)numericUpDownStartHour.Value, (int)numericUpDownEndHour.Value, doctors[comboBoxEmployee.SelectedIndex].Id_employee, cabinets[comboBoxCabinets.SelectedIndex].Id, calendars[comboBoxCalendar.SelectedIndex].Id_calendar);
                //odświeżenie danych 
                refreshData();
                MessageBox.Show("New day of work added succesfully.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        //button usuwający terminy
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show($"Do you want to remove day of work for {monthCalendar.SelectionStart.ToString("dd-MM-yyyy")}?", "Removing day of work", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    //usunięcie terminów dla wybranego dnia
                    CalendarDataAccess.DeleteTerms(monthCalendar.SelectionStart, doctors[comboBoxEmployee.SelectedIndex].Id_employee);
                    MessageBox.Show("Day of work has been removed.");
                    refreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
