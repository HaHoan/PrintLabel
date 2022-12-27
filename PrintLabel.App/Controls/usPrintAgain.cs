using PrintLabel.App._6THA3SOEMMain;
using PrintLabel.App.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintLabel.App.Controls
{
    public partial class usPrintAgain : UserControl
    {
        private string path = AppDomain.CurrentDomain.BaseDirectory + @"Configs\ModelsLibraOEM.txt";
        private string pathLog = @"C:\Logs\PrintAgain";
        List<OEMMains> lists = new List<OEMMains>();
        private ModelLibraOEM _model = new ModelLibraOEM();
        public usPrintAgain()
        {
            InitializeComponent();
            PathLog();
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

        private void txtSerial_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtSerial.Text.Trim()))
            {
                var kyoResponsibility = new PMS_Kyo_InitResonsibility();
                var kyoInit = kyoResponsibility.GetBySerial(txtSerial.Text.Trim());
                if (kyoInit == null) lblStatus.Text = "Chưa in serial này lần nào.";
                else if (kyoInit.UPD_TIME != kyoInit.CREATE_AT) lblStatus.Text = "Serial quá số lần in lại.";
                else
                {
                    txtWO.Text = kyoInit.ORDER_NO;
                    lists = new List<OEMMains>();
                    lists.Add(new OEMMains()
                    {
                        model = kyoInit.PRODUCT_ID,
                        assyNo = kyoInit.ASSY_NO,
                        barcode = kyoInit.BOARD_NO,
                        comment = $"{kyoInit.PRODUCT_ID.Substring(2, 7)}"
                    });
                    _model.Name = kyoInit.PRODUCT_ID;
                    dataGridView1.DataSource = null;
                    btnExportToCSV.Enabled = true;
                    dataGridView1.DataSource = lists;
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
            string logPrint = txtPathLog.Text;
            if (!Directory.Exists(logPrint))
            {
                Directory.CreateDirectory(logPrint);
            }

            string folderModel = $@"{pathLog}\{_model.Name}";
            if (!Directory.Exists(folderModel))
            {
                Directory.CreateDirectory(folderModel);
            }
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();
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
                Ultils.SaveToDb(dataGridView1,txtWO.Text.Trim());
                Ultils.WriteCSV(dataGridView1, fileName);
                Ultils.WriteAppendCSV(dataGridView1, true, newLog);
                MessageBox.Show("Export success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lblPathLog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog outputLog = new FolderBrowserDialog();
            DialogResult open = outputLog.ShowDialog();
            if (open == DialogResult.OK)
            {
                txtPathLog.Text = outputLog.SelectedPath;
                Ultils.WriteRegistry("PrintAgain", "PathLog", outputLog.SelectedPath);
                PathLog();
            }
        }

        private void PathLog()
        {
            var path = Ultils.GetValueRegistryKey("PrintAgain", "PathLog");
            if (path != null)
            {
                txtPathLog.Text = path;
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
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
                lblPathLog.Enabled = true;
            }
            else
            {
                if (lblPathLog.Enabled == true)
                    lblPathLog.Enabled = false;
            }
        }
    }
}
