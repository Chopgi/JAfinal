namespace Student2
{
    partial class AddImmunizationHistory
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
            this.commentsTB = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.referralTB = new System.Windows.Forms.TextBox();
            this.DOEpicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.DOBpicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lNameTB = new System.Windows.Forms.TextBox();
            this.fNameTB = new System.Windows.Forms.TextBox();
            this.addIHTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelBut
            // 
            this.cancelBut.Location = new System.Drawing.Point(407, 377);
            this.cancelBut.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(89, 34);
            this.cancelBut.TabIndex = 119;
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
            this.saveBut.TabIndex = 118;
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
            this.label25.TabIndex = 122;
            this.label25.Text = "Instructions";
            // 
            // commentsTB
            // 
            this.commentsTB.Location = new System.Drawing.Point(468, 91);
            this.commentsTB.Margin = new System.Windows.Forms.Padding(2);
            this.commentsTB.Multiline = true;
            this.commentsTB.Name = "commentsTB";
            this.commentsTB.Size = new System.Drawing.Size(101, 191);
            this.commentsTB.TabIndex = 117;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(231, 201);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 13);
            this.label22.TabIndex = 121;
            this.label22.Text = "HCPId";
            // 
            // referralTB
            // 
            this.referralTB.Location = new System.Drawing.Point(231, 214);
            this.referralTB.Margin = new System.Windows.Forms.Padding(2);
            this.referralTB.Name = "referralTB";
            this.referralTB.Size = new System.Drawing.Size(101, 20);
            this.referralTB.TabIndex = 115;
            // 
            // DOEpicker
            // 
            this.DOEpicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOEpicker.Location = new System.Drawing.Point(348, 158);
            this.DOEpicker.Margin = new System.Windows.Forms.Padding(2);
            this.DOEpicker.Name = "DOEpicker";
            this.DOEpicker.Size = new System.Drawing.Size(101, 20);
            this.DOEpicker.TabIndex = 116;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(348, 145);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 120;
            this.label12.Text = "ExperationDate";
            // 
            // DOBpicker
            // 
            this.DOBpicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBpicker.Location = new System.Drawing.Point(231, 158);
            this.DOBpicker.Margin = new System.Windows.Forms.Padding(2);
            this.DOBpicker.Name = "DOBpicker";
            this.DOBpicker.Size = new System.Drawing.Size(101, 20);
            this.DOBpicker.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 113;
            this.label4.Text = "ImmunizationDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(348, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 111;
            this.label2.Text = "Delivery";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(231, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 110;
            this.label1.Text = "Vaccine";
            // 
            // lNameTB
            // 
            this.lNameTB.Location = new System.Drawing.Point(348, 91);
            this.lNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.lNameTB.Name = "lNameTB";
            this.lNameTB.Size = new System.Drawing.Size(101, 20);
            this.lNameTB.TabIndex = 108;
            // 
            // fNameTB
            // 
            this.fNameTB.Location = new System.Drawing.Point(231, 91);
            this.fNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.fNameTB.Name = "fNameTB";
            this.fNameTB.Size = new System.Drawing.Size(101, 20);
            this.fNameTB.TabIndex = 107;
            // 
            // addIHTitle
            // 
            this.addIHTitle.AutoSize = true;
            this.addIHTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addIHTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIHTitle.Location = new System.Drawing.Point(266, 39);
            this.addIHTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addIHTitle.Name = "addIHTitle";
            this.addIHTitle.Size = new System.Drawing.Size(293, 25);
            this.addIHTitle.TabIndex = 106;
            this.addIHTitle.Text = "Add New Immunization History";
            // 
            // AddImmunizationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.commentsTB);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.referralTB);
            this.Controls.Add(this.DOEpicker);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DOBpicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lNameTB);
            this.Controls.Add(this.fNameTB);
            this.Controls.Add(this.addIHTitle);
            this.Name = "AddImmunizationHistory";
            this.Text = "AddImmunizationHistory";
            this.Load += new System.EventHandler(this.AddImmunizationHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBut;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox commentsTB;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox referralTB;
        private System.Windows.Forms.DateTimePicker DOEpicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker DOBpicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lNameTB;
        private System.Windows.Forms.TextBox fNameTB;
        private System.Windows.Forms.Label addIHTitle;
    }
}