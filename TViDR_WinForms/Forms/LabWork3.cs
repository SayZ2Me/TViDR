using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TViDR_WinForms.Forms
{
    public partial class LabWork3 : Form
    {
        public LabWork3()
        {
            InitializeComponent();
        }
        public void ProcessData(int ProcessingMethod)
        {
            OutputTextBox.Clear();
            if (ProcessingMethod == 0)
            {
                datacompression.ACM ACMInstance = datacompression.ACM.GetInstance(InputTextBox.Text.ToString());
                ACMInstance.ProccessData();
                OutputTextBox.Text = (ACMInstance.Code.low.ToString() + Environment.NewLine + ACMInstance.Code.high.ToString());
            }
            else if (ProcessingMethod == 1)
            {
                datacompression.BWT BWTInstance = datacompression.BWT.GetInstance(InputTextBox.Text);
                BWTInstance.TrasformData();
                OutputTextBox.Text = BWTInstance.TransformedData;
            }
            else if (ProcessingMethod == 2)
            {
                datacompression.MTF MTFInstance = datacompression.MTF.GetInstance(InputTextBox.Text);
                MTFInstance.CompressData();
                OutputTextBox.Text = string.Join(", ", MTFInstance.CompressedData);
            }
        }

        private void ACMButton_Click(object sender, EventArgs e)
        {
            ProcessData(0);
        }

        private void BWTButton_Click(object sender, EventArgs e)
        {
            ProcessData(1);
        }

        private void MTFButton_Click(object sender, EventArgs e)
        {
            ProcessData(2);
        }
    }
}
