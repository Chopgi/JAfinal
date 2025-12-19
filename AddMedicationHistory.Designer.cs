namespace Student2
{
    partial class AddMedicationHistory
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
            this.cancelBut = new System.Windows.Forms.Button();
            this.saveBut = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.instructionsTB = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.prescriptionHCPTB = new System.Windows.Forms.TextBox();
            this.MedEDdatePicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.MedSDdatePicker = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.medUnitTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.medAmtTB = new System.Windows.Forms.TextBox();
            this.medicationTB = new System.Windows.Forms.TextBox();
            this.addMHTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelBut
            // 
            this.cancelBut.Location = new System.Drawing.Point(407, 377);
            this.cancelBut.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(89, 34);
            this.cancelBut.TabIndex = 93;
            this.cancelBut.Text = "Cancel";
            this.cancelBut.UseVisualStyleBackColor = true;
            this.cancelBut.Click += new System.EventHandler(this.cancelBut_Click);
            // 
            // saveBut
            // 
            this.saveBut.Location = new System.Drawing.Point(309, 377);
            this.saveBut.Margin = new System.Windows.Forms.Padding(2);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(89, 34);
            this.saveBut.TabIndex = 92;
            this.saveBut.Text = "Save";
            this.saveBut.UseVisualStyleBackColor = true;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(465, 78);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(61, 13);
            this.label25.TabIndex = 105;
            this.label25.Text = "Instructions";
            // 
            // instructionsTB
            // 
            this.instructionsTB.Location = new System.Drawing.Point(468, 91);
            this.instructionsTB.Margin = new System.Windows.Forms.Padding(2);
            this.instructionsTB.Multiline = true;
            this.instructionsTB.Name = "instructionsTB";
            this.instructionsTB.Size = new System.Drawing.Size(101, 191);
            this.instructionsTB.TabIndex = 91;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(231, 145);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 13);
            this.label22.TabIndex = 101;
            this.label22.Text = "PrescriptionHCP";
            // 
            // prescriptionHCPTB
            // 
            this.prescriptionHCPTB.Location = new System.Drawing.Point(231, 158);
            this.prescriptionHCPTB.Margin = new System.Windows.Forms.Padding(2);
            this.prescriptionHCPTB.Name = "prescriptionHCPTB";
            this.prescriptionHCPTB.Size = new System.Drawing.Size(101, 20);
            this.prescriptionHCPTB.TabIndex = 89;
            // 
            // MedEDdatePicker
            // 
            this.MedEDdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MedEDdatePicker.Location = new System.Drawing.Point(348, 224);
            this.MedEDdatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.MedEDdatePicker.Name = "MedEDdatePicker";
            this.MedEDdatePicker.Size = new System.Drawing.Size(101, 20);
            this.MedEDdatePicker.TabIndex = 90;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(348, 211);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 95;
            this.label12.Text = "MedicationEndDate";
            // 
            // MedSDdatePicker
            // 
            this.MedSDdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MedSDdatePicker.Location = new System.Drawing.Point(231, 224);
            this.MedSDdatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.MedSDdatePicker.Name = "MedSDdatePicker";
            this.MedSDdatePicker.Size = new System.Drawing.Size(101, 20);
            this.MedSDdatePicker.TabIndex = 62;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(348, 145);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 80;
            this.label16.Text = "MedicationUnit";
            // 
            // medUnitTB
            // 
            this.medUnitTB.Location = new System.Drawing.Point(348, 158);
            this.medUnitTB.Margin = new System.Windows.Forms.Padding(2);
            this.medUnitTB.Name = "medUnitTB";
            this.medUnitTB.Size = new System.Drawing.Size(101, 20);
            this.medUnitTB.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "MedicationStartDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(348, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "MedicationAmt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(231, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Medication";
            // 
            // medAmtTB
            // 
            this.medAmtTB.Location = new System.Drawing.Point(348, 91);
            this.medAmtTB.Margin = new System.Windows.Forms.Padding(2);
            this.medAmtTB.Name = "medAmtTB";
            this.medAmtTB.Size = new System.Drawing.Size(101, 20);
            this.medAmtTB.TabIndex = 55;
            // 
            // medicationTB
            // 
            this.medicationTB.Location = new System.Drawing.Point(231, 91);
            this.medicationTB.Margin = new System.Windows.Forms.Padding(2);
            this.medicationTB.Name = "medicationTB";
            this.medicationTB.Size = new System.Drawing.Size(101, 20);
            this.medicationTB.TabIndex = 54;
            // 
            // addMHTitle
            // 
            this.addMHTitle.AutoSize = true;
            this.addMHTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addMHTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMHTitle.Location = new System.Drawing.Point(266, 39);
            this.addMHTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addMHTitle.Name = "addMHTitle";
            this.addMHTitle.Size = new System.Drawing.Size(269, 25);
            this.addMHTitle.TabIndex = 53;
            this.addMHTitle.Text = "Add New Medication History";
            // 
            // AddMedicationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.instructionsTB);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.prescriptionHCPTB);
            this.Controls.Add(this.MedEDdatePicker);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.MedSDdatePicker);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.medUnitTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.medAmtTB);
            this.Controls.Add(this.medicationTB);
            this.Controls.Add(this.addMHTitle);
            this.Name = "AddMedicationHistory";
            this.Text = "AddMedicationHistory";
            this.Load += new System.EventHandler(this.AddMedicationHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBut;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox instructionsTB;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox prescriptionHCPTB;
        private System.Windows.Forms.DateTimePicker MedEDdatePicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker MedSDdatePicker;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox medUnitTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox medAmtTB;
        private System.Windows.Forms.TextBox medicationTB;
        private System.Windows.Forms.Label addMHTitle;
    }
}