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
        private string path = AppDomain.CurrentDomain.BaseDirectory + @"Configs\ModelsOEM.txt";

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
            List<OEMMainEntity> models = new List<OEMMainEntity>();
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
            }
            var data = Ultils.ReadAllLines(path, Encoding.ASCII);
            foreach (var item in data)
            {
                OEMMainEntity model = null;
                string[] array = null;
                if (item.Contains(","))
                {
                    array = item.Split(',');
                    model = new OEMMainEntity
                    {
                        model_Name = array[0],
                        assyNo = array[1],
                        rev = array[2],
                        range = array.Length == 4 ? array[3] : ""
                    };
                }
                models.Add(model);
            }
            dataGridView1.DataSource = models;
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
                string content = $"{txtName.Text},{txtASSYNo.Text},{txtRev.Text},{type}";
                Ultils.Write(path, content);

                LoadModelsData();
                MessageBox.Show("Save success!");
                txtName.ResetText();
                txtASSYNo.ResetText();
                txtRev.ResetText();
            }
        }
        string content = null;

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Ultils.RemoveLine(path, content);
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
                content = $"{value1},{value2}";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Ultils.WriteTxtFromDataGridView(dataGridView1, path);
        }
    }
}
