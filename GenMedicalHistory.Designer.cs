namespace Student2
{
    partial class GenMedicalHistory
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
            this.saveButGMH = new System.Windows.Forms.Button();
            this.addButGMH = new System.Windows.Forms.Button();
            this.undoButGMH = new System.Windows.Forms.Button();
            this.modifyButGMH = new System.Windows.Forms.Button();
            this.deleteButGMH = new System.Windows.Forms.Button();
            this.visitMHbut = new System.Windows.Forms.Button();
            this.visitLOGINbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveButGMH
            // 
            this.saveButGMH.Location = new System.Drawing.Point(254, 337);
            this.saveButGMH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButGMH.Name = "saveButGMH";
            this.saveButGMH.Size = new System.Drawing.Size(56, 19);
            this.saveButGMH.TabIndex = 0;
            this.saveButGMH.Text = "Save";
            this.saveButGMH.UseVisualStyleBackColor = true;
            // 
            // addButGMH
            // 
            this.addButGMH.Location = new System.Drawing.Point(96, 337);
            this.addButGMH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButGMH.Name = "addButGMH";
            this.addButGMH.Size = new System.Drawing.Size(56, 19);
            this.addButGMH.TabIndex = 1;
            this.addButGMH.Text = "Add";
            this.addButGMH.UseVisualStyleBackColor = true;
            // 
            // undoButGMH
            // 
            this.undoButGMH.Location = new System.Drawing.Point(332, 337);
            this.undoButGMH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.undoButGMH.Name = "undoButGMH";
            this.undoButGMH.Size = new System.Drawing.Size(56, 19);
            this.undoButGMH.TabIndex = 3;
            this.undoButGMH.Text = "Undo";
            this.undoButGMH.UseVisualStyleBackColor = true;
            // 
            // modifyButGMH
            // 
            this.modifyButGMH.Location = new System.Drawing.Point(175, 337);
            this.modifyButGMH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modifyButGMH.Name = "modifyButGMH";
            this.modifyButGMH.Size = new System.Drawing.Size(56, 19);
            this.modifyButGMH.TabIndex = 2;
            this.modifyButGMH.Text = "Modify";
            this.modifyButGMH.UseVisualStyleBackColor = true;
            // 
            // deleteButGMH
            // 
            this.deleteButGMH.Location = new System.Drawing.Point(411, 337);
            this.deleteButGMH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButGMH.Name = "deleteButGMH";
            this.deleteButGMH.Size = new System.Drawing.Size(56, 19);
            this.deleteButGMH.TabIndex = 4;
            this.deleteButGMH.Text = "Delete";
            this.deleteButGMH.UseVisualStyleBackColor = true;
            // 
            // visitMHbut
            // 
            this.visitMHbut.Location = new System.Drawing.Point(520, 143);
            this.visitMHbut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.visitMHbut.Name = "visitMHbut";
            this.visitMHbut.Size = new System.Drawing.Size(71, 50);
            this.visitMHbut.TabIndex = 13;
            this.visitMHbut.Text = "Medication History";
            this.visitMHbut.UseVisualStyleBackColor = true;
            this.visitMHbut.Click += new System.EventHandler(this.visitMHbut_Click);
            // 
            // visitLOGINbut
            // 
            this.visitLOGINbut.Location = new System.Drawing.Point(520, 82);
            this.visitLOGINbut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.visitLOGINbut.Name = "visitLOGINbut";
            this.visitLOGINbut.Size = new System.Drawing.Size(71, 50);
            this.visitLOGINbut.TabIndex = 12;
            this.visitLOGINbut.Text = "Login";
            this.visitLOGINbut.UseVisualStyleBackColor = true;
            this.visitLOGINbut.Click += new System.EventHandler(this.visitLOGINbut_Click);
            // 
            // GenMedicalHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.visitMHbut);
            this.Controls.Add(this.visitLOGINbut);
            this.Controls.Add(this.deleteButGMH);
            this.Controls.Add(this.undoButGMH);
            this.Controls.Add(this.modifyButGMH);
            this.Controls.Add(this.addButGMH);
            this.Controls.Add(this.saveButGMH);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GenMedicalHistory";
            this.Text = "GenMedicalHistory";
            this.Load += new System.EventHandler(this.GenMedicalHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButGMH;
        private System.Windows.Forms.Button addButGMH;
        private System.Windows.Forms.Button undoButGMH;
        private System.Windows.Forms.Button modifyButGMH;
        private System.Windows.Forms.Button deleteButGMH;
        private System.Windows.Forms.Button visitMHbut;
        private System.Windows.Forms.Button visitLOGINbut;
    }
}