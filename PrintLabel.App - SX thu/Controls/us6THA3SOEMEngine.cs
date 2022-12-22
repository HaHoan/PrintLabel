using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrintLabel.App.Trailer._6THA3SOEM;
using PrintLabel.App.Trailer._6THA3SOEMEmgine;
using System.IO;

namespace PrintLabel.App.Trailer.Controls
{
    public partial class us6THA3SOEMEngine : UserControl
    {
        private string path = AppDomain.CurrentDomain.BaseDirectory + @"Configs\Models6THA3SOEMEngine.txt";
        private string pathLog = @"C:\Logs\6THA3SOEMEngine";
        List<string> years = new List<string>();
        List<string> months = new List<string>();
        List<string> days = new List<string>();
        private OEMEngineEntity _model = new OEMEngineEntity();
        private List<OEMEngines> _oemEngines = new List<OEMEngines>();
        /// <summary>
        /// 
        /// </summary>
        private void GetYears()
        {
            int beginYear = DateTime.Now.AddYears(-10).Year;
            int endYear = DateTime.Now.AddYears(1).Year;
            for (int i = beginYear; i <= endYear; i++)
            {
                years.Add(i.ToString());
            }
            string[] array = { "X", "Y", "Z" };
            foreach (var item in array)
            {
                years.Add(item);
            }
            cboYear.DataSource = years;
            cboYear.SelectedItem = DateTime.Now.Year.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        private void GetMonths()
        {
            for (int i = 1; i <= 9; i++)
            {
                months.Add(i.ToString());
            }
            string[] array = { "X", "Y", "Z" };
            foreach (var item in array)
            {
                months.Add(item);
            }
            cboMonth.DataSource = months;
            cboMonth.SelectedItem = DateTime.Now.Month.ToString();
        }
        private void GetDays()
        {
            for (int i = 1; i <= 31; i++)
            {
                if (i <= 9)
                {
                    days.Add($"0{i}");
                }
                else
                {
                    days.Add(i.ToString());
                }
            }
            cbbDay.DataSource = days;
            cbbDay.SelectedItem = DateTime.Now.Day.ToString();
        }
        private void LoadModelsData()
        {
            List<OEMEngineEntity> models = new List<OEMEngineEntity>();
            var test = new OEMEngineEntity
            {
                Model = "",
            };
            models.Add(test);
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
                        ASSY_No = array[1]
                    };
                }
                models.Add(model);
            }
            cboModels.DataSource = models;
            cboModels.DisplayMember = "Model";
            cboModels.ValueMember = "ASSY_No";
        }
        private void PathLog()
        {
            var path = Ultils.GetValueRegistryKey("6TH A3S OEM ENGINE", "PathLog");
            if (path != null)
            {
                txtPathLog.Text = path;
            }
        }
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
        public us6THA3SOEMEngine()
        {
            InitializeComponent();
            GetYears();
            GetMonths();
            GetDays();
            LoadModelsData();
            PathLog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (btnExportToCSV.Enabled == true)
            {
                if (dataGridView1.DataSource == null)
                {
                    btnExportToCSV.Enabled = false;
                }
            }
            if (Program.CurrentUser.UserName != null)
            {
                lblAddModel.Enabled = true;
                lblPathLog.Enabled = true;
            }
            else
            {
                if (lblAddModel.Enabled == true)
                    lblAddModel.Enabled = false;
                if (lblPathLog.Enabled == true)
                    lblPathLog.Enabled = false;
            }
        }

        private void lblAddModel_Click(object sender, EventArgs e)
        {
            new frm6THA3SOEMEngine().ShowDialog();
            LoadModelsData();
        }

        private void lblPathLog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog outputLog = new FolderBrowserDialog();
            DialogResult open = outputLog.ShowDialog();
            if (open == DialogResult.OK)
            {
                txtPathLog.Text = outputLog.SelectedPath;
                Ultils.WriteRegistry("6TH A3S OEM ENGINE", "PathLog", outputLog.SelectedPath);
                PathLog();
            }
        }

        private void cboModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            _model = (OEMEngineEntity)cboModels.SelectedItem;
            txtASSYNo.Text = _model.ASSY_No;
        }

        private void ckChangeDate_CheckedChanged(object sender, EventArgs e)
        {
            var check = ckChangeDate.Checked;
            if (check == true)
            {
                cboYear.Enabled = true;
                cboMonth.Enabled = true;
            }
            else
            {
                cboYear.Enabled = false;
                cboMonth.Enabled = false;
            }
        }

        private void btnGenerateSerial_Click(object sender, EventArgs e)
        {
            if (FieldError(cboYear) == false)
            {
                return;
            }
            else if (FieldError(cboMonth) == false)
            {
                return;
            }
            else if (FieldError(cboModels) == false)
            {
                return;
            }
            else if (FieldError(txtQuantity) == false)
            {
                return;
            }
            else if (FieldError(txtASSYNo) == false)
            {
                return;
            }
            else
            {
                string model = cboModels.Text;
                string quantity = txtQuantity.Text;
                string year = cboYear.Text.Substring(3);
                string month = cboMonth.Text;
                string day = cbbDay.Text;
                string assyNo = txtASSYNo.Text;
                double qty = double.Parse(quantity);
                string des = $"{cboModels.Text.Substring(2, 3)}-{cboYear.Text.Right(2)}{month}{day}";
                for (int i = 0; i < qty; i++)
                {
                    //dataGridView1.Rows.Add(assyNo, des, model);
                    _oemEngines.Add(new OEMEngines() { model = model, des = des, assyNo = assyNo });
                }
                dataGridView1.DataSource = _oemEngines;
                btnExportToCSV.Enabled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& (e.KeyChar != '.')*/)
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                if (FieldError(txtQuantity) == true)
                {
                    double qty = double.Parse(txtQuantity.Text);
                    if (qty > 999999)
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(txtQuantity, "Value maximum!");
                        return;
                    }
                }
            }
        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            bool exists = Directory.Exists(pathLog);
            if (!exists)
            {
                Directory.CreateDirectory(pathLog);
            }

            // Log system
            // Log Print system
            string logPrint = txtPathLog.Text;
            if (!Directory.Exists(logPrint))
            {
                Directory.CreateDirectory(logPrint);
            }

            string folderModel = $@"{pathLog}\{_model.Model}";
            if (!Directory.Exists(folderModel))
            {
                Directory.CreateDirectory(folderModel);
            }


            string year = cboYear.Text;
            string month = cboMonth.Text;
            string fileName = $@"{folderModel}\{year + month}.csv";
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Dispose();
            }

            // Logs
            string newLog = logPrint + @"\Log.csv";
            if (!File.Exists(newLog))
            {
                File.Create(newLog).Dispose();
            }

            try
            {
                Ultils.WriteCSV(dataGridView1, fileName);
                Ultils.WriteAppendCSV(dataGridView1, true, newLog);
                MessageBox.Show("Export success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtQuantity.ResetText();
                cboModels.ResetText();
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
