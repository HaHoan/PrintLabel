using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintLabel.App
{
    public partial class frmSelectModel : Form
    {
        public frmSelectModel()
        {
            InitializeComponent();
        }

        private void txtModelSelect_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string modelNo = txtModelSelect.Text;
                if (MessageBox.Show($"Select model [{modelNo}]", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Program.ModelSelect = modelNo;
                    this.Dispose();
                }
            }
        }
    }
}
