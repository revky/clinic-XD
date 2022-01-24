using System;
using System.Data;
using System.Windows.Forms;
using formsClinicProject.DataAccess;



namespace formsClinicProject
{
    public partial class ReviewEmployeesForm : Form
    {
        string parameter;
        public ReviewEmployeesForm(string dgv_parameter)
        {
            InitializeComponent();
            parameter = dgv_parameter;
        }

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                PasswordConfirmationForm pcf = new PasswordConfirmationForm(AdminPanelForm.loggedUserIdv2, "Confirm your password to change employee's status");

                if (pcf.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                else
                {
                    int employee_id = (int)dataGridViewListOfEmployees.CurrentRow.Cells[0].Value;

                    if (btnDeleteDoctor.Text == "Deactivate employee")
                        EmployeeDataAccess.DeactivateEmployee(employee_id);
                    else
                        EmployeeDataAccess.ActivateEmployee(employee_id);

                    loadDataGridView();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //Edytowanie pracownika w bazie danych
        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                int employee_id = (int)dataGridViewListOfEmployees.CurrentRow.Cells[0].Value;
                Employee employee = EmployeeDataAccess.GetEmployeeDataBasedOnId(employee_id);
                if (String.IsNullOrWhiteSpace(employee.Phone_number))
                    employee.Phone_number = string.Empty;
                EditEmployeeForm edf = new EditEmployeeForm(employee);
                edf.MdiParent = MdiParent;
                edf.Show();
                edf.Dock = DockStyle.Fill;
                edf.FormBorderStyle = FormBorderStyle.None;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadDataGridView();
        }

        public void loadDataGridView()
        {
            DataTable listofeployees = EmployeeDataAccess.GetListOfEmployeeFromView();
            if (parameter == "Doctor" || parameter == "Nurse" || parameter == "Employee of registration" || parameter == "Admin")
                listofeployees.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "role", parameter); ;
            dataGridViewListOfEmployees.DataSource = listofeployees;
            dataPreparation();

            switch (parameter)
            {
                case "Doctor":
                    label1.Text = "Review Doctors";
                    break;

                case "Nurse":
                    label1.Text = "Review Nurses";
                    break;

                case "Employee of registration":
                    label1.Text = "Review Employees of registration";
                    break;

                case "Admin":
                    label1.Text = "Review Administrators";
                    break;

                default:
                    break;
            }
            dataGridViewListOfEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReviewEmployeesForm_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void dataPreparation()
        {
            dataGridViewListOfEmployees.Columns[0].Visible = false;
            dataGridViewListOfEmployees.Columns[1].HeaderText = "First name";
            dataGridViewListOfEmployees.Columns[2].HeaderText = "Last name";
            dataGridViewListOfEmployees.Columns[3].HeaderText = "Date of birth";
            dataGridViewListOfEmployees.Columns[4].HeaderText = "Phone number";
            dataGridViewListOfEmployees.Columns[5].HeaderText = "Mobile number";
            dataGridViewListOfEmployees.Columns[6].HeaderText = "Email";
            dataGridViewListOfEmployees.Columns[7].HeaderText = "Role";
            dataGridViewListOfEmployees.Columns[8].HeaderText = "Specialization";
            dataGridViewListOfEmployees.Columns[9].HeaderText = "Login";
            dataGridViewListOfEmployees.Columns[10].HeaderText = "Status";
        }

        private void dataGridViewListOfEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewListOfEmployees.CurrentRow != null)
            {
                string userStatus = dataGridViewListOfEmployees.CurrentRow.Cells[10].Value.ToString().Trim();

                if (userStatus == "Active")
                    btnDeleteDoctor.Text = "Deactivate employee";
                else
                    btnDeleteDoctor.Text = "Activate employee";
            }
        }
    }
}
