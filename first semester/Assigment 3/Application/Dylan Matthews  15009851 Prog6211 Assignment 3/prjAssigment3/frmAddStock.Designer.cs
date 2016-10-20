namespace prjAssigment3
{
    partial class frmAddStock
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
            this.rdbRemotes = new System.Windows.Forms.RadioButton();
            this.rdbKeys = new System.Windows.Forms.RadioButton();
            this.rdbShop = new System.Windows.Forms.RadioButton();
            this.rdbRepairs = new System.Windows.Forms.RadioButton();
            this.rdbLocks = new System.Windows.Forms.RadioButton();
            this.rdbBatteries = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeading.Location = new System.Drawing.Point(26, 25);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(208, 20);
            this.lbHeading.TabIndex = 15;
            this.lbHeading.Text = "Select what you want to add";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(111, 200);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rdbRemotes
            // 
            this.rdbRemotes.AutoSize = true;
            this.rdbRemotes.Location = new System.Drawing.Point(171, 153);
            this.rdbRemotes.Name = "rdbRemotes";
            this.rdbRemotes.Size = new System.Drawing.Size(67, 17);
            this.rdbRemotes.TabIndex = 13;
            this.rdbRemotes.TabStop = true;
            this.rdbRemotes.Text = "Remotes";
            this.rdbRemotes.UseVisualStyleBackColor = true;
            // 
            // rdbKeys
            // 
            this.rdbKeys.AutoSize = true;
            this.rdbKeys.Location = new System.Drawing.Point(39, 153);
            this.rdbKeys.Name = "rdbKeys";
            this.rdbKeys.Size = new System.Drawing.Size(48, 17);
            this.rdbKeys.TabIndex = 12;
            this.rdbKeys.TabStop = true;
            this.rdbKeys.Text = "Keys";
            this.rdbKeys.UseVisualStyleBackColor = true;
            // 
            // rdbShop
            // 
            this.rdbShop.AutoSize = true;
            this.rdbShop.Location = new System.Drawing.Point(171, 110);
            this.rdbShop.Name = "rdbShop";
            this.rdbShop.Size = new System.Drawing.Size(50, 17);
            this.rdbShop.TabIndex = 11;
            this.rdbShop.TabStop = true;
            this.rdbShop.Text = "Shop";
            this.rdbShop.UseVisualStyleBackColor = true;
            // 
            // rdbRepairs
            // 
            this.rdbRepairs.AutoSize = true;
            this.rdbRepairs.Location = new System.Drawing.Point(39, 110);
            this.rdbRepairs.Name = "rdbRepairs";
            this.rdbRepairs.Size = new System.Drawing.Size(61, 17);
            this.rdbRepairs.TabIndex = 10;
            this.rdbRepairs.TabStop = true;
            this.rdbRepairs.Text = "Repairs";
            this.rdbRepairs.UseVisualStyleBackColor = true;
            // 
            // rdbLocks
            // 
            this.rdbLocks.AutoSize = true;
            this.rdbLocks.Location = new System.Drawing.Point(171, 70);
            this.rdbLocks.Name = "rdbLocks";
            this.rdbLocks.Size = new System.Drawing.Size(54, 17);
            this.rdbLocks.TabIndex = 9;
            this.rdbLocks.TabStop = true;
            this.rdbLocks.Text = "Locks";
            this.rdbLocks.UseVisualStyleBackColor = true;
            // 
            // rdbBatteries
            // 
            this.rdbBatteries.AutoSize = true;
            this.rdbBatteries.Location = new System.Drawing.Point(39, 70);
            this.rdbBatteries.Name = "rdbBatteries";
            this.rdbBatteries.Size = new System.Drawing.Size(66, 17);
            this.rdbBatteries.TabIndex = 8;
            this.rdbBatteries.TabStop = true;
            this.rdbBatteries.Text = "Batteries";
            this.rdbBatteries.UseVisualStyleBackColor = true;
            // 
            // frmAddStock
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
            this.Name = "frmAddStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rdbRemotes;
        private System.Windows.Forms.RadioButton rdbKeys;
        private System.Windows.Forms.RadioButton rdbShop;
        private System.Windows.Forms.RadioButton rdbRepairs;
        private System.Windows.Forms.RadioButton rdbLocks;
        private System.Windows.Forms.RadioButton rdbBatteries;
    }
}