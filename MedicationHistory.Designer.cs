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
            this.visitGMHbut = new System.Windows.Forms.Button();
            this.nameAgeLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.visitPDbut = new System.Windows.Forms.Button();
            this.visitIHbut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButMH
            // 
            this.deleteButMH.Location = new System.Drawing.Point(430, 337);
            this.deleteButMH.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButMH.Name = "deleteButMH";
            this.deleteButMH.Size = new System.Drawing.Size(56, 19);
            this.deleteButMH.TabIndex = 9;
            this.deleteButMH.Text = "Delete";
            this.deleteButMH.UseVisualStyleBackColor = true;
            // 
            // undoButMH
            // 
            this.undoButMH.Location = new System.Drawing.Point(351, 337);
            this.undoButMH.Margin = new System.Windows.Forms.Padding(2);
            this.undoButMH.Name = "undoButMH";
            this.undoButMH.Size = new System.Drawing.Size(56, 19);
            this.undoButMH.TabIndex = 8;
            this.undoButMH.Text = "Undo";
            this.undoButMH.UseVisualStyleBackColor = true;
            // 
            // modifyButMH
            // 
            this.modifyButMH.Location = new System.Drawing.Point(194, 337);
            this.modifyButMH.Margin = new System.Windows.Forms.Padding(2);
            this.modifyButMH.Name = "modifyButMH";
            this.modifyButMH.Size = new System.Drawing.Size(56, 19);
            this.modifyButMH.TabIndex = 7;
            this.modifyButMH.Text = "Modify";
            this.modifyButMH.UseVisualStyleBackColor = true;
            // 
            // addButMH
            // 
            this.addButMH.Location = new System.Drawing.Point(114, 337);
            this.addButMH.Margin = new System.Windows.Forms.Padding(2);
            this.addButMH.Name = "addButMH";
            this.addButMH.Size = new System.Drawing.Size(56, 19);
            this.addButMH.TabIndex = 6;
            this.addButMH.Text = "Add";
            this.addButMH.UseVisualStyleBackColor = true;
            // 
            // saveButMH
            // 
            this.saveButMH.Location = new System.Drawing.Point(272, 337);
            this.saveButMH.Margin = new System.Windows.Forms.Padding(2);
            this.saveButMH.Name = "saveButMH";
            this.saveButMH.Size = new System.Drawing.Size(56, 19);
            this.saveButMH.TabIndex = 5;
            this.saveButMH.Text = "Save";
            this.saveButMH.UseVisualStyleBackColor = true;
            // 
            // visitGMHbut
            // 
            this.visitGMHbut.Location = new System.Drawing.Point(520, 158);
            this.visitGMHbut.Margin = new System.Windows.Forms.Padding(2);
            this.visitGMHbut.Name = "visitGMHbut";
            this.visitGMHbut.Size = new System.Drawing.Size(71, 50);
            this.visitGMHbut.TabIndex = 15;
            this.visitGMHbut.Text = "General Medical History";
            this.visitGMHbut.UseVisualStyleBackColor = true;
            this.visitGMHbut.Click += new System.EventHandler(this.visitGMHbut_Click);
            // 
            // nameAgeLabel
            // 
            this.nameAgeLabel.AutoSize = true;
            this.nameAgeLabel.BackColor = System.Drawing.Color.Gold;
            this.nameAgeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameAgeLabel.Location = new System.Drawing.Point(9, 7);
            this.nameAgeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameAgeLabel.Name = "nameAgeLabel";
            this.nameAgeLabel.Size = new System.Drawing.Size(289, 29);
            this.nameAgeLabel.TabIndex = 16;
            this.nameAgeLabel.Text = "PatientFname, Lname, Age";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(398, 139);
            this.dataGridView1.TabIndex = 17;
            // 
            // visitPDbut
            // 
            this.visitPDbut.Location = new System.Drawing.Point(520, 104);
            this.visitPDbut.Margin = new System.Windows.Forms.Padding(2);
            this.visitPDbut.Name = "visitPDbut";
            this.visitPDbut.Size = new System.Drawing.Size(71, 50);
            this.visitPDbut.TabIndex = 18;
            this.visitPDbut.Text = "Patient Demographics";
            this.visitPDbut.UseVisualStyleBackColor = true;
            this.visitPDbut.Click += new System.EventHandler(this.visitPDbut_Click);
            // 
            // visitIHbut
            // 
            this.visitIHbut.Location = new System.Drawing.Point(520, 212);
            this.visitIHbut.Margin = new System.Windows.Forms.Padding(2);
            this.visitIHbut.Name = "visitIHbut";
            this.visitIHbut.Size = new System.Drawing.Size(71, 50);
            this.visitIHbut.TabIndex = 21;
            this.visitIHbut.Text = "Immunization History";
            this.visitIHbut.UseVisualStyleBackColor = true;
            this.visitIHbut.Click += new System.EventHandler(this.visitIHbut_Click);
            // 
            // MedicationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.visitIHbut);
            this.Controls.Add(this.visitPDbut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nameAgeLabel);
            this.Controls.Add(this.visitGMHbut);
            this.Controls.Add(this.deleteButMH);
            this.Controls.Add(this.undoButMH);
            this.Controls.Add(this.modifyButMH);
            this.Controls.Add(this.addButMH);
            this.Controls.Add(this.saveButMH);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MedicationHistory";
            this.Text = "MedHistory";
            this.Load += new System.EventHandler(this.MedicationHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButMH;
        private System.Windows.Forms.Button undoButMH;
        private System.Windows.Forms.Button modifyButMH;
        private System.Windows.Forms.Button addButMH;
        private System.Windows.Forms.Button saveButMH;
        private System.Windows.Forms.Button visitGMHbut;
        private System.Windows.Forms.Label nameAgeLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button visitPDbut;
        private System.Windows.Forms.Button visitIHbut;
    }
}