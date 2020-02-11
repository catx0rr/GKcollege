namespace zodiac
{
    partial class zodiacForm
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
            this.detailsLabel = new System.Windows.Forms.Label();
            this.fullNameText = new System.Windows.Forms.TextBox();
            this.dateTimePickerText = new System.Windows.Forms.TextBox();
            this.dateTimePickerSelect = new System.Windows.Forms.DateTimePicker();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultGroupBorder = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(12, 9);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(70, 13);
            this.detailsLabel.TabIndex = 0;
            this.detailsLabel.Text = "Enter Details:";
            // 
            // fullNameText
            // 
            this.fullNameText.ForeColor = System.Drawing.Color.Gray;
            this.fullNameText.Location = new System.Drawing.Point(100, 39);
            this.fullNameText.Name = "fullNameText";
            this.fullNameText.Size = new System.Drawing.Size(209, 20);
            this.fullNameText.TabIndex = 1;
            // 
            // dateTimePickerText
            // 
            this.dateTimePickerText.Location = new System.Drawing.Point(100, 91);
            this.dateTimePickerText.Name = "dateTimePickerText";
            this.dateTimePickerText.Size = new System.Drawing.Size(209, 20);
            this.dateTimePickerText.TabIndex = 2;
            // 
            // dateTimePickerSelect
            // 
            this.dateTimePickerSelect.Location = new System.Drawing.Point(315, 91);
            this.dateTimePickerSelect.Name = "dateTimePickerSelect";
            this.dateTimePickerSelect.Size = new System.Drawing.Size(16, 20);
            this.dateTimePickerSelect.TabIndex = 3;
            this.dateTimePickerSelect.ValueChanged += new System.EventHandler(this.dateTimePickerSelect_ValueChanged);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(28, 42);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.fullNameLabel.TabIndex = 4;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date of Birth:";
            // 
            // resultGroupBorder
            // 
            this.resultGroupBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.resultGroupBorder.Location = new System.Drawing.Point(31, 187);
            this.resultGroupBorder.Name = "resultGroupBorder";
            this.resultGroupBorder.Size = new System.Drawing.Size(744, 239);
            this.resultGroupBorder.TabIndex = 6;
            this.resultGroupBorder.TabStop = false;
            this.resultGroupBorder.Text = "Result";
            // 
            // zodiacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultGroupBorder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.dateTimePickerSelect);
            this.Controls.Add(this.dateTimePickerText);
            this.Controls.Add(this.fullNameText);
            this.Controls.Add(this.detailsLabel);
            this.Name = "zodiacForm";
            this.Text = "Zodiac Picker";
            this.Load += new System.EventHandler(this.zodiacForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.TextBox fullNameText;
        private System.Windows.Forms.TextBox dateTimePickerText;
        private System.Windows.Forms.DateTimePicker dateTimePickerSelect;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox resultGroupBorder;
    }
}

