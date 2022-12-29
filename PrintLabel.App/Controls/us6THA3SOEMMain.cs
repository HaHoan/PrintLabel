using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrintLabel.App._6THA3SOEMMain;
using PrintLabel.App._6THA3SOEM;
using System.IO;
using PrintLabel.Common;
using PrintLabel.App.Database;
using PrintLabel.App.Common;

namespace PrintLabel.App.Controls
{
    public partial class us6THA3SOEMMain : UserControl
    {
        private PMS_Kyo_Model _model = new PMS_Kyo_Model();
        private PMS_Kyo_ModelResponsibility pmsModelRes = new PMS_Kyo_ModelResponsibility();
        public Dictionary<string, int> _dic = new Dictionary<string, int>()
        {
            {"A",10 },
            {"B",11 },
            {"C",12 },
            {"D",13 },
            {"E",14 },
            {"F",15 },
            {"G",16 },
            {"H",17 },
            {"J",18 },
            {"K",19 },
            {"L",20 },
            {"M",21 },
            {"N",22 },
            {"P",23 },
            {"Q",24 },
            {"R",25 },
            {"S",26 },
            {"T",27 },
            {"U",28 },
            {"V",29 },
            {"W",30 },
            {"X",31 },
            {"Y",32 },
            {"Z",33 },
        };
        public Dictionary<string, int> _dicTypeA = new Dictionary<string, int>()
        {
            {"A",10 },
            {"B",11 },
            {"C",12 },
            {"D",13 },
            {"E",14 },
            {"F",15 },
            {"G",16 },
            {"H",17 },
            {"J",18 },
            {"K",19 },
            {"L",20 },
            {"M",21 },
            {"N",22 },
            {"P",23 },
            {"Q",24 },
            {"R",25 },
            {"S",26 },
            {"T",27 },
            {"U",28 },
            {"V",29 },
            {"W",30 },
            {"X",31 },
            {"Y",32 },
        };
        public Dictionary<string, int> _dicTypeZ = new Dictionary<string, int>()
        {
            {"Z",33 },
        };
        List<OEMMains> lists = new List<OEMMains>();
        List<PMS_Kyo_Model> _models;
        private void PathLog()
        {
            var path = Ultils.GetValueRegistryKey("6TH A3S OEM MAIN", "PathLog");
            if (path != null)
            {
                txtPathLog.Text = path;
            }
        }
        private string path = AppDomain.CurrentDomain.BaseDirectory + @"Configs\ModelsOEM.txt";
        private string pathLog = @"C:\Logs\6THA3SOEMMain";
        List<string> years = new List<string>();
        List<string> months = new List<string>();
        bool WOError(Control control)
        {
            if (control.Text == "" || control.Text == null || control.Text.Length != 10)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(control, "Required field!");
                control.Focus();
                return false;
            }
            return true;
        }
        List<string> days = new List<string>();
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
            Dictionary<int, string> dicMonth = new Dictionary<int, string>();
            for (int i = 1; i <= 9; i++)
            {
                months.Add(i.ToString());
                dicMonth.Add(i, i.ToString());
            }
            dicMonth.Add(10, "X");
            dicMonth.Add(11, "Y");
            dicMonth.Add(12, "Z");
            string[] array = { "X", "Y", "Z" };
            foreach (var item in array)
            {
                months.Add(item);
            }
            //cboMonth.DataSource = months;
            // cboMonth.SelectedItem = DateTime.Now.Month.ToString();
            cboMonth.DataSource = null;
            cboMonth.DataSource = dicMonth.GetValues();
            var monthCurr = dicMonth[DateTime.Now.Month];
            cboMonth.SelectedItem = monthCurr;
            cboMonth.Refresh();
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
            _models = pmsModelRes.GetListModel(GROUP_ID.OEM);
            _models.Insert(0, new PMS_Kyo_Model());
            cboModels.DataSource = _models;
            cboModels.DisplayMember = "PRODUCT_ID";
            cboModels.ValueMember = "ASSY_NO";
        }
        public us6THA3SOEMMain()
        {
            InitializeComponent();
            GetYears();
            GetMonths();
            GetDays();
            LoadModelsData();
            PathLog();
        }

        private void lblPathLog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog outputLog = new FolderBrowserDialog();
            DialogResult open = outputLog.ShowDialog();
            if (open == DialogResult.OK)
            {
                txtPathLog.Text = outputLog.SelectedPath;
                Ultils.WriteRegistry("6TH A3S OEM MAIN", "PathLog", outputLog.SelectedPath);
                PathLog();
            }
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

        private void lblAddModel_Click(object sender, EventArgs e)
        {
            new FormModel6ThA3sOEMMain().ShowDialog();
            LoadModelsData();
        }

        private void cboModels_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cboModels.SelectedIndex > 0)
            {
                _model = pmsModelRes.GetModel(cboModels.Text.Trim());
                txtASSYNo.Text = _model.ASSY_NO;
                txtRev.Text = _model.REV_CODE;
                errorProvider1.Clear();
                string year = cboYear.Text;
                string month = cboMonth.Text;
                if (string.IsNullOrEmpty(_model.LATEST_BARCODE))
                {
                    this.txtSerialBegin.Text = "A0001";
                    if (_model.MAC_START == "A0000")
                    {
                        this.txtSerialBegin.Text = "A0001";
                    }
                    else
                    {
                        this.txtSerialBegin.Text = "Z0001";
                    }
                }
                else
                {
                    string value = _model.LATEST_BARCODE;
                    string numberStart;
                    if (_model.MAC_START == "A0000" && _model.MAC_END == "Z9999")
                    {
                        numberStart = Ultils.GetNumberStart(value.Right(5), _dic);
                    }
                    else if (_model.MAC_START == "A0000" && _model.MAC_END == "Y9999")
                    {
                        numberStart = Ultils.GetNumberStart(value.Right(5), _dicTypeA);
                    }
                    else
                    {
                        numberStart = Ultils.GetNumberStart(value.Right(5), _dicTypeZ);
                    }
                    txtSerialBegin.Text = numberStart;
                }
                txtQuantity.Focus();
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
            else if (WOError(txtWO) == false)
            {
                return;
            }
            else if (FieldError(txtASSYNo) == false)
            {
                return;
            }
            else
            {
                int index = cboModels.FindStringExact(cboModels.Text);
                if (index < 0)
                {
                    MessageBox.Show("Model not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                _model = (PMS_Kyo_Model)cboModels.Items[index];
                string quantity = txtQuantity.Text;
                string year = cboYear.Text.Right(1);
                string month = cboMonth.Text;
                string assyNo = txtASSYNo.Text;
                double qty = double.Parse(quantity);
                string startTo = txtSerialBegin.Text;
                try
                {
                    lists = new List<OEMMains>();
                    dataGridView1.DataSource = null;
                    if (_model.MAC_START == "A0000" && _model.MAC_END == "Z9999")
                    {
                        lists = Ultils.MakeSerial(_model, startTo, qty, _dic, month, year);
                    }
                    else if (_model.MAC_START == "A0000" && _model.MAC_END == "Y9999")
                    {
                        lists = Ultils.MakeSerial(_model, startTo, qty, _dicTypeA, month, year);
                    }
                    else
                    {
                        lists = Ultils.MakeSerial(_model, startTo, qty, _dicTypeZ, month, year);
                    }
                    btnExportToCSV.Enabled = true;
                    dataGridView1.DataSource = lists;
                    this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    this.dataGridView1.RowHeadersVisible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error genrate serial!\n {ex.Message}");
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

            // Log Print system
            if (FieldError(txtPathLog) == false) return;
            string logPrint = txtPathLog.Text;
            if (!Directory.Exists(logPrint))
            {
                Directory.CreateDirectory(logPrint);
            }

            string folderModel = $@"{pathLog}\{_model.PRODUCT_ID}";
            if (!Directory.Exists(folderModel))
            {
                Directory.CreateDirectory(folderModel);
            }
            string year = cboYear.Text;
            string month = cboMonth.Text;
            string fileName = $@"{folderModel}\Data.csv";
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
                var result = Ultils.SaveToDb(dataGridView1, txtWO.Text.Trim());
                if (result != "OK")
                {
                    MessageBox.Show($"Error:\n{result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Ultils.WriteCSV(dataGridView1, fileName);
                Ultils.WriteAppendCSV(dataGridView1, true, newLog);
                MessageBox.Show("Export success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtSerialBegin.ResetText();
                txtQuantity.ResetText();
                cboModels.ResetText();
                txtASSYNo.ResetText();
                txtWO.ResetText();
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            usCommon.txtQuantity_KeyPress(sender, e);
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            usCommon.txtQuantity_Validating(sender, e, txtQuantity, errorProvider1);
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            usCommon.txtQuantity_TextChanged(sender, e, errorProvider1);
        }

        private void txtWO_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGenerateSerial.PerformClick();
            }
        }

        private void txtQuantity_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtWO.Focus();
            }
        }
    }
}
