namespace Student2
{
    partial class PatientDemographics
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
            this.dataGridViewPD = new System.Windows.Forms.DataGridView();
            this.visitMHbut = new System.Windows.Forms.Button();
            this.deleteButGMH = new System.Windows.Forms.Button();
            this.undoButGMH = new System.Windows.Forms.Button();
            this.modifyButGMH = new System.Windows.Forms.Button();
            this.addButGMH = new System.Windows.Forms.Button();
            this.saveButGMH = new System.Windows.Forms.Button();
            this.visitGMHbut = new System.Windows.Forms.Button();
            this.selectPatientCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPD)).BeginInit();
            this.SuspendLayout();
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
            this.nameAgeLabel.TabIndex = 26;
            this.nameAgeLabel.Text = "PatientFname, Lname, Age";
            // 
            // dataGridViewPD
            // 
            this.dataGridViewPD.AllowUserToAddRows = false;
            this.dataGridViewPD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPD.Location = new System.Drawing.Point(197, 126);
            this.dataGridViewPD.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPD.Name = "dataGridViewPD";
            this.dataGridViewPD.RowHeadersVisible = false;
            this.dataGridViewPD.RowHeadersWidth = 51;
            this.dataGridViewPD.RowTemplate.Height = 24;
            this.dataGridViewPD.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewPD.Size = new System.Drawing.Size(406, 202);
            this.dataGridViewPD.TabIndex = 25;
            // 
            // visitMHbut
            // 
            this.visitMHbut.Location = new System.Drawing.Point(718, 167);
            this.visitMHbut.Margin = new System.Windows.Forms.Padding(2);
            this.visitMHbut.Name = "visitMHbut";
            this.visitMHbut.Size = new System.Drawing.Size(71, 50);
            this.visitMHbut.TabIndex = 24;
            this.visitMHbut.Text = "Medication History";
            this.visitMHbut.UseVisualStyleBackColor = true;
            this.visitMHbut.Click += new System.EventHandler(this.visitMHbut_Click);
            // 
            // deleteButGMH
            // 
            this.deleteButGMH.Location = new System.Drawing.Point(530, 420);
            this.deleteButGMH.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButGMH.Name = "deleteButGMH";
            this.deleteButGMH.Size = new System.Drawing.Size(56, 19);
            this.deleteButGMH.TabIndex = 23;
            this.deleteButGMH.Text = "Delete";
            this.deleteButGMH.UseVisualStyleBackColor = true;
            // 
            // undoButGMH
            // 
            this.undoButGMH.Location = new System.Drawing.Point(451, 420);
            this.undoButGMH.Margin = new System.Windows.Forms.Padding(2);
            this.undoButGMH.Name = "undoButGMH";
            this.undoButGMH.Size = new System.Drawing.Size(56, 19);
            this.undoButGMH.TabIndex = 22;
            this.undoButGMH.Text = "Undo";
            this.undoButGMH.UseVisualStyleBackColor = true;
            // 
            // modifyButGMH
            // 
            this.modifyButGMH.Location = new System.Drawing.Point(294, 420);
            this.modifyButGMH.Margin = new System.Windows.Forms.Padding(2);
            this.modifyButGMH.Name = "modifyButGMH";
            this.modifyButGMH.Size = new System.Drawing.Size(56, 19);
            this.modifyButGMH.TabIndex = 21;
            this.modifyButGMH.Text = "Modify";
            this.modifyButGMH.UseVisualStyleBackColor = true;
            // 
            // addButGMH
            // 
            this.addButGMH.Location = new System.Drawing.Point(215, 420);
            this.addButGMH.Margin = new System.Windows.Forms.Padding(2);
            this.addButGMH.Name = "addButGMH";
            this.addButGMH.Size = new System.Drawing.Size(56, 19);
            this.addButGMH.TabIndex = 20;
            this.addButGMH.Text = "Add";
            this.addButGMH.UseVisualStyleBackColor = true;
            // 
            // saveButGMH
            // 
            this.saveButGMH.Location = new System.Drawing.Point(373, 420);
            this.saveButGMH.Margin = new System.Windows.Forms.Padding(2);
            this.saveButGMH.Name = "saveButGMH";
            this.saveButGMH.Size = new System.Drawing.Size(56, 19);
            this.saveButGMH.TabIndex = 19;
            this.saveButGMH.Text = "Save";
            this.saveButGMH.UseVisualStyleBackColor = true;
            // 
            // visitGMHbut
            // 
            this.visitGMHbut.Location = new System.Drawing.Point(718, 234);
            this.visitGMHbut.Margin = new System.Windows.Forms.Padding(2);
            this.visitGMHbut.Name = "visitGMHbut";
            this.visitGMHbut.Size = new System.Drawing.Size(71, 50);
            this.visitGMHbut.TabIndex = 27;
            this.visitGMHbut.Text = "General Medical History";
            this.visitGMHbut.UseVisualStyleBackColor = true;
            this.visitGMHbut.Click += new System.EventHandler(this.visitGMHbut_Click);
            // 
            // selectPatientCB
            // 
            this.selectPatientCB.FormattingEnabled = true;
            this.selectPatientCB.Location = new System.Drawing.Point(77, 79);
            this.selectPatientCB.Name = "selectPatientCB";
            this.selectPatientCB.Size = new System.Drawing.Size(121, 21);
            this.selectPatientCB.TabIndex = 28;
            this.selectPatientCB.Text = "--Select Patient --";
            // 
            // PatientDemographics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectPatientCB);
            this.Controls.Add(this.visitGMHbut);
            this.Controls.Add(this.nameAgeLabel);
            this.Controls.Add(this.dataGridViewPD);
            this.Controls.Add(this.visitMHbut);
            this.Controls.Add(this.deleteButGMH);
            this.Controls.Add(this.undoButGMH);
            this.Controls.Add(this.modifyButGMH);
            this.Controls.Add(this.addButGMH);
            this.Controls.Add(this.saveButGMH);
            this.Name = "PatientDemographics";
            this.Text = "PatientDemographics";
            this.Load += new System.EventHandler(this.PatientDemographics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameAgeLabel;
        private System.Windows.Forms.DataGridView dataGridViewPD;
        private System.Windows.Forms.Button visitMHbut;
        private System.Windows.Forms.Button deleteButGMH;
        private System.Windows.Forms.Button undoButGMH;
        private System.Windows.Forms.Button modifyButGMH;
        private System.Windows.Forms.Button addButGMH;
        private System.Windows.Forms.Button saveButGMH;
        private System.Windows.Forms.Button visitGMHbut;
        private System.Windows.Forms.ComboBox selectPatientCB;
    }
}