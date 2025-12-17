namespace Student2
{
    partial class AddImmunization
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.vaccineLabel = new System.Windows.Forms.Label();
            this.vaccineBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.providerLabel = new System.Windows.Forms.Label();
            this.providerBox = new System.Windows.Forms.TextBox();
            this.lotLabel = new System.Windows.Forms.Label();
            this.lotBox = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(95, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(95, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Add Immunization";
            // 
            // vaccineLabel
            // 
            this.vaccineLabel.AutoSize = true;
            this.vaccineLabel.Location = new System.Drawing.Point(20, 50);
            this.vaccineLabel.Name = "vaccineLabel";
            this.vaccineLabel.Size = new System.Drawing.Size(78, 13);
            this.vaccineLabel.TabIndex = 1;
            this.vaccineLabel.Text = "Vaccine Name";
            // 
            // vaccineBox
            // 
            this.vaccineBox.Location = new System.Drawing.Point(23, 68);
            this.vaccineBox.Name = "vaccineBox";
            this.vaccineBox.Size = new System.Drawing.Size(240, 20);
            this.vaccineBox.TabIndex = 2;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(20, 100);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(96, 13);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Date Administered";
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(23, 118);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(120, 20);
            this.dateBox.TabIndex = 4;
            // 
            // providerLabel
            // 
            this.providerLabel.AutoSize = true;
            this.providerLabel.Location = new System.Drawing.Point(20, 150);
            this.providerLabel.Name = "providerLabel";
            this.providerLabel.Size = new System.Drawing.Size(46, 13);
            this.providerLabel.TabIndex = 5;
            this.providerLabel.Text = "Provider";
            // 
            // providerBox
            // 
            this.providerBox.Location = new System.Drawing.Point(23, 168);
            this.providerBox.Name = "providerBox";
            this.providerBox.Size = new System.Drawing.Size(240, 20);
            this.providerBox.TabIndex = 6;
            // 
            // lotLabel
            // 
            this.lotLabel.AutoSize = true;
            this.lotLabel.Location = new System.Drawing.Point(20, 200);
            this.lotLabel.Name = "lotLabel";
            this.lotLabel.Size = new System.Drawing.Size(62, 13);
            this.lotLabel.TabIndex = 7;
            this.lotLabel.Text = "Lot Number";
            // 
            // lotBox
            // 
            this.lotBox.Location = new System.Drawing.Point(23, 218);
            this.lotBox.Name = "lotBox";
            this.lotBox.Size = new System.Drawing.Size(120, 20);
            this.lotBox.TabIndex = 8;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(20, 250);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(35, 13);
            this.notesLabel.TabIndex = 9;
            this.notesLabel.Text = "Notes";
            // 
            // notesBox
            // 
            this.notesBox.Location = new System.Drawing.Point(23, 268);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(240, 60);
            this.notesBox.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(60, 350);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(150, 350);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddImmunization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(290, 400);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.lotBox);
            this.Controls.Add(this.lotLabel);
            this.Controls.Add(this.providerBox);
            this.Controls.Add(this.providerLabel);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.vaccineBox);
            this.Controls.Add(this.vaccineLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "AddImmunization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Immunization";
            this.Load += new System.EventHandler(this.AddImmunization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label vaccineLabel;
        private System.Windows.Forms.TextBox vaccineBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label providerLabel;
        private System.Windows.Forms.TextBox providerBox;
        private System.Windows.Forms.Label lotLabel;
        private System.Windows.Forms.TextBox lotBox;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
