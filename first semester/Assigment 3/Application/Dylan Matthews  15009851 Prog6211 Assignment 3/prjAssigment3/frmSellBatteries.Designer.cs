namespace prjAssigment3
{
    partial class frmSellBatteries
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
            this.lstBat = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtBatName = new System.Windows.Forms.TextBox();
            this.lblBatName = new System.Windows.Forms.Label();
            this.lblQuan = new System.Windows.Forms.Label();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBat
            // 
            this.lstBat.FormattingEnabled = true;
            this.lstBat.Items.AddRange(new object[] {
            "What would you like to buy"});
            this.lstBat.Location = new System.Drawing.Point(117, 12);
            this.lstBat.Name = "lstBat";
            this.lstBat.Size = new System.Drawing.Size(155, 186);
            this.lstBat.TabIndex = 0;
            this.lstBat.SelectedIndexChanged += new System.EventHandler(this.lstBat_SelectedIndexChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 23);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(99, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show Batteries";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtBatName
            // 
            this.txtBatName.Location = new System.Drawing.Point(12, 110);
            this.txtBatName.Name = "txtBatName";
            this.txtBatName.Size = new System.Drawing.Size(100, 20);
            this.txtBatName.TabIndex = 2;
            this.txtBatName.TextChanged += new System.EventHandler(this.txtBatName_TextChanged);
            // 
            // lblBatName
            // 
            this.lblBatName.AutoSize = true;
            this.lblBatName.Location = new System.Drawing.Point(12, 79);
            this.lblBatName.Name = "lblBatName";
            this.lblBatName.Size = new System.Drawing.Size(71, 13);
            this.lblBatName.TabIndex = 3;
            this.lblBatName.Text = "Battery Name";
            this.lblBatName.Click += new System.EventHandler(this.lblBatName_Click);
            // 
            // lblQuan
            // 
            this.lblQuan.AutoSize = true;
            this.lblQuan.Location = new System.Drawing.Point(12, 152);
            this.lblQuan.Name = "lblQuan";
            this.lblQuan.Size = new System.Drawing.Size(46, 13);
            this.lblQuan.TabIndex = 4;
            this.lblQuan.Text = "Quantity";
            this.lblQuan.Click += new System.EventHandler(this.lblQuan_Click);
            // 
            // txtQuan
            // 
            this.txtQuan.Location = new System.Drawing.Point(11, 178);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(100, 20);
            this.txtQuan.TabIndex = 5;
            this.txtQuan.TextChanged += new System.EventHandler(this.txtQuan_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 226);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(197, 226);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(105, 226);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmSellBatteries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtQuan);
            this.Controls.Add(this.lblQuan);
            this.Controls.Add(this.lblBatName);
            this.Controls.Add(this.txtBatName);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lstBat);
            this.Name = "frmSellBatteries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell Batteries";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBat;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtBatName;
        private System.Windows.Forms.Label lblBatName;
        private System.Windows.Forms.Label lblQuan;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;

    }
}