using PrintLabel.App.Common;
using PrintLabel.App.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintLabel.App
{
    public partial class FormModelLibiraOEM : Form
    {
        private PMS_Kyo_ModelResponsibility pmsModelRes = new PMS_Kyo_ModelResponsibility();
        public FormModelLibiraOEM()
        {
            InitializeComponent();
            LoadData();
        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadData()
        {
            dataGridView1.DataSource = pmsModelRes.GetListModel(GROUP_ID.Mebius);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (FieldError(txtModel) == false)
            {
                return;
            }
            else if (FieldError(txtCode) == false)
            {
                return;
            }
            else
            {
                var result = pmsModelRes.SaveToDb(new PMS_Kyo_Model()
                {
                    PRODUCT_ID = txtModel.Text.Trim(),
                    GROUP_ID = GROUP_ID.Mebius,
                    ASSY_NO = txtCode.Text.Trim(),
                    MODIFIED_AT = DateTime.Now
                });
                if (result != "OK")
                {
                    MessageBox.Show(result);
                    return;
                }
                LoadData();
                MessageBox.Show("Save success!");
                txtModel.ResetText();
                txtCode.ResetText();
            }
        }
        string model = null;
        private void btnSave_Click(object sender, EventArgs e)
        {
            Ultils.WriteTxtFromDataGridView(dataGridView1);
            LoadData();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();

                model = value1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                var result = pmsModelRes.Delete(model);
                if (result != "OK")
                {
                    MessageBox.Show(result);
                    return;
                }
                LoadData();
            }
        }
    }
}
