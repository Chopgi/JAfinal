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
            this.SuspendLayout();
            // 
            // saveButGMH
            // 
            this.saveButGMH.Location = new System.Drawing.Point(338, 415);
            this.saveButGMH.Name = "saveButGMH";
            this.saveButGMH.Size = new System.Drawing.Size(75, 23);
            this.saveButGMH.TabIndex = 0;
            this.saveButGMH.Text = "Save";
            this.saveButGMH.UseVisualStyleBackColor = true;
            // 
            // addButGMH
            // 
            this.addButGMH.Location = new System.Drawing.Point(128, 415);
            this.addButGMH.Name = "addButGMH";
            this.addButGMH.Size = new System.Drawing.Size(75, 23);
            this.addButGMH.TabIndex = 1;
            this.addButGMH.Text = "Add";
            this.addButGMH.UseVisualStyleBackColor = true;
            // 
            // undoButGMH
            // 
            this.undoButGMH.Location = new System.Drawing.Point(443, 415);
            this.undoButGMH.Name = "undoButGMH";
            this.undoButGMH.Size = new System.Drawing.Size(75, 23);
            this.undoButGMH.TabIndex = 3;
            this.undoButGMH.Text = "Undo";
            this.undoButGMH.UseVisualStyleBackColor = true;
            // 
            // modifyButGMH
            // 
            this.modifyButGMH.Location = new System.Drawing.Point(233, 415);
            this.modifyButGMH.Name = "modifyButGMH";
            this.modifyButGMH.Size = new System.Drawing.Size(75, 23);
            this.modifyButGMH.TabIndex = 2;
            this.modifyButGMH.Text = "Modify";
            this.modifyButGMH.UseVisualStyleBackColor = true;
            // 
            // deleteButGMH
            // 
            this.deleteButGMH.Location = new System.Drawing.Point(548, 415);
            this.deleteButGMH.Name = "deleteButGMH";
            this.deleteButGMH.Size = new System.Drawing.Size(75, 23);
            this.deleteButGMH.TabIndex = 4;
            this.deleteButGMH.Text = "Delete";
            this.deleteButGMH.UseVisualStyleBackColor = true;
            // 
            // GenMedicalHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButGMH);
            this.Controls.Add(this.undoButGMH);
            this.Controls.Add(this.modifyButGMH);
            this.Controls.Add(this.addButGMH);
            this.Controls.Add(this.saveButGMH);
            this.Name = "GenMedicalHistory";
            this.Text = "GenMedicalHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButGMH;
        private System.Windows.Forms.Button addButGMH;
        private System.Windows.Forms.Button undoButGMH;
        private System.Windows.Forms.Button modifyButGMH;
        private System.Windows.Forms.Button deleteButGMH;
    }
}