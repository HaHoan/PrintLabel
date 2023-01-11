namespace PrintLabel.App._6THA3SOEMMain
{
    partial class FormModel6ThA3sOEMMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdZ = new System.Windows.Forms.RadioButton();
            this.rdA = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRev = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtASSYNo = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PRODUCT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASSY_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REV_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarcodeHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LatestBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MacStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MacEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdZ);
            this.groupBox1.Controls.Add(this.rdA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRev);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtASSYNo);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 130);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic from";
            // 
            // rdZ
            // 
            this.rdZ.AutoSize = true;
            this.rdZ.Location = new System.Drawing.Point(428, 58);
            this.rdZ.Name = "rdZ";
            this.rdZ.Size = new System.Drawing.Size(90, 17);
            this.rdZ.TabIndex = 12;
            this.rdZ.TabStop = true;
            this.rdZ.Text = "Z0000-Z9999";
            this.rdZ.UseVisualStyleBackColor = true;
            // 
            // rdA
            // 
            this.rdA.AutoSize = true;
            this.rdA.Location = new System.Drawing.Point(337, 58);
            this.rdA.Name = "rdA";
            this.rdA.Size = new System.Drawing.Size(90, 17);
            this.rdA.TabIndex = 11;
            this.rdA.TabStop = true;
            this.rdA.Text = "A0000-Y9999";
            this.rdA.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Range:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "REV:";
            // 
            // txtRev
            // 
            this.txtRev.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRev.Location = new System.Drawing.Point(337, 24);
            this.txtRev.Name = "txtRev";
            this.txtRev.Size = new System.Drawing.Size(161, 20);
            this.txtRev.TabIndex = 8;
            // 
            // btnDel
            // 
            this.btnDel.Image = global::PrintLabel.App.Properties.Resources.trash_16;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(217, 87);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ASSY No:";
            // 
            // txtASSYNo
            // 
            this.txtASSYNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtASSYNo.Location = new System.Drawing.Point(123, 55);
            this.txtASSYNo.Name = "txtASSYNo";
            this.txtASSYNo.Size = new System.Drawing.Size(161, 20);
            this.txtASSYNo.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::PrintLabel.App.Properties.Resources.Save;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(573, 83);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Save";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::PrintLabel.App.Properties.Resources.plus_16;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(123, 87);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Location = new System.Drawing.Point(123, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(79, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRODUCT_ID,
            this.ASSY_NO,
            this.REV_CODE,
            this.GroupId,
            this.BarcodeHeader,
            this.LatestBarcode,
            this.ModifiedBy,
            this.ModifiedAt,
            this.MacStart,
            this.MacEnd});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 320);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // PRODUCT_ID
            // 
            this.PRODUCT_ID.DataPropertyName = "PRODUCT_ID";
            this.PRODUCT_ID.HeaderText = "Model";
            this.PRODUCT_ID.Name = "PRODUCT_ID";
            // 
            // ASSY_NO
            // 
            this.ASSY_NO.DataPropertyName = "ASSY_NO";
            this.ASSY_NO.HeaderText = "AssyNo";
            this.ASSY_NO.Name = "ASSY_NO";
            // 
            // REV_CODE
            // 
            this.REV_CODE.DataPropertyName = "REV_CODE";
            this.REV_CODE.HeaderText = "RevCode";
            this.REV_CODE.Name = "REV_CODE";
            // 
            // GroupId
            // 
            this.GroupId.DataPropertyName = "GROUP_ID";
            this.GroupId.HeaderText = "GroupId";
            this.GroupId.Name = "GroupId";
            this.GroupId.Visible = false;
            // 
            // BarcodeHeader
            // 
            this.BarcodeHeader.DataPropertyName = "BARCODE_HEADER";
            this.BarcodeHeader.HeaderText = "BarcodeHeader";
            this.BarcodeHeader.Name = "BarcodeHeader";
            this.BarcodeHeader.Visible = false;
            // 
            // LatestBarcode
            // 
            this.LatestBarcode.DataPropertyName = "LATEST_BARCODE";
            this.LatestBarcode.HeaderText = "LatestBarcode";
            this.LatestBarcode.Name = "LatestBarcode";
            this.LatestBarcode.Visible = false;
            // 
            // ModifiedBy
            // 
            this.ModifiedBy.DataPropertyName = "MODIFIED_BY";
            this.ModifiedBy.HeaderText = "ModifiedBy";
            this.ModifiedBy.Name = "ModifiedBy";
            this.ModifiedBy.Visible = false;
            // 
            // ModifiedAt
            // 
            this.ModifiedAt.DataPropertyName = "MODIFIED_AT";
            this.ModifiedAt.HeaderText = "ModifiedAt";
            this.ModifiedAt.Name = "ModifiedAt";
            this.ModifiedAt.Visible = false;
            // 
            // MacStart
            // 
            this.MacStart.DataPropertyName = "MAC_START";
            this.MacStart.HeaderText = "MacStart";
            this.MacStart.Name = "MacStart";
            this.MacStart.Visible = false;
            // 
            // MacEnd
            // 
            this.MacEnd.DataPropertyName = "MAC_END";
            this.MacEnd.HeaderText = "MacEnd";
            this.MacEnd.Name = "MacEnd";
            this.MacEnd.Visible = false;
            // 
            // FormModel6ThA3sOEMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 447);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormModel6ThA3sOEMMain";
            this.Text = "FormModel6ThA3sOEMMain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtASSYNo;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRev;
        private System.Windows.Forms.RadioButton rdZ;
        private System.Windows.Forms.RadioButton rdA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASSY_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn REV_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarcodeHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn LatestBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MacStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn MacEnd;
    }
}