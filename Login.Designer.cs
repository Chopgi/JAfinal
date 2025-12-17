namespace Student2
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.loginLabel = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.visitGMHbut = new System.Windows.Forms.Button();
            this.loginBut = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(30, 20);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(30, 60);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(33, 78);
            this.usernameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(200, 20);
            this.usernameTB.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(30, 115);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(33, 133);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '●';
            this.passwordTB.Size = new System.Drawing.Size(200, 20);
            this.passwordTB.TabIndex = 2;
            // 
            // loginBut
            // 
            this.loginBut.Location = new System.Drawing.Point(33, 170);
            this.loginBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginBut.Name = "loginBut";
            this.loginBut.Size = new System.Drawing.Size(200, 23);
            this.loginBut.TabIndex = 11;
            this.loginBut.Text = "Login";
            this.loginBut.UseVisualStyleBackColor = true;
            this.loginBut.Click += new System.EventHandler(this.loginBut_Click);
            // 
            // visitGMHbut
            // 
            this.visitGMHbut.Location = new System.Drawing.Point(500, 300);
            this.visitGMHbut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visitGMHbut.Name = "visitGMHbut";
            this.visitGMHbut.Size = new System.Drawing.Size(75, 23);
            this.visitGMHbut.TabIndex = 10;
            this.visitGMHbut.Text = "GMH";
            this.visitGMHbut.UseVisualStyleBackColor = true;
            this.visitGMHbut.Click += new System.EventHandler(this.visitGMHbut_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.visitGMHbut);
            this.Controls.Add(this.loginBut);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.loginLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Health System - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button visitGMHbut;
        private System.Windows.Forms.Button loginBut;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
    }
}


