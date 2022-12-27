namespace PrintLabel.App.Controls
{
    partial class usPrintAgain
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPathLog = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExportToCSV = new System.Windows.Forms.Button();
            this.txtPathLog = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtWO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(754, 120);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblPathLog);
            this.groupBox1.Controls.Add(this.txtSerial);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnExportToCSV);
            this.groupBox1.Controls.Add(this.txtPathLog);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // lblPathLog
            // 
            this.lblPathLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPathLog.Enabled = false;
            this.lblPathLog.Image = global::PrintLabel.App.Properties.Resources.folder_saved_search_16;
            this.lblPathLog.Location = new System.Drawing.Point(224, 36);
            this.lblPathLog.Name = "lblPathLog";
            this.lblPathLog.Size = new System.Drawing.Size(27, 20);
            this.lblPathLog.TabIndex = 20;
            this.lblPathLog.Click += new System.EventHandler(this.lblPathLog_Click);
            // 
            // txtSerial
            // 
            this.txtSerial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerial.Location = new System.Drawing.Point(59, 62);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(113, 20);
            this.txtSerial.TabIndex = 13;
            this.txtSerial.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtSerial_PreviewKeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Path log:";
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Enabled = false;
            this.btnExportToCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToCSV.ForeColor = System.Drawing.Color.Maroon;
            this.btnExportToCSV.Image = global::PrintLabel.App.Properties.Resources.file_formats3_csv_32;
            this.btnExportToCSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportToCSV.Location = new System.Drawing.Point(280, 36);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(138, 37);
            this.btnExportToCSV.TabIndex = 11;
            this.btnExportToCSV.Text = "Export to CSV";
            this.btnExportToCSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportToCSV.UseVisualStyleBackColor = true;
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // txtPathLog
            // 
            this.txtPathLog.Enabled = false;
            this.txtPathLog.Location = new System.Drawing.Point(59, 36);
            this.txtPathLog.Name = "txtPathLog";
            this.txtPathLog.Size = new System.Drawing.Size(160, 20);
            this.txtPathLog.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Serial:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Maroon;
            this.lblStatus.Location = new System.Drawing.Point(60, 118);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 21;
            // 
            // txtWO
            // 
            this.txtWO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWO.Enabled = false;
            this.txtWO.Location = new System.Drawing.Point(59, 88);
            this.txtWO.Name = "txtWO";
            this.txtWO.Size = new System.Drawing.Size(113, 20);
            this.txtWO.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "WO:";
            // 
            // usPrintAgain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "usPrintAgain";
            this.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.Size = new System.Drawing.Size(764, 273);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Button btnExportToCSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPathLog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPathLog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtWO;
        private System.Windows.Forms.Label label1;
    }
}
