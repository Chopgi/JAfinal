namespace Student2
{
    partial class ImmunizationHistory
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
            this.visitPDbut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameAgeLabel = new System.Windows.Forms.Label();
            this.visitGMHbut = new System.Windows.Forms.Button();
            this.deleteButMH = new System.Windows.Forms.Button();
            this.undoButMH = new System.Windows.Forms.Button();
            this.modifyButMH = new System.Windows.Forms.Button();
            this.addButMH = new System.Windows.Forms.Button();
            this.saveButMH = new System.Windows.Forms.Button();
            this.visitMHbut = new System.Windows.Forms.Button();
            this.selectPatientCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // visitPDbut
            // 
            this.visitPDbut.Location = new System.Drawing.Point(718, 176);
            this.visitPDbut.Margin = new System.Windows.Forms.Padding(2);
            this.visitPDbut.Name = "visitPDbut";
            this.visitPDbut.Size = new System.Drawing.Size(71, 50);
            this.visitPDbut.TabIndex = 27;
            this.visitPDbut.Text = "Patient Demographics";
            this.visitPDbut.UseVisualStyleBackColor = true;
            this.visitPDbut.Click += new System.EventHandler(this.visitPDbut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(615, 221);
            this.dataGridView1.TabIndex = 26;
            // 
            // nameAgeLabel
            // 
            this.nameAgeLabel.AutoSize = true;
            this.nameAgeLabel.BackColor = System.Drawing.Color.Gold;
            this.nameAgeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameAgeLabel.Location = new System.Drawing.Point(11, 9);
            this.nameAgeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameAgeLabel.Name = "nameAgeLabel";
            this.nameAgeLabel.Size = new System.Drawing.Size(289, 29);
            this.nameAgeLabel.TabIndex = 25;
            this.nameAgeLabel.Text = "PatientFname, Lname, Age";
            // 
            // visitGMHbut
            // 
            this.visitGMHbut.Location = new System.Drawing.Point(718, 230);
            this.visitGMHbut.Margin = new System.Windows.Forms.Padding(2);
            this.visitGMHbut.Name = "visitGMHbut";
            this.visitGMHbut.Size = new System.Drawing.Size(71, 50);
            this.visitGMHbut.TabIndex = 24;
            this.visitGMHbut.Text = "General Medical History";
            this.visitGMHbut.UseVisualStyleBackColor = true;
            this.visitGMHbut.Click += new System.EventHandler(this.visitGMHbut_Click);
            // 
            // deleteButMH
            // 
            this.deleteButMH.Location = new System.Drawing.Point(530, 420);
            this.deleteButMH.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButMH.Name = "deleteButMH";
            this.deleteButMH.Size = new System.Drawing.Size(56, 19);
            this.deleteButMH.TabIndex = 23;
            this.deleteButMH.Text = "Delete";
            this.deleteButMH.UseVisualStyleBackColor = true;
            this.deleteButMH.Click += new System.EventHandler(this.deleteButMH_Click);
            // 
            // undoButMH
            // 
            this.undoButMH.Location = new System.Drawing.Point(451, 420);
            this.undoButMH.Margin = new System.Windows.Forms.Padding(2);
            this.undoButMH.Name = "undoButMH";
            this.undoButMH.Size = new System.Drawing.Size(56, 19);
            this.undoButMH.TabIndex = 22;
            this.undoButMH.Text = "Undo";
            this.undoButMH.UseVisualStyleBackColor = true;
            // 
            // modifyButMH
            // 
            this.modifyButMH.Location = new System.Drawing.Point(294, 420);
            this.modifyButMH.Margin = new System.Windows.Forms.Padding(2);
            this.modifyButMH.Name = "modifyButMH";
            this.modifyButMH.Size = new System.Drawing.Size(56, 19);
            this.modifyButMH.TabIndex = 21;
            this.modifyButMH.Text = "Modify";
            this.modifyButMH.UseVisualStyleBackColor = true;
            // 
            // addButMH
            // 
            this.addButMH.Location = new System.Drawing.Point(214, 420);
            this.addButMH.Margin = new System.Windows.Forms.Padding(2);
            this.addButMH.Name = "addButMH";
            this.addButMH.Size = new System.Drawing.Size(56, 19);
            this.addButMH.TabIndex = 20;
            this.addButMH.Text = "Add";
            this.addButMH.UseVisualStyleBackColor = true;
            this.addButMH.Click += new System.EventHandler(this.addButMH_Click);
            // 
            // saveButMH
            // 
            this.saveButMH.Location = new System.Drawing.Point(372, 420);
            this.saveButMH.Margin = new System.Windows.Forms.Padding(2);
            this.saveButMH.Name = "saveButMH";
            this.saveButMH.Size = new System.Drawing.Size(56, 19);
            this.saveButMH.TabIndex = 19;
            this.saveButMH.Text = "Save";
            this.saveButMH.UseVisualStyleBackColor = true;
            // 
            // visitMHbut
            // 
            this.visitMHbut.Location = new System.Drawing.Point(718, 122);
            this.visitMHbut.Margin = new System.Windows.Forms.Padding(2);
            this.visitMHbut.Name = "visitMHbut";
            this.visitMHbut.Size = new System.Drawing.Size(71, 50);
            this.visitMHbut.TabIndex = 29;
            this.visitMHbut.Text = "Medication History";
            this.visitMHbut.UseVisualStyleBackColor = true;
            this.visitMHbut.Click += new System.EventHandler(this.visitMHbut_Click);
            // 
            // selectPatientCB
            // 
            this.selectPatientCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectPatientCB.FormattingEnabled = true;
            this.selectPatientCB.Location = new System.Drawing.Point(42, 82);
            this.selectPatientCB.Name = "selectPatientCB";
            this.selectPatientCB.Size = new System.Drawing.Size(170, 21);
            this.selectPatientCB.TabIndex = 30;
            this.selectPatientCB.SelectionChangeCommitted += new System.EventHandler(this.selectPatientCB_SelectionChangeCommitted);
            // 
            // ImmunizationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectPatientCB);
            this.Controls.Add(this.visitMHbut);
            this.Controls.Add(this.visitPDbut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nameAgeLabel);
            this.Controls.Add(this.visitGMHbut);
            this.Controls.Add(this.deleteButMH);
            this.Controls.Add(this.undoButMH);
            this.Controls.Add(this.modifyButMH);
            this.Controls.Add(this.addButMH);
            this.Controls.Add(this.saveButMH);
            this.Name = "ImmunizationHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImmunizationHistory";
            this.Load += new System.EventHandler(this.ImmunizationHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button visitPDbut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label nameAgeLabel;
        private System.Windows.Forms.Button visitGMHbut;
        private System.Windows.Forms.Button deleteButMH;
        private System.Windows.Forms.Button undoButMH;
        private System.Windows.Forms.Button modifyButMH;
        private System.Windows.Forms.Button addButMH;
        private System.Windows.Forms.Button saveButMH;
        private System.Windows.Forms.Button visitMHbut;
        private System.Windows.Forms.ComboBox selectPatientCB;
    }
}