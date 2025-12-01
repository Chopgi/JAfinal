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
            this.SuspendLayout();
            // 
            // deleteButMH
            // 
            this.deleteButMH.Location = new System.Drawing.Point(562, 415);
            this.deleteButMH.Name = "deleteButMH";
            this.deleteButMH.Size = new System.Drawing.Size(75, 23);
            this.deleteButMH.TabIndex = 9;
            this.deleteButMH.Text = "Delete";
            this.deleteButMH.UseVisualStyleBackColor = true;
            // 
            // undoButMH
            // 
            this.undoButMH.Location = new System.Drawing.Point(457, 415);
            this.undoButMH.Name = "undoButMH";
            this.undoButMH.Size = new System.Drawing.Size(75, 23);
            this.undoButMH.TabIndex = 8;
            this.undoButMH.Text = "Undo";
            this.undoButMH.UseVisualStyleBackColor = true;
            // 
            // modifyButMH
            // 
            this.modifyButMH.Location = new System.Drawing.Point(247, 415);
            this.modifyButMH.Name = "modifyButMH";
            this.modifyButMH.Size = new System.Drawing.Size(75, 23);
            this.modifyButMH.TabIndex = 7;
            this.modifyButMH.Text = "Modify";
            this.modifyButMH.UseVisualStyleBackColor = true;
            // 
            // addButMH
            // 
            this.addButMH.Location = new System.Drawing.Point(142, 415);
            this.addButMH.Name = "addButMH";
            this.addButMH.Size = new System.Drawing.Size(75, 23);
            this.addButMH.TabIndex = 6;
            this.addButMH.Text = "Add";
            this.addButMH.UseVisualStyleBackColor = true;
            // 
            // saveButMH
            // 
            this.saveButMH.Location = new System.Drawing.Point(352, 415);
            this.saveButMH.Name = "saveButMH";
            this.saveButMH.Size = new System.Drawing.Size(75, 23);
            this.saveButMH.TabIndex = 5;
            this.saveButMH.Text = "Save";
            this.saveButMH.UseVisualStyleBackColor = true;
            // 
            // MedicationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButMH);
            this.Controls.Add(this.undoButMH);
            this.Controls.Add(this.modifyButMH);
            this.Controls.Add(this.addButMH);
            this.Controls.Add(this.saveButMH);
            this.Name = "MedicationHistory";
            this.Text = "MedHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteButMH;
        private System.Windows.Forms.Button undoButMH;
        private System.Windows.Forms.Button modifyButMH;
        private System.Windows.Forms.Button addButMH;
        private System.Windows.Forms.Button saveButMH;
    }
}