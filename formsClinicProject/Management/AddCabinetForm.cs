using System;
using System.Windows.Forms;
using formsClinicProject.DataAccess;

namespace formsClinicProject
{
    public partial class AddCabinetForm : Form
    {
        public AddCabinetForm()
        {
            InitializeComponent();
        }
        private void reloadLocation()
        {
            AddCabinetForm acf = new AddCabinetForm();
            DockHelper.putFormInDock(acf, MdiParent);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int cabinetNum = Convert.ToInt32(numericUpDown1.Value);
            // Sprawdzenie czy w bazie jest już 20 gabinetów
            bool allCabinetsCreated = CabinetDataAccess.CanIAddCabinet();
            if (!allCabinetsCreated)
            {
                MessageBox.Show("The maximum number of cabinets has been already added.");
                return;

            }
            //Sprawdzenie czy w bazie istnieje już gabinet o podanym numerze 
            bool isNumberUsed = CabinetDataAccess.IsCabinetAvailable(cabinetNum, "Cabinet");
         
            if (!isNumberUsed)
            {
                try
                {
                    Cabinet cabinet = new Cabinet(cabinetNum);
                    //Dodawanie gabinetu do bazy danych
                    DataAccess.CabinetDataAccess.InputCabinet(cabinet);
                    MessageBox.Show("Cabinet added succesfully.");
                    reloadLocation();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Cabinet with this number already exists");
            }

        }

     




        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.label1.Visible = false;
            Form rdf = new ReviewEmployeesForm("NA");
            DockHelper.putFormInDock(rdf, MdiParent);
        }

        private void AddCabinetForm_Load(object sender, EventArgs e)
        {
            listBoxCabinets.DataSource = CabinetDataAccess.ListOfCabinets();
            listBoxCabinets.DisplayMember = "Number";
            listBoxCabinets.ValueMember = "Id";
        }

        

        private void btnDeleteCabinet_Click(object sender, EventArgs e)
        {

            int cabinetNum = Convert.ToInt32(listBoxCabinets.GetItemText(listBoxCabinets.SelectedItem));
            bool isAvailable = CabinetDataAccess.IsCabinetAvailable(cabinetNum, "v_FREE_CABINETS");
            if (isAvailable) {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the cabinet?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {



                        Cabinet cabinet = CabinetDataAccess.GetCabinetByNum(cabinetNum);
                        CabinetDataAccess.DeleteCabinet(cabinet);
                        MessageBox.Show("Cabinet has been removed.");
                        reloadLocation();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selected cabinet has appointments. It cannot be removed");
            }
        }

        private void listBoxCabinets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
