using System;
using System.Windows.Forms;
using formsClinicProject.DataAccess;

namespace formsClinicProject
{
    public partial class EditEmployeeForm : Form
    {
        Employee employeeForUser;
        int editedEmployeeId;

        public EditEmployeeForm(Employee employee)
        {
            InitializeComponent();
            comboBoxRole.DataSource = EmployeeDataAccess.ListOfRoles();
            comboBoxSpecialty.DataSource = EmployeeDataAccess.ListOfSpecialities();
            txtboxFirstName.Text = employee.First_name;
            txtboxLastName.Text = employee.Last_name;
            txtboxPhoneNumber.Text = employee.Phone_number;
            txtboxMobile.Text = employee.Mobile;
            txtboxEmailAddres.Text = employee.Email;
            dateTimePicker1.Value = employee.Date_of_birth;
            comboBoxRole.SelectedItem = employee.Id_employee_role;
            comboBoxSpecialty.SelectedItem = employee.Id_doct_specialization;
            editedEmployeeId = employee.Id_employee;
            employeeForUser = employee;

            //Jeżeli user ma Id_user = 0 (odpowiednik null w bazie) to pokazuje button do przypisania mu user'a essa
            buttonCreateUser.Visible = employee.Id_user == 0 ? true : false;
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
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
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string specialty = comboBoxSpecialty.SelectedItem == null ? null : comboBoxSpecialty.SelectedItem.ToString();
                Employee employee = new Employee(editedEmployeeId, txtboxFirstName.Text, txtboxLastName.Text, txtboxPhoneNumber.Text, txtboxMobile.Text, txtboxEmailAddres.Text, specialty, comboBoxRole.SelectedItem.ToString(), dateTimePicker1.Value);
                EmployeeDataAccess.UpdateEmployee(employee);
                this.label1.Visible = false;
                MessageBox.Show("Employee's data changed.");
                ReviewEmployeesForm REF = new ReviewEmployeesForm(employee.Id_employee_role);
                REF.MdiParent = MdiParent;
                REF.Show();
                REF.Dock = DockStyle.Fill;
                REF.FormBorderStyle = FormBorderStyle.None;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.ParamName, "Oopsie!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.label1.Visible = false;
            this.Close();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            AddUserForm ADF = new AddUserForm(employeeForUser);
            ADF.MdiParent = MdiParent;
            ADF.Show();
            ADF.Dock = DockStyle.Fill;
            ADF.FormBorderStyle = FormBorderStyle.None;
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

        private void txtboxMobile_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtboxPhoneNumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}