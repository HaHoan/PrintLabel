namespace PrintLabel.App.Trailer.Controls
{
    partial class us6THA3SOEMEngine
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtPathLog = new System.Windows.Forms.TextBox();
            this.txtASSYNo = new System.Windows.Forms.TextBox();
            this.ckChangeDate = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboModels = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPathLog = new System.Windows.Forms.Label();
            this.lblAddModel = new System.Windows.Forms.Label();
            this.btnExportToCSV = new System.Windows.Forms.Button();
            this.btnGenerateSerial = new System.Windows.Forms.Button();
            this.cbbDay = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Path log:";
            // 
            // txtPathLog
            // 
            this.txtPathLog.Enabled = false;
            this.txtPathLog.Location = new System.Drawing.Point(72, 26);
            this.txtPathLog.Name = "txtPathLog";
            this.txtPathLog.Size = new System.Drawing.Size(160, 20);
            this.txtPathLog.TabIndex = 15;
            // 
            // txtASSYNo
            // 
            this.txtASSYNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtASSYNo.Enabled = false;
            this.txtASSYNo.Location = new System.Drawing.Point(344, 52);
            this.txtASSYNo.Name = "txtASSYNo";
            this.txtASSYNo.Size = new System.Drawing.Size(113, 20);
            this.txtASSYNo.TabIndex = 13;
            // 
            // ckChangeDate
            // 
            this.ckChangeDate.AutoSize = true;
            this.ckChangeDate.Location = new System.Drawing.Point(72, 135);
            this.ckChangeDate.Name = "ckChangeDate";
            this.ckChangeDate.Size = new System.Drawing.Size(87, 17);
            this.ckChangeDate.TabIndex = 12;
            this.ckChangeDate.Text = "Change date";
            this.ckChangeDate.UseVisualStyleBackColor = true;
            this.ckChangeDate.CheckedChanged += new System.EventHandler(this.ckChangeDate_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(764, 484);
            this.dataGridView1.TabIndex = 3;
            // 
            // cboModels
            // 
            this.cboModels.FormattingEnabled = true;
            this.cboModels.Items.AddRange(new object[] {
            ""});
            this.cboModels.Location = new System.Drawing.Point(344, 26);
            this.cboModels.Name = "cboModels";
            this.cboModels.Size = new System.Drawing.Size(113, 21);
            this.cboModels.TabIndex = 7;
            this.cboModels.SelectedIndexChanged += new System.EventHandler(this.cboModels_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "ASSY No:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(344, 80);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(113, 20);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuantity_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quanity:";
            // 
            // cboMonth
            // 
            this.cboMonth.Enabled = false;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(72, 79);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(116, 21);
            this.cboMonth.TabIndex = 3;
            // 
            // cboYear
            // 
            this.cboYear.Enabled = false;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(72, 52);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(116, 21);
            this.cboYear.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Month:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Model:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbDay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblPathLog);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPathLog);
            this.groupBox1.Controls.Add(this.lblAddModel);
            this.groupBox1.Controls.Add(this.txtASSYNo);
            this.groupBox1.Controls.Add(this.ckChangeDate);
            this.groupBox1.Controls.Add(this.btnExportToCSV);
            this.groupBox1.Controls.Add(this.btnGenerateSerial);
            this.groupBox1.Controls.Add(this.cboModels);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboMonth);
            this.groupBox1.Controls.Add(this.cboYear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // lblPathLog
            // 
            this.lblPathLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPathLog.Enabled = false;
            this.lblPathLog.Image = global::PrintLabel.App.Trailer.Properties.Resources.folder_saved_search_16;
            this.lblPathLog.Location = new System.Drawing.Point(237, 26);
            this.lblPathLog.Name = "lblPathLog";
            this.lblPathLog.Size = new System.Drawing.Size(27, 20);
            this.lblPathLog.TabIndex = 17;
            this.lblPathLog.Click += new System.EventHandler(this.lblPathLog_Click);
            // 
            // lblAddModel
            // 
            this.lblAddModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddModel.Enabled = false;
            this.lblAddModel.Image = global::PrintLabel.App.Trailer.Properties.Resources.plus_16;
            this.lblAddModel.Location = new System.Drawing.Point(468, 26);
            this.lblAddModel.Name = "lblAddModel";
            this.lblAddModel.Size = new System.Drawing.Size(27, 23);
            this.lblAddModel.TabIndex = 14;
            this.lblAddModel.Click += new System.EventHandler(this.lblAddModel_Click);
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Enabled = false;
            this.btnExportToCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToCSV.ForeColor = System.Drawing.Color.Maroon;
            this.btnExportToCSV.Image = global::PrintLabel.App.Trailer.Properties.Resources.file_formats3_csv_32;
            this.btnExportToCSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportToCSV.Location = new System.Drawing.Point(523, 71);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(138, 37);
            this.btnExportToCSV.TabIndex = 11;
            this.btnExportToCSV.Text = "Export to CSV";
            this.btnExportToCSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportToCSV.UseVisualStyleBackColor = true;
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // btnGenerateSerial
            // 
            this.btnGenerateSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateSerial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGenerateSerial.Image = global::PrintLabel.App.Trailer.Properties.Resources._1479456864_Streamline_75;
            this.btnGenerateSerial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateSerial.Location = new System.Drawing.Point(523, 24);
            this.btnGenerateSerial.Name = "btnGenerateSerial";
            this.btnGenerateSerial.Size = new System.Drawing.Size(138, 40);
            this.btnGenerateSerial.TabIndex = 10;
            this.btnGenerateSerial.Text = "Generate Serial";
            this.btnGenerateSerial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerateSerial.UseVisualStyleBackColor = true;
            this.btnGenerateSerial.Click += new System.EventHandler(this.btnGenerateSerial_Click);
            // 
            // cbbDay
            // 
            this.cbbDay.Enabled = false;
            this.cbbDay.FormattingEnabled = true;
            this.cbbDay.Location = new System.Drawing.Point(72, 107);
            this.cbbDay.Name = "cbbDay";
            this.cbbDay.Size = new System.Drawing.Size(116, 21);
            this.cbbDay.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Day:";
            // 
            // us6THA3SOEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "us6THA3SOEM";
            this.Size = new System.Drawing.Size(764, 642);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPathLog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPathLog;
        private System.Windows.Forms.Label lblAddModel;
        private System.Windows.Forms.TextBox txtASSYNo;
        private System.Windows.Forms.CheckBox ckChangeDate;
        private System.Windows.Forms.Button btnExportToCSV;
        private System.Windows.Forms.Button btnGenerateSerial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboModels;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbDay;
        private System.Windows.Forms.Label label5;
    }
}
