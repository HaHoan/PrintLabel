using PrintLabel.App.Common;
using PrintLabel.App.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintLabel.App._6THA3SOEMMain
{
    public partial class FormModel6ThA3sOEMMain : Form
    {
        private PMS_Kyo_ModelResponsibility pmsModelRes = new PMS_Kyo_ModelResponsibility();
        bool FieldError(Control control)
        {
            if (control.Text == "" || control.Text == null)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(control, "Required field!");
                control.Focus();
                return false;
            }
            return true;
        }
        private void LoadModelsData()
        {
            dataGridView1.DataSource = pmsModelRes.GetListModel(GROUP_ID.OEM);
        }
        public FormModel6ThA3sOEMMain()
        {
            InitializeComponent();
            LoadModelsData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FieldError(txtName) == false)
            {
                return;
            }

            else if (FieldError(txtASSYNo) == false)
            {
                return;
            }
            else if (FieldError(txtRev) == false)
            {
                return;
            }
            else
            {
                var type = rdA.Checked ? rdA.Text : rdZ.Checked ? rdZ.Text : "";
                var result = pmsModelRes.SaveToDb(new PMS_Kyo_Model()
                {
                    PRODUCT_ID = txtName.Text.Trim(),
                    GROUP_ID = GROUP_ID.OEM,
                    ASSY_NO = txtASSYNo.Text.Trim(),
                    MAC_START = rdZ.Checked ? "Z0000" : "A0000",
                    MAC_END = rdA.Checked ? "Y9999" : "Z9999",
                    MODIFIED_AT = DateTime.Now
                });
                if(result != "OK")
                {
                    MessageBox.Show(result);
                    return;
                }
                LoadModelsData();
                MessageBox.Show("Save success!");
                txtName.ResetText();
                txtASSYNo.ResetText();
                txtRev.ResetText();
            }
        }
        string model = null;

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                var result = pmsModelRes.Delete(model);
                if(result != "OK")
                {
                    MessageBox.Show(result);
                    return;
                }
                LoadModelsData();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();
                string rev = row.Cells[2].Value.ToString();
                txtName.Text = value1;
                txtASSYNo.Text = value2;
                txtRev.Text = rev;
                model = value1;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Ultils.WriteTxtFromDataGridView(dataGridView1);
            LoadModelsData();
        }
    }
}
