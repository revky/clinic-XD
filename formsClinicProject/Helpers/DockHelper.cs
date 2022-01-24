using System.Windows.Forms;

namespace formsClinicProject
{
    public class DockHelper
    {
        public static void putFormInDock(Form formName, Form parentForm)
        {
            formName.MdiParent = parentForm;
            formName.Dock = DockStyle.Fill;
            formName.FormBorderStyle = FormBorderStyle.None;
            formName.Show();
        }
    }
}
