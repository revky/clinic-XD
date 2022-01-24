using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsClinicProject
{
    public partial class EditDoctorForm : Form
    {
        public EditDoctorForm()
        {
            InitializeComponent();
        }
        private void EditDoctorForm_Load(object sender, EventArgs e)
        {
            txtboxFirstName.Text = "Marek";
            txtboxSecondName.Text = "Kopeć";
            txtboxEmailAddres.Text = "marek.kopec@med.pl";
            txtboxPeselNumber.Text = "78301002903";
            txtboxPhoneNumber.Text = "505606505";
            comboBoxSpecialty.SelectedItem = "Pediatrics";
            comboBoxRoom.SelectedItem = "7";
            radioButtonActive.Checked = true;
            radioButtonInactive.Checked = false;
            checkedListBox1.SetItemChecked(0, true);
            checkedListBox1.SetItemChecked(1, true);
            checkedListBox1.SetItemChecked(2, true);
            checkedListBox1.SetItemChecked(3, true);
            checkedListBox1.SetItemChecked(4, true);
            txtBoxHourStart.Text = "08:00";
            txtBoxHourEnd.Text = "16:00";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.label1.Visible = false;
            Form rdf = new ReviewDoctorsForm();
            rdf.MdiParent = MdiParent;
            rdf.Show();
            rdf.Dock = DockStyle.Fill;
            rdf.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.label1.Visible = false;
            Form rdf = new ReviewDoctorsForm();
            rdf.MdiParent = MdiParent;
            rdf.Show();
            rdf.Dock = DockStyle.Fill;
            rdf.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
