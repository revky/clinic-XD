using System;
using System.Windows.Forms;
using formsClinicProject.DataAccess;

namespace formsClinicProject
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            label7.Visible = false;
            comboBoxSpecialty.Visible = false;
            comboBoxRole.DataSource = EmployeeDataAccess.ListOfRoles();
            comboBoxSpecialty.DataSource = EmployeeDataAccess.ListOfSpecialities();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Dodawanie pracownika do bazy danych
            try
            {
                try
                {
                    Employee employee = new Employee(txtboxFirstName.Text, txtboxLastName.Text, txtboxPhoneNumber.Text, txtboxMobile.Text, txtboxEmailAddres.Text, comboBoxSpecialty.SelectedItem == null ? null : comboBoxSpecialty.SelectedItem.ToString(), comboBoxRole.SelectedItem.ToString(), dateTimePicker1.Value);
                    EmployeeDataAccess.InputEmployee(employee);
                    MessageBox.Show("Employee added.");
                    AddUserForm addUserForm = new AddUserForm(employee);
                    addUserForm.MdiParent = MdiParent;
                    addUserForm.Show();
                    addUserForm.Dock = DockStyle.Fill;
                    addUserForm.FormBorderStyle = FormBorderStyle.None;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.ParamName, "Oopsie!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pracownik o podanym adresie e-mail istnieje już w bazie danych." + ex, "Oopsie!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.label1.Visible = false;
            this.Close();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRole.SelectedIndex == 1)
            {
                label7.Visible = true;
                comboBoxSpecialty.Visible = true;
            }
            else
            {
                label7.Visible = false;
                comboBoxSpecialty.Visible = false;
                comboBoxSpecialty.SelectedItem = null;
            }
        }

        private void txtboxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtboxMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
