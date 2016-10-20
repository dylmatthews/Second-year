namespace FinalStockControlSystem
{
    partial class frmAdmin
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
            this.lbHeading = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rdbViewStock = new System.Windows.Forms.RadioButton();
            this.rdbAddStock = new System.Windows.Forms.RadioButton();
            this.rdbSellStock = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeading.Location = new System.Drawing.Point(37, 38);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(199, 20);
            this.lbHeading.TabIndex = 15;
            this.lbHeading.Text = "Select what you want to do\r\n";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(122, 213);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rdbViewStock
            // 
            this.rdbViewStock.AutoSize = true;
            this.rdbViewStock.Location = new System.Drawing.Point(13, 96);
            this.rdbViewStock.Name = "rdbViewStock";
            this.rdbViewStock.Size = new System.Drawing.Size(79, 17);
            this.rdbViewStock.TabIndex = 16;
            this.rdbViewStock.TabStop = true;
            this.rdbViewStock.Text = "View Stock";
            this.rdbViewStock.UseVisualStyleBackColor = true;
            // 
            // rdbAddStock
            // 
            this.rdbAddStock.AutoSize = true;
            this.rdbAddStock.Location = new System.Drawing.Point(122, 96);
            this.rdbAddStock.Name = "rdbAddStock";
            this.rdbAddStock.Size = new System.Drawing.Size(75, 17);
            this.rdbAddStock.TabIndex = 17;
            this.rdbAddStock.TabStop = true;
            this.rdbAddStock.Text = "Add Stock";
            this.rdbAddStock.UseVisualStyleBackColor = true;
            // 
            // rdbSellStock
            // 
            this.rdbSellStock.AutoSize = true;
            this.rdbSellStock.Location = new System.Drawing.Point(234, 96);
            this.rdbSellStock.Name = "rdbSellStock";
            this.rdbSellStock.Size = new System.Drawing.Size(73, 17);
            this.rdbSellStock.TabIndex = 18;
            this.rdbSellStock.TabStop = true;
            this.rdbSellStock.Text = "Sell Stock";
            this.rdbSellStock.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(357, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 279);
            this.Controls.Add(this.rdbSellStock);
            this.Controls.Add(this.rdbAddStock);
            this.Controls.Add(this.rdbViewStock);
            this.Controls.Add(this.lbHeading);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdmin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rdbViewStock;
        private System.Windows.Forms.RadioButton rdbAddStock;
        private System.Windows.Forms.RadioButton rdbSellStock;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}