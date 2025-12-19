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
            this.dataGridViewGMH = new System.Windows.Forms.DataGridView();
            this.nameAgeLabel = new System.Windows.Forms.Label();
            this.visitPDbut = new System.Windows.Forms.Button();
            this.visitIHbut = new System.Windows.Forms.Button();
            this.selectPatientCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGMH)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButGMH
            // 
            this.saveButGMH.Location = new System.Drawing.Point(273, 337);
            this.saveButGMH.Margin = new System.Windows.Forms.Padding(2);
            this.saveButGMH.Name = "saveButGMH";
            this.saveButGMH.Size = new System.Drawing.Size(56, 19);
            this.saveButGMH.TabIndex = 0;
            this.saveButGMH.Text = "Save";
            this.saveButGMH.UseVisualStyleBackColor = true;
            // 
            // addButGMH
            // 
            this.addButGMH.Location = new System.Drawing.Point(115, 337);
            this.addButGMH.Margin = new System.Windows.Forms.Padding(2);
            this.addButGMH.Name = "addButGMH";
            this.addButGMH.Size = new System.Drawing.Size(56, 19);
            this.addButGMH.TabIndex = 1;
            this.addButGMH.Text = "Add";
            this.addButGMH.UseVisualStyleBackColor = true;
            // 
            // undoButGMH
            // 
            this.undoButGMH.Location = new System.Drawing.Point(351, 337);
            this.undoButGMH.Margin = new System.Windows.Forms.Padding(2);
            this.undoButGMH.Name = "undoButGMH";
            this.undoButGMH.Size = new System.Drawing.Size(56, 19);
            this.undoButGMH.TabIndex = 3;
            this.undoButGMH.Text = "Undo";
            this.undoButGMH.UseVisualStyleBackColor = true;
            // 
            // modifyButGMH
            // 
            this.modifyButGMH.Location = new System.Drawing.Point(194, 337);
            this.modifyButGMH.Margin = new System.Windows.Forms.Padding(2);
            this.modifyButGMH.Name = "modifyButGMH";
            this.modifyButGMH.Size = new System.Drawing.Size(56, 19);
            this.modifyButGMH.TabIndex = 2;
            this.modifyButGMH.Text = "Modify";
            this.modifyButGMH.UseVisualStyleBackColor = true;
            // 
            // deleteButGMH
            // 
            this.deleteButGMH.Location = new System.Drawing.Point(430, 337);
            this.deleteButGMH.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButGMH.Name = "deleteButGMH";
            this.deleteButGMH.Size = new System.Drawing.Size(56, 19);
            this.deleteButGMH.TabIndex = 4;
            this.deleteButGMH.Text = "Delete";
            this.deleteButGMH.UseVisualStyleBackColor = true;
            // 
            // visitMHbut
            // 
            this.visitMHbut.Location = new System.Drawing.Point(520, 158);
            this.visitMHbut.Margin = new System.Windows.Forms.Padding(2);
            this.visitMHbut.Name = "visitMHbut";
            this.visitMHbut.Size = new System.Drawing.Size(71, 50);
            this.visitMHbut.TabIndex = 13;
            this.visitMHbut.Text = "Medication History";
            this.visitMHbut.UseVisualStyleBackColor = true;
            this.visitMHbut.Click += new System.EventHandler(this.visitMHbut_Click);
            // 
            // dataGridViewGMH
            // 
            this.dataGridViewGMH.AllowUserToAddRows = false;
            this.dataGridViewGMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGMH.Location = new System.Drawing.Point(97, 82);
            this.dataGridViewGMH.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewGMH.Name = "dataGridViewGMH";
            this.dataGridViewGMH.RowHeadersVisible = false;
            this.dataGridViewGMH.RowHeadersWidth = 51;
            this.dataGridViewGMH.RowTemplate.Height = 24;
            this.dataGridViewGMH.Size = new System.Drawing.Size(406, 202);
            this.dataGridViewGMH.TabIndex = 17;
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
            this.nameAgeLabel.TabIndex = 18;
            this.nameAgeLabel.Text = "PatientFname, Lname, Age";
            // 
            // visitPDbut
            // 
            this.visitPDbut.Location = new System.Drawing.Point(520, 104);
            this.visitPDbut.Margin = new System.Windows.Forms.Padding(2);
            this.visitPDbut.Name = "visitPDbut";
            this.visitPDbut.Size = new System.Drawing.Size(71, 50);
            this.visitPDbut.TabIndex = 19;
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
            this.visitIHbut.TabIndex = 20;
            this.visitIHbut.Text = "Immunization History";
            this.visitIHbut.UseVisualStyleBackColor = true;
            this.visitIHbut.Click += new System.EventHandler(this.visitIHbut_Click);
            // 
            // selectPatientCB
            // 
            this.selectPatientCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectPatientCB.FormattingEnabled = true;
            this.selectPatientCB.Location = new System.Drawing.Point(14, 56);
            this.selectPatientCB.Name = "selectPatientCB";
            this.selectPatientCB.Size = new System.Drawing.Size(170, 21);
            this.selectPatientCB.TabIndex = 29;
            this.selectPatientCB.SelectionChangeCommitted += new System.EventHandler(this.selectPatientCB_SelectionChangeCommitted);
            // 
            // GenMedicalHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.selectPatientCB);
            this.Controls.Add(this.visitIHbut);
            this.Controls.Add(this.visitPDbut);
            this.Controls.Add(this.nameAgeLabel);
            this.Controls.Add(this.dataGridViewGMH);
            this.Controls.Add(this.visitMHbut);
            this.Controls.Add(this.deleteButGMH);
            this.Controls.Add(this.undoButGMH);
            this.Controls.Add(this.modifyButGMH);
            this.Controls.Add(this.addButGMH);
            this.Controls.Add(this.saveButGMH);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GenMedicalHistory";
            this.Text = "GenMedicalHistory";
            this.Load += new System.EventHandler(this.GenMedicalHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButGMH;
        private System.Windows.Forms.Button addButGMH;
        private System.Windows.Forms.Button undoButGMH;
        private System.Windows.Forms.Button modifyButGMH;
        private System.Windows.Forms.Button deleteButGMH;
        private System.Windows.Forms.Button visitMHbut;
        private System.Windows.Forms.DataGridView dataGridViewGMH;
        private System.Windows.Forms.Label nameAgeLabel;
        private System.Windows.Forms.Button visitPDbut;
        private System.Windows.Forms.Button visitIHbut;
        private System.Windows.Forms.ComboBox selectPatientCB;
    }
}