using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TViDR_WinForms.UserControls
{
    public partial class Button_Maximize : UserControl
    {
        public Button_Maximize()
        {
            InitializeComponent();
        }

        private void Button_Maximize_Click(object sender, EventArgs e)
        {
            if (ParentForm.WindowState == System.Windows.Forms.FormWindowState.Maximized)
            {
                ParentForm.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
            else
            {
                ParentForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            }
        }

        private void Button_Maximize_MouseEnter(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Button_Maximize_Enter;
        }

        private void Button_Maximize_MouseLeave(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Button_Maximize;
        }
    }
}
