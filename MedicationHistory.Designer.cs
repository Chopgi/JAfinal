namespace Student2
{
    partial class MedicationHistory
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
            this.deleteButMH = new System.Windows.Forms.Button();
            this.undoButMH = new System.Windows.Forms.Button();
            this.modifyButMH = new System.Windows.Forms.Button();
            this.addButMH = new System.Windows.Forms.Button();
            this.saveButMH = new System.Windows.Forms.Button();
            this.visitLOGINbut = new System.Windows.Forms.Button();
            this.visitGMHbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteButMH
            // 
            this.deleteButMH.Location = new System.Drawing.Point(422, 337);
            this.deleteButMH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButMH.Name = "deleteButMH";
            this.deleteButMH.Size = new System.Drawing.Size(56, 19);
            this.deleteButMH.TabIndex = 9;
            this.deleteButMH.Text = "Delete";
            this.deleteButMH.UseVisualStyleBackColor = true;
            // 
            // undoButMH
            // 
            this.undoButMH.Location = new System.Drawing.Point(343, 337);
            this.undoButMH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.undoButMH.Name = "undoButMH";
            this.undoButMH.Size = new System.Drawing.Size(56, 19);
            this.undoButMH.TabIndex = 8;
            this.undoButMH.Text = "Undo";
            this.undoButMH.UseVisualStyleBackColor = true;
            // 
            // modifyButMH
            // 
            this.modifyButMH.Location = new System.Drawing.Point(185, 337);
            this.modifyButMH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modifyButMH.Name = "modifyButMH";
            this.modifyButMH.Size = new System.Drawing.Size(56, 19);
            this.modifyButMH.TabIndex = 7;
            this.modifyButMH.Text = "Modify";
            this.modifyButMH.UseVisualStyleBackColor = true;
            // 
            // addButMH
            // 
            this.addButMH.Location = new System.Drawing.Point(106, 337);
            this.addButMH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButMH.Name = "addButMH";
            this.addButMH.Size = new System.Drawing.Size(56, 19);
            this.addButMH.TabIndex = 6;
            this.addButMH.Text = "Add";
            this.addButMH.UseVisualStyleBackColor = true;
            // 
            // saveButMH
            // 
            this.saveButMH.Location = new System.Drawing.Point(264, 337);
            this.saveButMH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButMH.Name = "saveButMH";
            this.saveButMH.Size = new System.Drawing.Size(56, 19);
            this.saveButMH.TabIndex = 5;
            this.saveButMH.Text = "Save";
            this.saveButMH.UseVisualStyleBackColor = true;
            // 
            // visitLOGINbut
            // 
            this.visitLOGINbut.Location = new System.Drawing.Point(520, 78);
            this.visitLOGINbut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.visitLOGINbut.Name = "visitLOGINbut";
            this.visitLOGINbut.Size = new System.Drawing.Size(71, 50);
            this.visitLOGINbut.TabIndex = 14;
            this.visitLOGINbut.Text = "Login";
            this.visitLOGINbut.UseVisualStyleBackColor = true;
            this.visitLOGINbut.Click += new System.EventHandler(this.visitLOGINbut_Click);
            // 
            // visitGMHbut
            // 
            this.visitGMHbut.Location = new System.Drawing.Point(520, 132);
            this.visitGMHbut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.visitGMHbut.Name = "visitGMHbut";
            this.visitGMHbut.Size = new System.Drawing.Size(71, 50);
            this.visitGMHbut.TabIndex = 15;
            this.visitGMHbut.Text = "General Medical History";
            this.visitGMHbut.UseVisualStyleBackColor = true;
            this.visitGMHbut.Click += new System.EventHandler(this.visitGMHbut_Click);
            // 
            // MedicationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.visitGMHbut);
            this.Controls.Add(this.visitLOGINbut);
            this.Controls.Add(this.deleteButMH);
            this.Controls.Add(this.undoButMH);
            this.Controls.Add(this.modifyButMH);
            this.Controls.Add(this.addButMH);
            this.Controls.Add(this.saveButMH);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MedicationHistory";
            this.Text = "MedHistory";
            this.Load += new System.EventHandler(this.MedicationHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteButMH;
        private System.Windows.Forms.Button undoButMH;
        private System.Windows.Forms.Button modifyButMH;
        private System.Windows.Forms.Button addButMH;
        private System.Windows.Forms.Button saveButMH;
        private System.Windows.Forms.Button visitLOGINbut;
        private System.Windows.Forms.Button visitGMHbut;
    }
}