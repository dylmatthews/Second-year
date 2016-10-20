namespace FinalStockControlSystem
{
    partial class frmRegisterUser
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
            this.cmbRelationshipStatus = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbJobStatus = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblRelationshipStatus = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPasswordComfirmed = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.bntSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbRelationshipStatus
            // 
            this.cmbRelationshipStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelationshipStatus.FormattingEnabled = true;
            this.cmbRelationshipStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Dating"});
            this.cmbRelationshipStatus.Location = new System.Drawing.Point(154, 203);
            this.cmbRelationshipStatus.Name = "cmbRelationshipStatus";
            this.cmbRelationshipStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbRelationshipStatus.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(24, 166);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Job Status";
            // 
            // cmbJobStatus
            // 
            this.cmbJobStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJobStatus.FormattingEnabled = true;
            this.cmbJobStatus.Items.AddRange(new object[] {
            "Admin",
            "worker"});
            this.cmbJobStatus.Location = new System.Drawing.Point(154, 166);
            this.cmbJobStatus.Name = "cmbJobStatus";
            this.cmbJobStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbJobStatus.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblRelationshipStatus
            // 
            this.lblRelationshipStatus.AutoSize = true;
            this.lblRelationshipStatus.Location = new System.Drawing.Point(24, 203);
            this.lblRelationshipStatus.Name = "lblRelationshipStatus";
            this.lblRelationshipStatus.Size = new System.Drawing.Size(98, 13);
            this.lblRelationshipStatus.TabIndex = 4;
            this.lblRelationshipStatus.Text = "Relationship Status";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(24, 72);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // lblPasswordComfirmed
            // 
            this.lblPasswordComfirmed.AutoSize = true;
            this.lblPasswordComfirmed.Location = new System.Drawing.Point(24, 102);
            this.lblPasswordComfirmed.Name = "lblPasswordComfirmed";
            this.lblPasswordComfirmed.Size = new System.Drawing.Size(93, 13);
            this.lblPasswordComfirmed.TabIndex = 7;
            this.lblPasswordComfirmed.Text = "Comfirm Password";
            this.lblPasswordComfirmed.Click += new System.EventHandler(this.lblPasswordComfirmed_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(151, 69);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(121, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(151, 102);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.PasswordChar = '*';
            this.txtPassword1.Size = new System.Drawing.Size(121, 20);
            this.txtPassword1.TabIndex = 9;
            this.txtPassword1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bntSubmit
            // 
            this.bntSubmit.Location = new System.Drawing.Point(27, 259);
            this.bntSubmit.Name = "bntSubmit";
            this.bntSubmit.Size = new System.Drawing.Size(75, 23);
            this.bntSubmit.TabIndex = 11;
            this.bntSubmit.Text = "Submit";
            this.bntSubmit.UseVisualStyleBackColor = true;
            this.bntSubmit.Click += new System.EventHandler(this.bntSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(151, 258);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(154, 128);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(101, 17);
            this.chkShowPassword.TabIndex = 13;
            this.chkShowPassword.Text = "Show password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(91, 306);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmRegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 341);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.bntSubmit);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPasswordComfirmed);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.cmbRelationshipStatus);
            this.Controls.Add(this.lblRelationshipStatus);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbJobStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblName);
            this.Name = "frmRegisterUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbJobStatus;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblRelationshipStatus;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPasswordComfirmed;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Button bntSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbRelationshipStatus;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnBack;
    }
}