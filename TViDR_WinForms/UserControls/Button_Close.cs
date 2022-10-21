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
    public partial class Button_Close : UserControl
    {
        public Button_Close()
        {
            InitializeComponent();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Close_MouseEnter(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Button_Close_Enter;
        }

        private void Button_Close_MouseLeave(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Button_Close;
        }
    }
}
