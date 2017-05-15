namespace Assigment1
{
    partial class frmReport
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
            this.tbcReport = new System.Windows.Forms.TabControl();
            this.tbpGenerateReport = new System.Windows.Forms.TabPage();
            this.btnMakeReport = new System.Windows.Forms.Button();
            this.tbpViewReport = new System.Windows.Forms.TabPage();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.btnshowReport = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcReport.SuspendLayout();
            this.tbpGenerateReport.SuspendLayout();
            this.tbpViewReport.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcReport
            // 
            this.tbcReport.Controls.Add(this.tbpGenerateReport);
            this.tbcReport.Controls.Add(this.tbpViewReport);
            this.tbcReport.Location = new System.Drawing.Point(12, 32);
            this.tbcReport.Name = "tbcReport";
            this.tbcReport.SelectedIndex = 0;
            this.tbcReport.Size = new System.Drawing.Size(356, 284);
            this.tbcReport.TabIndex = 0;
            // 
            // tbpGenerateReport
            // 
            this.tbpGenerateReport.Controls.Add(this.btnMakeReport);
            this.tbpGenerateReport.Location = new System.Drawing.Point(4, 22);
            this.tbpGenerateReport.Name = "tbpGenerateReport";
            this.tbpGenerateReport.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGenerateReport.Size = new System.Drawing.Size(348, 258);
            this.tbpGenerateReport.TabIndex = 0;
            this.tbpGenerateReport.Text = "Generate Report";
            this.tbpGenerateReport.UseVisualStyleBackColor = true;
            // 
            // btnMakeReport
            // 
            this.btnMakeReport.Location = new System.Drawing.Point(31, 46);
            this.btnMakeReport.Name = "btnMakeReport";
            this.btnMakeReport.Size = new System.Drawing.Size(104, 23);
            this.btnMakeReport.TabIndex = 1;
            this.btnMakeReport.Text = "Make Report";
            this.btnMakeReport.UseVisualStyleBackColor = true;
            this.btnMakeReport.Click += new System.EventHandler(this.btnMakeReport_Click);
            // 
            // tbpViewReport
            // 
            this.tbpViewReport.Controls.Add(this.txtReport);
            this.tbpViewReport.Controls.Add(this.btnshowReport);
            this.tbpViewReport.Location = new System.Drawing.Point(4, 22);
            this.tbpViewReport.Name = "tbpViewReport";
            this.tbpViewReport.Padding = new System.Windows.Forms.Padding(3);
            this.tbpViewReport.Size = new System.Drawing.Size(348, 258);
            this.tbpViewReport.TabIndex = 1;
            this.tbpViewReport.Text = "View Report";
            this.tbpViewReport.UseVisualStyleBackColor = true;
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(11, 36);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(323, 210);
            this.txtReport.TabIndex = 2;
            // 
            // btnshowReport
            // 
            this.btnshowReport.Location = new System.Drawing.Point(52, 7);
            this.btnshowReport.Name = "btnshowReport";
            this.btnshowReport.Size = new System.Drawing.Size(137, 23);
            this.btnshowReport.TabIndex = 1;
            this.btnshowReport.Text = "Show Report";
            this.btnshowReport.UseVisualStyleBackColor = true;
            this.btnshowReport.Click += new System.EventHandler(this.btnshowReport_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(433, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.backToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 328);
            this.Controls.Add(this.tbcReport);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.tbcReport.ResumeLayout(false);
            this.tbpGenerateReport.ResumeLayout(false);
            this.tbpViewReport.ResumeLayout(false);
            this.tbpViewReport.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcReport;
        private System.Windows.Forms.TabPage tbpGenerateReport;
        private System.Windows.Forms.TabPage tbpViewReport;
        private System.Windows.Forms.Button btnMakeReport;
        private System.Windows.Forms.Button btnshowReport;
        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}