using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintLabel.App._6THA3SOEM
{
    public partial class frm6THA3SOEMEngine : Form
    {
        private string path = AppDomain.CurrentDomain.BaseDirectory + @"Configs\Models6THA3SOEMEngine.txt";
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
            List<OEMEngineEntity> models = new List<OEMEngineEntity>();
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
            }
            var data = Ultils.ReadAllLines(path, Encoding.ASCII);
            foreach (var item in data)
            {
                OEMEngineEntity model = null;
                string[] array = null;
                if (item.Contains(","))
                {
                    array = item.Split(',');
                    model = new OEMEngineEntity
                    {
                        Model = array[0],
                        ASSY_No = array[1],
                    };
                }
                models.Add(model);
            }
            dataGridView1.DataSource = models;
        }
        public frm6THA3SOEMEngine()
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
            else
            {
                string content = $"{txtName.Text},{txtASSYNo.Text}";
                Ultils.Write(path, content);

                LoadModelsData();
                MessageBox.Show("Save success!");
                txtName.ResetText();
                txtASSYNo.ResetText();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Ultils.WriteTxtFromDataGridView(dataGridView1, path);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();
                txtName.Text = value1;
                txtASSYNo.Text = value2;
                content = $"{value1},{value2}";
            }
        }
    }
}
