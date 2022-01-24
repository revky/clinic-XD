using formsClinicProject.Management;
using formsClinicProject.Reviews;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace formsClinicProject
{
    public partial class AdminPanelForm : Form
    {
        int loggedUserId;
        public static int loggedUserIdv2;

        public AdminPanelForm(string username, int userId)
        {
            InitializeComponent();
            customizeDesign();

            labelTitle.Text = $"Hello {username}.";

            IsMdiContainer = true;

            loggedUserId = userId;
            loggedUserIdv2 = userId;
        }



        private void customizeDesign()
        {
            panelDoctorsSubmenu.Visible = false;
            panelUsersSubmenu.Visible = false;
        }

        private void hideSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == true)
                subMenu.Visible = false;
        }

        private void subMenuVisibility(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                if (subMenu.Visible == true)
                {
                    subMenu.Visible = false;
                }
            }
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            subMenuVisibility(panelDoctorsSubmenu);
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            subMenuVisibility(panelUsersSubmenu);
        }

        private void putFormInDock(Form formName)
        {
            this.label1.Visible = false;
            DockHelper.putFormInDock(formName, this);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form adf = new AddEmployeeForm();
            putFormInDock(adf);
        }

        private void btnAddCabinet_Click(object sender, EventArgs e)
        {

            Form acf = new AddCabinetForm();
            putFormInDock(acf);
        }

        //Wylogowywuje użytkownika i wraca do ekranu logowania
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Logging out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Form1 form = new Form1();
                form.Show();
                this.Close();
                MessageBox.Show("Logged out succesfully.");
            }
        }

        private void btnReviewUsers_Click(object sender, EventArgs e)
        {

            Form losf = new ReviewUsersForm(loggedUserId);
            putFormInDock(losf);

        }
        private void btnReviewDoctor_Click(object sender, EventArgs e)
        {
            Form remf = new ReviewEmployeesForm("Doctor");
            putFormInDock(remf);
        }

        private void btnReviewNurses_Click(object sender, EventArgs e)
        {
            Form remf = new ReviewEmployeesForm("Nurse");
            putFormInDock(remf);
        }

        private void btnReviewEmplOfReg_Click(object sender, EventArgs e)
        {
            Form remf = new ReviewEmployeesForm("Employee of registration");
            putFormInDock(remf);
        }


        //Kod umożliwiający poruszanie formatkom bez border'a
        //Działa przy trzymaniu przycisku na panelu górnym formatki
        //Praise stackoverflow
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnReviewAdmins_Click_1(object sender, EventArgs e)
        {
            Form remf = new ReviewEmployeesForm("Admin");
            putFormInDock(remf);
        }

        private void buttonReviewPermissions_Click_1(object sender, EventArgs e)
        {
            ReviewPermissions RP = new ReviewPermissions();
            putFormInDock(RP);

        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            subMenuVisibility(panelCalendarSubmenu);
        }

        private void buttonCreateCalendar_Click(object sender, EventArgs e)
        {
            putFormInDock(new AddCalendarForm());
        }

        private void buttonManageTerms_Click(object sender, EventArgs e)
        {
            putFormInDock(new TermsManagementForm());
        }
    }
}
