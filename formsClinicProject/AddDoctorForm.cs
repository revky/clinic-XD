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
    public partial class AddDoctorForm : Form
    {
        public AddDoctorForm()
        {
            InitializeComponent();
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
