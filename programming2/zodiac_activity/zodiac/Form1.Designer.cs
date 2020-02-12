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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zodiacForm));
            this.detailsLabel = new System.Windows.Forms.Label();
            this.fullNameText = new System.Windows.Forms.TextBox();
            this.dateTimePickerText = new System.Windows.Forms.TextBox();
            this.dateTimePickerSelect = new System.Windows.Forms.DateTimePicker();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultGroupBorder = new System.Windows.Forms.GroupBox();
            this.horoscopeGroup = new System.Windows.Forms.GroupBox();
            this.zodiacResultLabel = new System.Windows.Forms.Label();
            this.horoscopePickerBox = new System.Windows.Forms.PictureBox();
            this.chineseZodiacGroup = new System.Windows.Forms.GroupBox();
            this.cZodiacResultLabel = new System.Windows.Forms.Label();
            this.zodiacPickerBox = new System.Windows.Forms.PictureBox();
            this.birthDayResultLabel = new System.Windows.Forms.Label();
            this.fullNameResultLabel = new System.Windows.Forms.Label();
            this.fullNameErr = new System.Windows.Forms.Label();
            this.resultBtn = new System.Windows.Forms.Button();
            this.dateTimeErr = new System.Windows.Forms.Label();
            this.defaultProgramImage = new System.Windows.Forms.PictureBox();
            this.resultGroupBorder.SuspendLayout();
            this.horoscopeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horoscopePickerBox)).BeginInit();
            this.chineseZodiacGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zodiacPickerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultProgramImage)).BeginInit();
            this.SuspendLayout();
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.ForeColor = System.Drawing.Color.Gray;
            this.detailsLabel.Location = new System.Drawing.Point(12, 9);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(70, 13);
            this.detailsLabel.TabIndex = 0;
            this.detailsLabel.Text = "Enter Details:";
            // 
            // fullNameText
            // 
            this.fullNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.fullNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameText.ForeColor = System.Drawing.Color.Gray;
            this.fullNameText.Location = new System.Drawing.Point(100, 39);
            this.fullNameText.Name = "fullNameText";
            this.fullNameText.Size = new System.Drawing.Size(209, 20);
            this.fullNameText.TabIndex = 1;
            this.fullNameText.Enter += new System.EventHandler(this.fullNameText_Enter);
            this.fullNameText.Leave += new System.EventHandler(this.fullNameText_Leave);
            // 
            // dateTimePickerText
            // 
            this.dateTimePickerText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dateTimePickerText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateTimePickerText.ForeColor = System.Drawing.Color.Gray;
            this.dateTimePickerText.Location = new System.Drawing.Point(100, 91);
            this.dateTimePickerText.Name = "dateTimePickerText";
            this.dateTimePickerText.Size = new System.Drawing.Size(209, 20);
            this.dateTimePickerText.TabIndex = 2;
            this.dateTimePickerText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerText_KeyPress);
            // 
            // dateTimePickerSelect
            // 
            this.dateTimePickerSelect.CalendarForeColor = System.Drawing.Color.Gray;
            this.dateTimePickerSelect.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dateTimePickerSelect.Location = new System.Drawing.Point(315, 91);
            this.dateTimePickerSelect.Name = "dateTimePickerSelect";
            this.dateTimePickerSelect.Size = new System.Drawing.Size(16, 20);
            this.dateTimePickerSelect.TabIndex = 3;
            this.dateTimePickerSelect.ValueChanged += new System.EventHandler(this.dateTimePickerSelect_ValueChanged);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.ForeColor = System.Drawing.Color.Gray;
            this.fullNameLabel.Location = new System.Drawing.Point(28, 42);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.fullNameLabel.TabIndex = 4;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(28, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date of Birth:";
            // 
            // resultGroupBorder
            // 
            this.resultGroupBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.resultGroupBorder.Controls.Add(this.horoscopeGroup);
            this.resultGroupBorder.Controls.Add(this.chineseZodiacGroup);
            this.resultGroupBorder.Controls.Add(this.birthDayResultLabel);
            this.resultGroupBorder.Controls.Add(this.fullNameResultLabel);
            this.resultGroupBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultGroupBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultGroupBorder.ForeColor = System.Drawing.Color.Gray;
            this.resultGroupBorder.Location = new System.Drawing.Point(31, 235);
            this.resultGroupBorder.Name = "resultGroupBorder";
            this.resultGroupBorder.Size = new System.Drawing.Size(744, 353);
            this.resultGroupBorder.TabIndex = 6;
            this.resultGroupBorder.TabStop = false;
            this.resultGroupBorder.Text = "Result";
            // 
            // horoscopeGroup
            // 
            this.horoscopeGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.horoscopeGroup.Controls.Add(this.zodiacResultLabel);
            this.horoscopeGroup.Controls.Add(this.horoscopePickerBox);
            this.horoscopeGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.horoscopeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horoscopeGroup.ForeColor = System.Drawing.Color.Gray;
            this.horoscopeGroup.Location = new System.Drawing.Point(24, 111);
            this.horoscopeGroup.Name = "horoscopeGroup";
            this.horoscopeGroup.Size = new System.Drawing.Size(326, 219);
            this.horoscopeGroup.TabIndex = 17;
            this.horoscopeGroup.TabStop = false;
            this.horoscopeGroup.Text = "Horoscope";
            // 
            // zodiacResultLabel
            // 
            this.zodiacResultLabel.AutoSize = true;
            this.zodiacResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zodiacResultLabel.Location = new System.Drawing.Point(105, 173);
            this.zodiacResultLabel.Name = "zodiacResultLabel";
            this.zodiacResultLabel.Size = new System.Drawing.Size(0, 25);
            this.zodiacResultLabel.TabIndex = 14;
            this.zodiacResultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // horoscopePickerBox
            // 
            this.horoscopePickerBox.Location = new System.Drawing.Point(102, 38);
            this.horoscopePickerBox.Name = "horoscopePickerBox";
            this.horoscopePickerBox.Size = new System.Drawing.Size(120, 120);
            this.horoscopePickerBox.TabIndex = 8;
            this.horoscopePickerBox.TabStop = false;
            // 
            // chineseZodiacGroup
            // 
            this.chineseZodiacGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.chineseZodiacGroup.Controls.Add(this.cZodiacResultLabel);
            this.chineseZodiacGroup.Controls.Add(this.zodiacPickerBox);
            this.chineseZodiacGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chineseZodiacGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chineseZodiacGroup.ForeColor = System.Drawing.Color.Gray;
            this.chineseZodiacGroup.Location = new System.Drawing.Point(392, 111);
            this.chineseZodiacGroup.Name = "chineseZodiacGroup";
            this.chineseZodiacGroup.Size = new System.Drawing.Size(326, 219);
            this.chineseZodiacGroup.TabIndex = 16;
            this.chineseZodiacGroup.TabStop = false;
            this.chineseZodiacGroup.Text = "Chinese Zodiac";
            // 
            // cZodiacResultLabel
            // 
            this.cZodiacResultLabel.AutoSize = true;
            this.cZodiacResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cZodiacResultLabel.Location = new System.Drawing.Point(104, 173);
            this.cZodiacResultLabel.Name = "cZodiacResultLabel";
            this.cZodiacResultLabel.Size = new System.Drawing.Size(0, 25);
            this.cZodiacResultLabel.TabIndex = 15;
            this.cZodiacResultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // zodiacPickerBox
            // 
            this.zodiacPickerBox.Location = new System.Drawing.Point(101, 38);
            this.zodiacPickerBox.Name = "zodiacPickerBox";
            this.zodiacPickerBox.Size = new System.Drawing.Size(120, 120);
            this.zodiacPickerBox.TabIndex = 7;
            this.zodiacPickerBox.TabStop = false;
            // 
            // birthDayResultLabel
            // 
            this.birthDayResultLabel.AutoSize = true;
            this.birthDayResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDayResultLabel.Location = new System.Drawing.Point(19, 65);
            this.birthDayResultLabel.Name = "birthDayResultLabel";
            this.birthDayResultLabel.Size = new System.Drawing.Size(89, 25);
            this.birthDayResultLabel.TabIndex = 13;
            this.birthDayResultLabel.Text = "Birthday:";
            // 
            // fullNameResultLabel
            // 
            this.fullNameResultLabel.AutoSize = true;
            this.fullNameResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameResultLabel.Location = new System.Drawing.Point(19, 28);
            this.fullNameResultLabel.Name = "fullNameResultLabel";
            this.fullNameResultLabel.Size = new System.Drawing.Size(106, 25);
            this.fullNameResultLabel.TabIndex = 12;
            this.fullNameResultLabel.Text = "Full Name:";
            // 
            // fullNameErr
            // 
            this.fullNameErr.AutoSize = true;
            this.fullNameErr.ForeColor = System.Drawing.Color.Red;
            this.fullNameErr.Location = new System.Drawing.Point(100, 62);
            this.fullNameErr.Name = "fullNameErr";
            this.fullNameErr.Size = new System.Drawing.Size(0, 13);
            this.fullNameErr.TabIndex = 10;
            // 
            // resultBtn
            // 
            this.resultBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.resultBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.resultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultBtn.Location = new System.Drawing.Point(137, 144);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(128, 37);
            this.resultBtn.TabIndex = 1;
            this.resultBtn.Text = "Get Results!";
            this.resultBtn.UseVisualStyleBackColor = false;
            this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
            // 
            // dateTimeErr
            // 
            this.dateTimeErr.AutoSize = true;
            this.dateTimeErr.ForeColor = System.Drawing.Color.Red;
            this.dateTimeErr.Location = new System.Drawing.Point(100, 114);
            this.dateTimeErr.Name = "dateTimeErr";
            this.dateTimeErr.Size = new System.Drawing.Size(0, 13);
            this.dateTimeErr.TabIndex = 11;
            // 
            // defaultProgramImage
            // 
            this.defaultProgramImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.defaultProgramImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("defaultProgramImage.BackgroundImage")));
            this.defaultProgramImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defaultProgramImage.Location = new System.Drawing.Point(497, 18);
            this.defaultProgramImage.Name = "defaultProgramImage";
            this.defaultProgramImage.Size = new System.Drawing.Size(200, 200);
            this.defaultProgramImage.TabIndex = 16;
            this.defaultProgramImage.TabStop = false;
            this.defaultProgramImage.Click += new System.EventHandler(this.defaultProgramImage_Click);
            // 
            // zodiacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(804, 611);
            this.Controls.Add(this.defaultProgramImage);
            this.Controls.Add(this.dateTimeErr);
            this.Controls.Add(this.resultBtn);
            this.Controls.Add(this.fullNameErr);
            this.Controls.Add(this.resultGroupBorder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.dateTimePickerSelect);
            this.Controls.Add(this.dateTimePickerText);
            this.Controls.Add(this.fullNameText);
            this.Controls.Add(this.detailsLabel);
            this.ForeColor = System.Drawing.Color.Gray;
            this.Name = "zodiacForm";
            this.Text = "Zodiac Picker";
            this.Load += new System.EventHandler(this.zodiacForm_Load);
            this.resultGroupBorder.ResumeLayout(false);
            this.resultGroupBorder.PerformLayout();
            this.horoscopeGroup.ResumeLayout(false);
            this.horoscopeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horoscopePickerBox)).EndInit();
            this.chineseZodiacGroup.ResumeLayout(false);
            this.chineseZodiacGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zodiacPickerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultProgramImage)).EndInit();
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
        private System.Windows.Forms.PictureBox zodiacPickerBox;
        private System.Windows.Forms.PictureBox horoscopePickerBox;
        private System.Windows.Forms.Label fullNameErr;
        private System.Windows.Forms.Button resultBtn;
        private System.Windows.Forms.Label dateTimeErr;
        private System.Windows.Forms.Label cZodiacResultLabel;
        private System.Windows.Forms.Label zodiacResultLabel;
        private System.Windows.Forms.Label birthDayResultLabel;
        private System.Windows.Forms.Label fullNameResultLabel;
        private System.Windows.Forms.PictureBox defaultProgramImage;
        private System.Windows.Forms.GroupBox horoscopeGroup;
        private System.Windows.Forms.GroupBox chineseZodiacGroup;
    }
}

