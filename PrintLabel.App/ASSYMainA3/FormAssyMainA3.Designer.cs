namespace PrintLabel.App
{
    partial class FormAssyMainA3
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 105);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infomation";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::PrintLabel.App.Properties.Resources.trash_16;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(153, 74);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCode
            // 
            this.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode.Location = new System.Drawing.Point(96, 48);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(142, 20);
            this.txtCode.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModel.Location = new System.Drawing.Point(96, 21);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(142, 20);
            this.txtModel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Assy No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Model:";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::PrintLabel.App.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(404, 74);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::PrintLabel.App.Properties.Resources.plus_16;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(96, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 224);
            this.dataGridView1.TabIndex = 9;
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
            this.REV_CODE.Visible = false;
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
            // FormAssyMainA3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 334);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAssyMainA3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Assy Main A3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
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