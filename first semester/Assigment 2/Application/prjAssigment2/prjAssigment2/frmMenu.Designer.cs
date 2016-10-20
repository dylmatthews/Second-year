namespace prjAssigment2
{
    partial class frmMenu
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
            this.rdbBatteries = new System.Windows.Forms.RadioButton();
            this.rdbLocks = new System.Windows.Forms.RadioButton();
            this.rdbRepairs = new System.Windows.Forms.RadioButton();
            this.rdbShop = new System.Windows.Forms.RadioButton();
            this.rdbKeys = new System.Windows.Forms.RadioButton();
            this.rdbRemotes = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbHeading = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbBatteries
            // 
            this.rdbBatteries.AutoSize = true;
            this.rdbBatteries.Location = new System.Drawing.Point(25, 74);
            this.rdbBatteries.Name = "rdbBatteries";
            this.rdbBatteries.Size = new System.Drawing.Size(66, 17);
            this.rdbBatteries.TabIndex = 0;
            this.rdbBatteries.TabStop = true;
            this.rdbBatteries.Text = "Batteries";
            this.rdbBatteries.UseVisualStyleBackColor = true;
            // 
            // rdbLocks
            // 
            this.rdbLocks.AutoSize = true;
            this.rdbLocks.Location = new System.Drawing.Point(157, 74);
            this.rdbLocks.Name = "rdbLocks";
            this.rdbLocks.Size = new System.Drawing.Size(54, 17);
            this.rdbLocks.TabIndex = 1;
            this.rdbLocks.TabStop = true;
            this.rdbLocks.Text = "Locks";
            this.rdbLocks.UseVisualStyleBackColor = true;
            // 
            // rdbRepairs
            // 
            this.rdbRepairs.AutoSize = true;
            this.rdbRepairs.Location = new System.Drawing.Point(25, 114);
            this.rdbRepairs.Name = "rdbRepairs";
            this.rdbRepairs.Size = new System.Drawing.Size(61, 17);
            this.rdbRepairs.TabIndex = 2;
            this.rdbRepairs.TabStop = true;
            this.rdbRepairs.Text = "Repairs";
            this.rdbRepairs.UseVisualStyleBackColor = true;
            // 
            // rdbShop
            // 
            this.rdbShop.AutoSize = true;
            this.rdbShop.Location = new System.Drawing.Point(157, 114);
            this.rdbShop.Name = "rdbShop";
            this.rdbShop.Size = new System.Drawing.Size(50, 17);
            this.rdbShop.TabIndex = 3;
            this.rdbShop.TabStop = true;
            this.rdbShop.Text = "Shop";
            this.rdbShop.UseVisualStyleBackColor = true;
            // 
            // rdbKeys
            // 
            this.rdbKeys.AutoSize = true;
            this.rdbKeys.Location = new System.Drawing.Point(25, 157);
            this.rdbKeys.Name = "rdbKeys";
            this.rdbKeys.Size = new System.Drawing.Size(48, 17);
            this.rdbKeys.TabIndex = 4;
            this.rdbKeys.TabStop = true;
            this.rdbKeys.Text = "Keys";
            this.rdbKeys.UseVisualStyleBackColor = true;
            // 
            // rdbRemotes
            // 
            this.rdbRemotes.AutoSize = true;
            this.rdbRemotes.Location = new System.Drawing.Point(157, 157);
            this.rdbRemotes.Name = "rdbRemotes";
            this.rdbRemotes.Size = new System.Drawing.Size(67, 17);
            this.rdbRemotes.TabIndex = 5;
            this.rdbRemotes.TabStop = true;
            this.rdbRemotes.Text = "Remotes";
            this.rdbRemotes.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(97, 204);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeading.Location = new System.Drawing.Point(12, 29);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(204, 20);
            this.lbHeading.TabIndex = 7;
            this.lbHeading.Text = "Select what you want to sell";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 8;
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
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbHeading);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rdbRemotes);
            this.Controls.Add(this.rdbKeys);
            this.Controls.Add(this.rdbShop);
            this.Controls.Add(this.rdbRepairs);
            this.Controls.Add(this.rdbLocks);
            this.Controls.Add(this.rdbBatteries);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbBatteries;
        private System.Windows.Forms.RadioButton rdbLocks;
        private System.Windows.Forms.RadioButton rdbRepairs;
        private System.Windows.Forms.RadioButton rdbShop;
        private System.Windows.Forms.RadioButton rdbKeys;
        private System.Windows.Forms.RadioButton rdbRemotes;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}