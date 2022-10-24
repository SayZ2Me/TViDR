using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TViDR_WinForms.Forms
{
    public partial class LabWork1 : Form
    {
        string path;
        public LabWork1()
        {
            InitializeComponent();
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File (*.bmp,*.png)|*.bmp;*.png";
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                path = openFileDialog.FileName;
                Bitmap Image = new Bitmap(path);
                LeftSplitContainer.Panel1.BackgroundImage = Image;
            }
        }

        private void ProcessImageButton_Click(object sender, EventArgs e)
        {
            imageprocessing.YIQ YIQInstace = new imageprocessing.YIQ(path);
            YIQInstace.Convert(true);
            LeftSplitContainer.Panel2.BackgroundImage = YIQInstace.ImageY;
            RightSplitContainer.Panel1.BackgroundImage = YIQInstace.ImageI;
            RightSplitContainer.Panel2.BackgroundImage = YIQInstace.ImageQ;
        }

        private void ProcessImageButtonColor_Click(object sender, EventArgs e)
        {
            imageprocessing.YIQ YIQInstace = new imageprocessing.YIQ(path);
            YIQInstace.Convert(false);
            LeftSplitContainer.Panel2.BackgroundImage = YIQInstace.ImageY;
            RightSplitContainer.Panel1.BackgroundImage = YIQInstace.ImageI;
            RightSplitContainer.Panel2.BackgroundImage = YIQInstace.ImageQ;
        }
    }
}
