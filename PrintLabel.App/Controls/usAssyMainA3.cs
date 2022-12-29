using PrintLabel.App.Common;
using PrintLabel.App.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintLabel.App.Controls
{
    public partial class usAssyMainA3 : UserControl
    {
        private string pathLog = null;
        List<ViewAssyMainA3> lists = new List<ViewAssyMainA3>();
        List<PMS_Kyo_Model> _models = new List<PMS_Kyo_Model>();
        private PMS_Kyo_Model _model = new PMS_Kyo_Model();
        private PMS_Kyo_ModelResponsibility pmsModelRes = new PMS_Kyo_ModelResponsibility();
        public usAssyMainA3()
        {
            InitializeComponent();
            LoadModelsData();
            PathLog();
        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadModelsData()
        {
            _models = pmsModelRes.GetListModel(GROUP_ID.ASSYMainA3);
            _models.Insert(0, new PMS_Kyo_Model());
            cboModels.DataSource = _models;
            cboModels.DisplayMember = "PRODUCT_ID";
            cboModels.ValueMember = "ASSY_NO";
        }

        /// <summary>
        /// 
        /// </summary>
        private void PathLog()
        {
            var path = Ultils.GetValueRegistryKey("Assy Main A3", "PathLog");
            if (path != null)
            {
                txtPathLog.Text = path;
                pathLog = path;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerateSerial_Click(object sender, EventArgs e)
        {
            if (usCommon.FieldError(cboModels, errorProvider1) == false)
            {
                return;
            }
            else if (usCommon.FieldError(txtQuantity, errorProvider1) == false)
            {
                return;
            }
            else if (usCommon.FieldError(txtASSYNo, errorProvider1) == false)
            {
                return;
            }
            else if (usCommon.WOError(txtWo, errorProvider1) == false)
            {
                return;
            }
            else
            {
                string model = _model.PRODUCT_ID;
                string assyNo = $"ASSY No. {_model.ASSY_NO}";
                string barcode = _model.ASSY_NO.Substring(0, 10);

                string quantity = txtQuantity.Text;
                double qty = double.Parse(quantity);

                try
                {
                    lists = new List<ViewAssyMainA3>();
                    dataGridView1.DataSource = null;
                    for (int i = 0; i < qty; i++)
                    {
                        var item = new ViewAssyMainA3
                        {
                            Model = model,
                            AssyNo = assyNo,
                            Barcode = barcode,
                        };
                        lists.Add(item);
                    }

                    btnExportToCSV.Enabled = true;
                    dataGridView1.DataSource = lists;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error genrate serial!\n {ex.Message}");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportToCSV_Click(object sender, EventArgs e)
        {

            if (pathLog == null || pathLog == "")
            {
                MessageBox.Show("Please select the path to save the log file!", "Error path logs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usCommon.FieldError(txtPathLog,errorProvider1);
                return;
            }

            bool exists = Directory.Exists(pathLog);
            if (!exists)
            {
                Directory.CreateDirectory(pathLog);
            }

            // Log Print system
            string logPrint = pathLog;
            if (!Directory.Exists(logPrint))
            {
                Directory.CreateDirectory(logPrint);
            }

            string folderModel = $@"{pathLog}\{_model.PRODUCT_ID}";
            if (!Directory.Exists(folderModel))
            {
                Directory.CreateDirectory(folderModel);
            }

            string fileName = $@"{folderModel}\{_model.PRODUCT_ID}.csv";
            //string fileName = $@"{pathLog}\{_model.Name + year + month}.csv";
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
                var result = Ultils.SaveToDb(dataGridView1, txtWo.Text.Trim());
                if (result != "OK")
                {
                    MessageBox.Show($"Error:\n{result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Ultils.WriteCSV(dataGridView1, fileName);
                Ultils.WriteAppendCSV(dataGridView1, true, newLog);
                MessageBox.Show("Export success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtWo.ResetText();
                txtQuantity.ResetText();
                cboModels.ResetText();
                txtASSYNo.ResetText();
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                cboModels.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtASSYNo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void cboModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (cboModels.SelectedIndex > 0)
            {
                _model = pmsModelRes.GetModel(cboModels.Text.Trim());
                txtASSYNo.Text = _model.ASSY_NO;
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                txtQuantity.ResetText();
                txtQuantity.Focus();
            }

        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (cboModels.SelectedIndex > 0)
            {
                txtQuantity.ResetText();
                txtASSYNo.ResetText();
                cboModels.ResetText();
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& (e.KeyChar != '.')*/)
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                if (usCommon.FieldError(txtQuantity,errorProvider1) == true)
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
            new FormAssyMainA3().ShowDialog();
            LoadModelsData();
        }

        private void txtQuantity_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGenerateSerial.PerformClick();
            }
        }

        private void lblPathLog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog outputLog = new FolderBrowserDialog();
            DialogResult open = outputLog.ShowDialog();
            if (open == DialogResult.OK)
            {
                txtPathLog.Text = outputLog.SelectedPath;
                Ultils.WriteRegistry("Assy Main A3", "PathLog", outputLog.SelectedPath);
                PathLog();
            }
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
        }

        private void txtWo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGenerateSerial.PerformClick();
            }
        }
    }
}
