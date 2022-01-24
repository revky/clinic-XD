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
    public partial class ReviewDoctorsForm : Form
    {
        public ReviewDoctorsForm()
        {
            InitializeComponent();
            fillWithData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PasswordConfirmationForm pcf = new PasswordConfirmationForm();
            if (pcf.ShowDialog() != DialogResult.OK)
                return;
        }

        //Wprowadzenie przykładowych danych doktora do dataGridView
        private void fillWithData()
        {
            dataGridView1.Rows.Add("Marek", "Kopeć", "marek.kopec@med.pl", "78301002903", "505606505", "Pediatrics", 7);
            dataGridView1.Rows.Add("Aleksander", "Wiśniewski", "olek.wisniewski@med.pl", "8401032204", "525306515", "cardiologist", 9);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ReviewMedicianForm rmf = new ReviewMedicianForm();
            rmf.label1.Text += " " + this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            rmf.label2.Text += " " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            rmf.label3.Text += " " + this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            rmf.label4.Text += " " + this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            rmf.label5.Text += " " + this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            rmf.label6.Text += " " + this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            rmf.label7.Text += " " + this.dataGridView1.CurrentRow.Cells[6].Value.ToString();

            if (rmf.ShowDialog()!= DialogResult.OK) return;
          
        }

        private void btnEditDoctor_Click(object sender, EventArgs e)
        {
            EditDoctorForm edf = new EditDoctorForm();
            edf.Show();
            edf.MdiParent = MdiParent;
            edf.Dock = DockStyle.Fill;
            edf.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
