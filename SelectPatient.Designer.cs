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
            this.visitPDbut = new System.Windows.Forms.Button();
            this.listBoxSP = new System.Windows.Forms.ListBox();
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
            this.nameAgeLabel.TabIndex = 19;
            this.nameAgeLabel.Text = "PatientFname, Lname, Age";
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxSP);
            this.Controls.Add(this.visitPDbut);
            this.Controls.Add(this.nameAgeLabel);
            this.Name = "SelectPatient";
            this.Text = "SelectPatient";
            this.Load += new System.EventHandler(this.SelectPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameAgeLabel;
        private System.Windows.Forms.Button visitPDbut;
        private System.Windows.Forms.ListBox listBoxSP;
    }
}