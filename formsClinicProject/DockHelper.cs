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
