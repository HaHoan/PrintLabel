namespace PrintLabel.App
{
    partial class frmSelectModel
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
            this.txtModelSelect = new System.Windows.Forms.TextBox();
            this.lblAddModel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtModelSelect
            // 
            this.txtModelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelSelect.Location = new System.Drawing.Point(72, 34);
            this.txtModelSelect.Name = "txtModelSelect";
            this.txtModelSelect.Size = new System.Drawing.Size(239, 22);
            this.txtModelSelect.TabIndex = 18;
            this.txtModelSelect.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtModelSelect_PreviewKeyDown);
            // 
            // lblAddModel
            // 
            this.lblAddModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddModel.Image = global::PrintLabel.App.Properties.Resources.barcode_32;
            this.lblAddModel.Location = new System.Drawing.Point(29, 33);
            this.lblAddModel.Name = "lblAddModel";
            this.lblAddModel.Size = new System.Drawing.Size(27, 23);
            this.lblAddModel.TabIndex = 17;
            // 
            // frmSelectModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 108);
            this.Controls.Add(this.txtModelSelect);
            this.Controls.Add(this.lblAddModel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Model";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModelSelect;
        private System.Windows.Forms.Label lblAddModel;
    }
}