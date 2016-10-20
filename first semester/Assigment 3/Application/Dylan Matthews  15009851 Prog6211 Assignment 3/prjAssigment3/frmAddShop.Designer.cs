namespace prjAssigment3
{
    partial class frmAddShop
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.lblQuan = new System.Windows.Forms.Label();
            this.lblRepairName = new System.Windows.Forms.Label();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lstShop = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(106, 226);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(198, 226);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(13, 226);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 33;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtQuan
            // 
            this.txtQuan.Location = new System.Drawing.Point(12, 178);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(100, 20);
            this.txtQuan.TabIndex = 32;
            // 
            // lblQuan
            // 
            this.lblQuan.AutoSize = true;
            this.lblQuan.Location = new System.Drawing.Point(13, 152);
            this.lblQuan.Name = "lblQuan";
            this.lblQuan.Size = new System.Drawing.Size(46, 13);
            this.lblQuan.TabIndex = 31;
            this.lblQuan.Text = "Quantity";
            // 
            // lblRepairName
            // 
            this.lblRepairName.AutoSize = true;
            this.lblRepairName.Location = new System.Drawing.Point(13, 79);
            this.lblRepairName.Name = "lblRepairName";
            this.lblRepairName.Size = new System.Drawing.Size(63, 13);
            this.lblRepairName.TabIndex = 30;
            this.lblRepairName.Text = "Shop Name";
            // 
            // txtShopName
            // 
            this.txtShopName.Location = new System.Drawing.Point(13, 110);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(100, 20);
            this.txtShopName.TabIndex = 29;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(13, 23);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(99, 23);
            this.btnShow.TabIndex = 28;
            this.btnShow.Text = "Show Shop";
            this.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lstShop
            // 
            this.lstShop.FormattingEnabled = true;
            this.lstShop.Items.AddRange(new object[] {
            "What would you like to add"});
            this.lstShop.Location = new System.Drawing.Point(118, 12);
            this.lstShop.Name = "lstShop";
            this.lstShop.Size = new System.Drawing.Size(155, 186);
            this.lstShop.TabIndex = 27;
            // 
            // frmAddShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtQuan);
            this.Controls.Add(this.lblQuan);
            this.Controls.Add(this.lblRepairName);
            this.Controls.Add(this.txtShopName);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lstShop);
            this.Name = "frmAddShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.Label lblQuan;
        private System.Windows.Forms.Label lblRepairName;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ListBox lstShop;
    }
}