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
    public partial class Button_Minimize : UserControl
    {
        public Button_Minimize()
        {
            InitializeComponent();
        }
        private void Button_Minimize_Click(object sender, EventArgs e)
        {
            ParentForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void Button_Minimize_MouseEnter(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Button_Minimize_Enter;
        }

        private void Button_Minimize_MouseLeave(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Button_Minimize;
        }
    }
}
