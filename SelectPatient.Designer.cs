namespace Student2
{
    partial class SelectPatient
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
            this.nameAgeLabel = new System.Windows.Forms.Label();
            this.deleteButGMH = new System.Windows.Forms.Button();
            this.undoButGMH = new System.Windows.Forms.Button();
            this.modifyButGMH = new System.Windows.Forms.Button();
            this.addButGMH = new System.Windows.Forms.Button();
            this.saveButGMH = new System.Windows.Forms.Button();
            this.visitPDbut = new System.Windows.Forms.Button();
            this.listBoxSP = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nameAgeLabel
            // 
            this.nameAgeLabel.AutoSize = true;
            this.nameAgeLabel.BackColor = System.Drawing.Color.Yellow;
            this.nameAgeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameAgeLabel.Location = new System.Drawing.Point(9, 7);
            this.nameAgeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameAgeLabel.Name = "nameAgeLabel";
            this.nameAgeLabel.Size = new System.Drawing.Size(289, 29);
            this.nameAgeLabel.TabIndex = 19;
            this.nameAgeLabel.Text = "PatientFname, Lname, Age";
            // 
            // deleteButGMH
            // 
            this.deleteButGMH.Location = new System.Drawing.Point(530, 420);
            this.deleteButGMH.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButGMH.Name = "deleteButGMH";
            this.deleteButGMH.Size = new System.Drawing.Size(56, 19);
            this.deleteButGMH.TabIndex = 24;
            this.deleteButGMH.Text = "Delete";
            this.deleteButGMH.UseVisualStyleBackColor = true;
            this.deleteButGMH.Click += new System.EventHandler(this.deleteButGMH_Click);
            // 
            // undoButGMH
            // 
            this.undoButGMH.Location = new System.Drawing.Point(451, 420);
            this.undoButGMH.Margin = new System.Windows.Forms.Padding(2);
            this.undoButGMH.Name = "undoButGMH";
            this.undoButGMH.Size = new System.Drawing.Size(56, 19);
            this.undoButGMH.TabIndex = 23;
            this.undoButGMH.Text = "Undo";
            this.undoButGMH.UseVisualStyleBackColor = true;
            this.undoButGMH.Click += new System.EventHandler(this.undoButGMH_Click);
            // 
            // modifyButGMH
            // 
            this.modifyButGMH.Location = new System.Drawing.Point(294, 420);
            this.modifyButGMH.Margin = new System.Windows.Forms.Padding(2);
            this.modifyButGMH.Name = "modifyButGMH";
            this.modifyButGMH.Size = new System.Drawing.Size(56, 19);
            this.modifyButGMH.TabIndex = 22;
            this.modifyButGMH.Text = "Modify";
            this.modifyButGMH.UseVisualStyleBackColor = true;
            this.modifyButGMH.Click += new System.EventHandler(this.modifyButGMH_Click);
            // 
            // addButGMH
            // 
            this.addButGMH.Location = new System.Drawing.Point(215, 420);
            this.addButGMH.Margin = new System.Windows.Forms.Padding(2);
            this.addButGMH.Name = "addButGMH";
            this.addButGMH.Size = new System.Drawing.Size(56, 19);
            this.addButGMH.TabIndex = 21;
            this.addButGMH.Text = "Add";
            this.addButGMH.UseVisualStyleBackColor = true;
            this.addButGMH.Click += new System.EventHandler(this.addButGMH_Click);
            // 
            // saveButGMH
            // 
            this.saveButGMH.Location = new System.Drawing.Point(373, 420);
            this.saveButGMH.Margin = new System.Windows.Forms.Padding(2);
            this.saveButGMH.Name = "saveButGMH";
            this.saveButGMH.Size = new System.Drawing.Size(56, 19);
            this.saveButGMH.TabIndex = 20;
            this.saveButGMH.Text = "Save";
            this.saveButGMH.UseVisualStyleBackColor = true;
            this.saveButGMH.Click += new System.EventHandler(this.saveButGMH_Click);
            // 
            // visitPDbut
            // 
            this.visitPDbut.Location = new System.Drawing.Point(356, 353);
            this.visitPDbut.Margin = new System.Windows.Forms.Padding(2);
            this.visitPDbut.Name = "visitPDbut";
            this.visitPDbut.Size = new System.Drawing.Size(89, 50);
            this.visitPDbut.TabIndex = 25;
            this.visitPDbut.Text = "Patient Demographics";
            this.visitPDbut.UseVisualStyleBackColor = true;
            this.visitPDbut.Click += new System.EventHandler(this.visitPDbut_Click);
            // 
            // listBoxSP
            // 
            this.listBoxSP.FormattingEnabled = true;
            this.listBoxSP.Location = new System.Drawing.Point(84, 113);
            this.listBoxSP.Name = "listBoxSP";
            this.listBoxSP.Size = new System.Drawing.Size(631, 186);
            this.listBoxSP.TabIndex = 26;
            this.listBoxSP.SelectedIndexChanged += new System.EventHandler(this.listBoxSP_SelectedIndexChanged);
            // 
            // SelectPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxSP);
            this.Controls.Add(this.visitPDbut);
            this.Controls.Add(this.deleteButGMH);
            this.Controls.Add(this.undoButGMH);
            this.Controls.Add(this.modifyButGMH);
            this.Controls.Add(this.addButGMH);
            this.Controls.Add(this.saveButGMH);
            this.Controls.Add(this.nameAgeLabel);
            this.Name = "SelectPatient";
            this.Text = "SelectPatient";
            this.Load += new System.EventHandler(this.SelectPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameAgeLabel;
        private System.Windows.Forms.Button deleteButGMH;
        private System.Windows.Forms.Button undoButGMH;
        private System.Windows.Forms.Button modifyButGMH;
        private System.Windows.Forms.Button addButGMH;
        private System.Windows.Forms.Button saveButGMH;
        private System.Windows.Forms.Button visitPDbut;
        private System.Windows.Forms.ListBox listBoxSP;
    }
}