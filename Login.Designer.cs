namespace Student2
{
    partial class Login
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.addReportBut = new System.Windows.Forms.Button();
            this.addLogBut = new System.Windows.Forms.Button();
            this.deleteButLogin = new System.Windows.Forms.Button();
            this.undoButLogin = new System.Windows.Forms.Button();
            this.modifyButLogin = new System.Windows.Forms.Button();
            this.addButLogin = new System.Windows.Forms.Button();
            this.saveButLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(341, 38);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(40, 16);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(312, 185);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(100, 22);
            this.usernameTB.TabIndex = 1;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(312, 245);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '●';
            this.passwordTB.Size = new System.Drawing.Size(100, 22);
            this.passwordTB.TabIndex = 2;
            // 
            // addReportBut
            // 
            this.addReportBut.Location = new System.Drawing.Point(225, 337);
            this.addReportBut.Name = "addReportBut";
            this.addReportBut.Size = new System.Drawing.Size(95, 50);
            this.addReportBut.TabIndex = 3;
            this.addReportBut.Text = "Add Report";
            this.addReportBut.UseVisualStyleBackColor = true;
            // 
            // addLogBut
            // 
            this.addLogBut.Location = new System.Drawing.Point(425, 337);
            this.addLogBut.Name = "addLogBut";
            this.addLogBut.Size = new System.Drawing.Size(95, 50);
            this.addLogBut.TabIndex = 4;
            this.addLogBut.Text = "Add Log File";
            this.addLogBut.UseVisualStyleBackColor = true;
            // 
            // deleteButLogin
            // 
            this.deleteButLogin.Location = new System.Drawing.Point(547, 415);
            this.deleteButLogin.Name = "deleteButLogin";
            this.deleteButLogin.Size = new System.Drawing.Size(75, 23);
            this.deleteButLogin.TabIndex = 9;
            this.deleteButLogin.Text = "Delete";
            this.deleteButLogin.UseVisualStyleBackColor = true;
            // 
            // undoButLogin
            // 
            this.undoButLogin.Location = new System.Drawing.Point(442, 415);
            this.undoButLogin.Name = "undoButLogin";
            this.undoButLogin.Size = new System.Drawing.Size(75, 23);
            this.undoButLogin.TabIndex = 8;
            this.undoButLogin.Text = "Undo";
            this.undoButLogin.UseVisualStyleBackColor = true;
            // 
            // modifyButLogin
            // 
            this.modifyButLogin.Location = new System.Drawing.Point(232, 415);
            this.modifyButLogin.Name = "modifyButLogin";
            this.modifyButLogin.Size = new System.Drawing.Size(75, 23);
            this.modifyButLogin.TabIndex = 7;
            this.modifyButLogin.Text = "Modify";
            this.modifyButLogin.UseVisualStyleBackColor = true;
            // 
            // addButLogin
            // 
            this.addButLogin.Location = new System.Drawing.Point(127, 415);
            this.addButLogin.Name = "addButLogin";
            this.addButLogin.Size = new System.Drawing.Size(75, 23);
            this.addButLogin.TabIndex = 6;
            this.addButLogin.Text = "Add";
            this.addButLogin.UseVisualStyleBackColor = true;
            // 
            // saveButLogin
            // 
            this.saveButLogin.Location = new System.Drawing.Point(337, 415);
            this.saveButLogin.Name = "saveButLogin";
            this.saveButLogin.Size = new System.Drawing.Size(75, 23);
            this.saveButLogin.TabIndex = 5;
            this.saveButLogin.Text = "Save";
            this.saveButLogin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButLogin);
            this.Controls.Add(this.undoButLogin);
            this.Controls.Add(this.modifyButLogin);
            this.Controls.Add(this.addButLogin);
            this.Controls.Add(this.saveButLogin);
            this.Controls.Add(this.addLogBut);
            this.Controls.Add(this.addReportBut);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.loginLabel);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button addReportBut;
        private System.Windows.Forms.Button addLogBut;
        private System.Windows.Forms.Button deleteButLogin;
        private System.Windows.Forms.Button undoButLogin;
        private System.Windows.Forms.Button modifyButLogin;
        private System.Windows.Forms.Button addButLogin;
        private System.Windows.Forms.Button saveButLogin;
    }
}

