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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(84)))), ((int)(((byte)(144)))));
            this.loginLabel.Location = new System.Drawing.Point(78, 30);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(139, 62);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameLabel.Location = new System.Drawing.Point(30, 115);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(91, 23);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username";
            // 
            // usernameTB
            // 
            this.usernameTB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTB.Location = new System.Drawing.Point(34, 142);
            this.usernameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(230, 32);
            this.usernameTB.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordLabel.Location = new System.Drawing.Point(30, 192);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(80, 23);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(34, 219);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '●';
            this.passwordTB.Size = new System.Drawing.Size(230, 32);
            this.passwordTB.TabIndex = 2;
            // 
            // loginBut
            // 
            this.loginBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(84)))), ((int)(((byte)(144)))));
            this.loginBut.FlatAppearance.BorderSize = 0;
            this.loginBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBut.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBut.ForeColor = System.Drawing.Color.White;
            this.loginBut.Location = new System.Drawing.Point(34, 275);
            this.loginBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginBut.Name = "loginBut";
            this.loginBut.Size = new System.Drawing.Size(230, 45);
            this.loginBut.TabIndex = 11;
            this.loginBut.Text = "Login";
            this.loginBut.UseVisualStyleBackColor = false;
            this.loginBut.Click += new System.EventHandler(this.loginBut_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.Controls.Add(this.loginLabel);
            this.loginPanel.Controls.Add(this.loginBut);
            this.loginPanel.Controls.Add(this.usernameLabel);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.usernameTB);
            this.loginPanel.Controls.Add(this.passwordTB);
            this.loginPanel.Location = new System.Drawing.Point(250, 75);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(300, 350);
            this.loginPanel.TabIndex = 12;
            // 
            // visitGMHbut
            // 
            this.visitGMHbut.Location = new System.Drawing.Point(693, 394);
            this.visitGMHbut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visitGMHbut.Name = "visitGMHbut";
            this.visitGMHbut.Size = new System.Drawing.Size(95, 44);
            this.visitGMHbut.TabIndex = 10;
            this.visitGMHbut.Text = "GMH";
            this.visitGMHbut.UseVisualStyleBackColor = true;
            this.visitGMHbut.Click += new System.EventHandler(this.visitGMHbut_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.visitGMHbut);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Health System - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button visitGMHbut;
        private System.Windows.Forms.Button loginBut;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel loginPanel;
    }
}


