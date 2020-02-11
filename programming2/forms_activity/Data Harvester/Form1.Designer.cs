namespace Data_Harvester
{
    partial class DataHarvesterForm
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
            this.personalInfoLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.givenNameText = new System.Windows.Forms.TextBox();
            this.middleNameText = new System.Windows.Forms.TextBox();
            this.streetText = new System.Windows.Forms.TextBox();
            this.zipCodeText = new System.Windows.Forms.TextBox();
            this.citySelectCombo = new System.Windows.Forms.ComboBox();
            this.cellNoText = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.genderGroup = new System.Windows.Forms.GroupBox();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.heightCmText = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightKgText = new System.Windows.Forms.TextBox();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.monthSelectCombo = new System.Windows.Forms.ComboBox();
            this.daySelectCombo = new System.Windows.Forms.ComboBox();
            this.yearSelectCombo = new System.Windows.Forms.ComboBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageText = new System.Windows.Forms.TextBox();
            this.bmiLabel = new System.Windows.Forms.Label();
            this.bmiOutputText = new System.Windows.Forms.TextBox();
            this.educationGroup = new System.Windows.Forms.GroupBox();
            this.postGradRadio = new System.Windows.Forms.RadioButton();
            this.highschoolRadio = new System.Windows.Forms.RadioButton();
            this.gradCollegeRadio = new System.Windows.Forms.RadioButton();
            this.undergradRadio = new System.Windows.Forms.RadioButton();
            this.skillsLabel = new System.Windows.Forms.Label();
            this.skillsCheckedList = new System.Windows.Forms.CheckedListBox();
            this.progLangLabel = new System.Windows.Forms.Label();
            this.progLangCheckedList = new System.Windows.Forms.CheckedListBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.picNoteLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.houseBlkText = new System.Windows.Forms.TextBox();
            this.telNoText = new System.Windows.Forms.TextBox();
            this.lastNameErr = new System.Windows.Forms.Label();
            this.givenNameErr = new System.Windows.Forms.Label();
            this.middleNameErr = new System.Windows.Forms.Label();
            this.houseBlkErr = new System.Windows.Forms.Label();
            this.streetErr = new System.Windows.Forms.Label();
            this.cityErr = new System.Windows.Forms.Label();
            this.zipCodeErr = new System.Windows.Forms.Label();
            this.telNoErr = new System.Windows.Forms.Label();
            this.cellNoErr = new System.Windows.Forms.Label();
            this.genderErr = new System.Windows.Forms.Label();
            this.weightErr = new System.Windows.Forms.Label();
            this.monthErr = new System.Windows.Forms.Label();
            this.dayErr = new System.Windows.Forms.Label();
            this.yearErr = new System.Windows.Forms.Label();
            this.educationErr = new System.Windows.Forms.Label();
            this.telCountryCodeText = new System.Windows.Forms.TextBox();
            this.cellCountryCodeText = new System.Windows.Forms.TextBox();
            this.heightErr = new System.Windows.Forms.Label();
            this.skillsNone = new System.Windows.Forms.Label();
            this.progLangsNone = new System.Windows.Forms.Label();
            this.genderGroup.SuspendLayout();
            this.educationGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // personalInfoLabel
            // 
            this.personalInfoLabel.AutoSize = true;
            this.personalInfoLabel.Location = new System.Drawing.Point(12, 9);
            this.personalInfoLabel.Name = "personalInfoLabel";
            this.personalInfoLabel.Size = new System.Drawing.Size(103, 13);
            this.personalInfoLabel.TabIndex = 0;
            this.personalInfoLabel.Text = "Personal Information";
            // 
            // lastNameText
            // 
            this.lastNameText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lastNameText.Location = new System.Drawing.Point(40, 41);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(242, 20);
            this.lastNameText.TabIndex = 1;
            this.lastNameText.Text = "Last Name";
            this.lastNameText.Enter += new System.EventHandler(this.lastNameText_Enter);
            this.lastNameText.Leave += new System.EventHandler(this.lastNameText_Leave);
            // 
            // givenNameText
            // 
            this.givenNameText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.givenNameText.Location = new System.Drawing.Point(328, 41);
            this.givenNameText.Name = "givenNameText";
            this.givenNameText.Size = new System.Drawing.Size(242, 20);
            this.givenNameText.TabIndex = 2;
            this.givenNameText.Text = "Given Name";
            this.givenNameText.Enter += new System.EventHandler(this.givenNameText_Enter);
            this.givenNameText.Leave += new System.EventHandler(this.givenNameText_Leave);
            // 
            // middleNameText
            // 
            this.middleNameText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.middleNameText.Location = new System.Drawing.Point(615, 41);
            this.middleNameText.Name = "middleNameText";
            this.middleNameText.Size = new System.Drawing.Size(242, 20);
            this.middleNameText.TabIndex = 3;
            this.middleNameText.Text = "Middle Name";
            this.middleNameText.Enter += new System.EventHandler(this.middleNameText_Enter);
            this.middleNameText.Leave += new System.EventHandler(this.middleNameText_Leave);
            // 
            // streetText
            // 
            this.streetText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.streetText.Location = new System.Drawing.Point(189, 93);
            this.streetText.Name = "streetText";
            this.streetText.Size = new System.Drawing.Size(311, 20);
            this.streetText.TabIndex = 5;
            this.streetText.Text = "Street";
            this.streetText.Enter += new System.EventHandler(this.streetText_Enter);
            this.streetText.Leave += new System.EventHandler(this.streetText_Leave);
            // 
            // zipCodeText
            // 
            this.zipCodeText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.zipCodeText.Location = new System.Drawing.Point(767, 94);
            this.zipCodeText.Name = "zipCodeText";
            this.zipCodeText.Size = new System.Drawing.Size(90, 20);
            this.zipCodeText.TabIndex = 7;
            this.zipCodeText.Text = "Zip Code";
            this.zipCodeText.Enter += new System.EventHandler(this.zipCodeText_Enter);
            this.zipCodeText.Leave += new System.EventHandler(this.zipCodeText_Leave);
            // 
            // citySelectCombo
            // 
            this.citySelectCombo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.citySelectCombo.FormattingEnabled = true;
            this.citySelectCombo.Location = new System.Drawing.Point(536, 93);
            this.citySelectCombo.Name = "citySelectCombo";
            this.citySelectCombo.Size = new System.Drawing.Size(201, 21);
            this.citySelectCombo.TabIndex = 6;
            this.citySelectCombo.Text = "City";
            this.citySelectCombo.SelectedIndexChanged += new System.EventHandler(this.citySelectCombo_SelectedIndexChanged);
            this.citySelectCombo.Enter += new System.EventHandler(this.citySelectCombo_Enter);
            this.citySelectCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.citySelectCombo_KeyPress);
            this.citySelectCombo.Leave += new System.EventHandler(this.citySelectCombo_Leave);
            // 
            // cellNoText
            // 
            this.cellNoText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cellNoText.Location = new System.Drawing.Point(325, 141);
            this.cellNoText.Name = "cellNoText";
            this.cellNoText.Size = new System.Drawing.Size(168, 20);
            this.cellNoText.TabIndex = 9;
            this.cellNoText.Text = "Cellphone No.";
            this.cellNoText.Enter += new System.EventHandler(this.cellNoText_Enter);
            this.cellNoText.Leave += new System.EventHandler(this.cellNoText_Leave);
            // 
            // genderGroup
            // 
            this.genderGroup.Controls.Add(this.femaleRadio);
            this.genderGroup.Controls.Add(this.maleRadio);
            this.genderGroup.Location = new System.Drawing.Point(40, 192);
            this.genderGroup.Name = "genderGroup";
            this.genderGroup.Size = new System.Drawing.Size(205, 48);
            this.genderGroup.TabIndex = 10;
            this.genderGroup.TabStop = false;
            this.genderGroup.Text = "Gender";
            this.genderGroup.Enter += new System.EventHandler(this.genderGroup_Enter);
            this.genderGroup.Leave += new System.EventHandler(this.genderGroup_Leave);
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Location = new System.Drawing.Point(121, 19);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(59, 17);
            this.femaleRadio.TabIndex = 12;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            this.femaleRadio.Click += new System.EventHandler(this.femaleRadio_Click);
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Location = new System.Drawing.Point(19, 19);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(48, 17);
            this.maleRadio.TabIndex = 11;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            this.maleRadio.Click += new System.EventHandler(this.maleRadio_Click);
            // 
            // heightCmText
            // 
            this.heightCmText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.heightCmText.Location = new System.Drawing.Point(360, 208);
            this.heightCmText.Name = "heightCmText";
            this.heightCmText.Size = new System.Drawing.Size(48, 20);
            this.heightCmText.TabIndex = 13;
            this.heightCmText.Text = "cm";
            this.heightCmText.Enter += new System.EventHandler(this.heightCmText_Enter);
            this.heightCmText.Leave += new System.EventHandler(this.heightCmText_Leave);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(295, 211);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 12;
            this.heightLabel.Text = "Height:";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(443, 211);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(44, 13);
            this.weightLabel.TabIndex = 13;
            this.weightLabel.Text = "Weight:";
            // 
            // weightKgText
            // 
            this.weightKgText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.weightKgText.Location = new System.Drawing.Point(508, 208);
            this.weightKgText.Name = "weightKgText";
            this.weightKgText.Size = new System.Drawing.Size(48, 20);
            this.weightKgText.TabIndex = 14;
            this.weightKgText.Text = "kg";
            this.weightKgText.Enter += new System.EventHandler(this.weightKgText_Enter);
            this.weightKgText.Leave += new System.EventHandler(this.weightKgText_Leave);
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Location = new System.Drawing.Point(37, 268);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(48, 13);
            this.birthdateLabel.TabIndex = 15;
            this.birthdateLabel.Text = "Birthday:";
            // 
            // monthSelectCombo
            // 
            this.monthSelectCombo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.monthSelectCombo.FormattingEnabled = true;
            this.monthSelectCombo.ItemHeight = 13;
            this.monthSelectCombo.Location = new System.Drawing.Point(117, 265);
            this.monthSelectCombo.Name = "monthSelectCombo";
            this.monthSelectCombo.Size = new System.Drawing.Size(154, 21);
            this.monthSelectCombo.TabIndex = 15;
            this.monthSelectCombo.Text = "Month";
            this.monthSelectCombo.SelectedIndexChanged += new System.EventHandler(this.monthSelectCombo_SelectedIndexChanged);
            this.monthSelectCombo.Enter += new System.EventHandler(this.monthSelectCombo_Enter);
            this.monthSelectCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.monthSelectCombo_KeyPress);
            this.monthSelectCombo.Leave += new System.EventHandler(this.monthSelectCombo_Leave);
            // 
            // daySelectCombo
            // 
            this.daySelectCombo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.daySelectCombo.FormattingEnabled = true;
            this.daySelectCombo.Location = new System.Drawing.Point(317, 265);
            this.daySelectCombo.Name = "daySelectCombo";
            this.daySelectCombo.Size = new System.Drawing.Size(79, 21);
            this.daySelectCombo.TabIndex = 16;
            this.daySelectCombo.Text = "Day";
            this.daySelectCombo.SelectedIndexChanged += new System.EventHandler(this.daySelectCombo_SelectedIndexChanged);
            this.daySelectCombo.Enter += new System.EventHandler(this.daySelectCombo_Enter);
            this.daySelectCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.daySelectCombo_KeyPress);
            this.daySelectCombo.Leave += new System.EventHandler(this.daySelectCombo_Leave);
            // 
            // yearSelectCombo
            // 
            this.yearSelectCombo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.yearSelectCombo.FormattingEnabled = true;
            this.yearSelectCombo.Location = new System.Drawing.Point(446, 265);
            this.yearSelectCombo.Name = "yearSelectCombo";
            this.yearSelectCombo.Size = new System.Drawing.Size(112, 21);
            this.yearSelectCombo.TabIndex = 17;
            this.yearSelectCombo.Text = "Year";
            this.yearSelectCombo.SelectedIndexChanged += new System.EventHandler(this.yearSelectCombo_SelectedIndexChanged);
            this.yearSelectCombo.Enter += new System.EventHandler(this.yearSelectCombo_Enter);
            this.yearSelectCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearSelectCombo_KeyPress);
            this.yearSelectCombo.Leave += new System.EventHandler(this.yearSelectCombo_Leave);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(599, 269);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(29, 13);
            this.ageLabel.TabIndex = 19;
            this.ageLabel.Text = "Age:";
            // 
            // ageText
            // 
            this.ageText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ageText.Location = new System.Drawing.Point(649, 266);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(59, 20);
            this.ageText.TabIndex = 33;
            // 
            // bmiLabel
            // 
            this.bmiLabel.AutoSize = true;
            this.bmiLabel.Location = new System.Drawing.Point(599, 212);
            this.bmiLabel.Name = "bmiLabel";
            this.bmiLabel.Size = new System.Drawing.Size(29, 13);
            this.bmiLabel.TabIndex = 21;
            this.bmiLabel.Text = "BMI:";
            // 
            // bmiOutputText
            // 
            this.bmiOutputText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bmiOutputText.Location = new System.Drawing.Point(649, 209);
            this.bmiOutputText.Name = "bmiOutputText";
            this.bmiOutputText.Size = new System.Drawing.Size(59, 20);
            this.bmiOutputText.TabIndex = 32;
            // 
            // educationGroup
            // 
            this.educationGroup.Controls.Add(this.postGradRadio);
            this.educationGroup.Controls.Add(this.highschoolRadio);
            this.educationGroup.Controls.Add(this.gradCollegeRadio);
            this.educationGroup.Controls.Add(this.undergradRadio);
            this.educationGroup.Location = new System.Drawing.Point(40, 316);
            this.educationGroup.Name = "educationGroup";
            this.educationGroup.Size = new System.Drawing.Size(242, 199);
            this.educationGroup.TabIndex = 18;
            this.educationGroup.TabStop = false;
            this.educationGroup.Text = "Educational Attainment";
            this.educationGroup.Enter += new System.EventHandler(this.educationGroup_Enter);
            this.educationGroup.Leave += new System.EventHandler(this.educationGroup_Leave);
            // 
            // postGradRadio
            // 
            this.postGradRadio.AutoSize = true;
            this.postGradRadio.Location = new System.Drawing.Point(19, 167);
            this.postGradRadio.Name = "postGradRadio";
            this.postGradRadio.Size = new System.Drawing.Size(93, 17);
            this.postGradRadio.TabIndex = 22;
            this.postGradRadio.TabStop = true;
            this.postGradRadio.Text = "Post Graduate";
            this.postGradRadio.UseVisualStyleBackColor = true;
            this.postGradRadio.Click += new System.EventHandler(this.postGradRadio_Click);
            // 
            // highschoolRadio
            // 
            this.highschoolRadio.AutoSize = true;
            this.highschoolRadio.Location = new System.Drawing.Point(19, 38);
            this.highschoolRadio.Name = "highschoolRadio";
            this.highschoolRadio.Size = new System.Drawing.Size(125, 17);
            this.highschoolRadio.TabIndex = 19;
            this.highschoolRadio.TabStop = true;
            this.highschoolRadio.Text = "Highschool Graduate";
            this.highschoolRadio.UseVisualStyleBackColor = true;
            this.highschoolRadio.Click += new System.EventHandler(this.highschoolRadio_Click);
            // 
            // gradCollegeRadio
            // 
            this.gradCollegeRadio.AutoSize = true;
            this.gradCollegeRadio.Location = new System.Drawing.Point(19, 124);
            this.gradCollegeRadio.Name = "gradCollegeRadio";
            this.gradCollegeRadio.Size = new System.Drawing.Size(107, 17);
            this.gradCollegeRadio.TabIndex = 21;
            this.gradCollegeRadio.TabStop = true;
            this.gradCollegeRadio.Text = "Graduate College";
            this.gradCollegeRadio.UseVisualStyleBackColor = true;
            this.gradCollegeRadio.Click += new System.EventHandler(this.gradCollegeRadio_Click);
            // 
            // undergradRadio
            // 
            this.undergradRadio.AutoSize = true;
            this.undergradRadio.Location = new System.Drawing.Point(19, 81);
            this.undergradRadio.Name = "undergradRadio";
            this.undergradRadio.Size = new System.Drawing.Size(134, 17);
            this.undergradRadio.TabIndex = 20;
            this.undergradRadio.TabStop = true;
            this.undergradRadio.Text = "Undergraduate College";
            this.undergradRadio.UseVisualStyleBackColor = true;
            this.undergradRadio.Click += new System.EventHandler(this.undergradRadio_Click);
            // 
            // skillsLabel
            // 
            this.skillsLabel.AutoSize = true;
            this.skillsLabel.Location = new System.Drawing.Point(336, 316);
            this.skillsLabel.Name = "skillsLabel";
            this.skillsLabel.Size = new System.Drawing.Size(31, 13);
            this.skillsLabel.TabIndex = 24;
            this.skillsLabel.Text = "Skills";
            // 
            // skillsCheckedList
            // 
            this.skillsCheckedList.FormattingEnabled = true;
            this.skillsCheckedList.Location = new System.Drawing.Point(339, 342);
            this.skillsCheckedList.Name = "skillsCheckedList";
            this.skillsCheckedList.Size = new System.Drawing.Size(231, 124);
            this.skillsCheckedList.TabIndex = 23;
            this.skillsCheckedList.Enter += new System.EventHandler(this.skillsCheckedList_Enter);
            this.skillsCheckedList.Leave += new System.EventHandler(this.skillsCheckedList_Leave);
            // 
            // progLangLabel
            // 
            this.progLangLabel.AutoSize = true;
            this.progLangLabel.Location = new System.Drawing.Point(612, 316);
            this.progLangLabel.Name = "progLangLabel";
            this.progLangLabel.Size = new System.Drawing.Size(119, 13);
            this.progLangLabel.TabIndex = 26;
            this.progLangLabel.Text = "Programming Language";
            // 
            // progLangCheckedList
            // 
            this.progLangCheckedList.FormattingEnabled = true;
            this.progLangCheckedList.Location = new System.Drawing.Point(615, 342);
            this.progLangCheckedList.Name = "progLangCheckedList";
            this.progLangCheckedList.Size = new System.Drawing.Size(231, 124);
            this.progLangCheckedList.TabIndex = 24;
            this.progLangCheckedList.Enter += new System.EventHandler(this.progLangCheckedList_Enter);
            this.progLangCheckedList.Leave += new System.EventHandler(this.progLangCheckedList_Leave);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(964, 483);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(107, 41);
            this.submitBtn.TabIndex = 26;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(964, 141);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(75, 23);
            this.uploadBtn.TabIndex = 25;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // picNoteLabel
            // 
            this.picNoteLabel.AutoSize = true;
            this.picNoteLabel.Location = new System.Drawing.Point(987, 78);
            this.picNoteLabel.Name = "picNoteLabel";
            this.picNoteLabel.Size = new System.Drawing.Size(30, 13);
            this.picNoteLabel.TabIndex = 31;
            this.picNoteLabel.Text = "1 x 1";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox.Location = new System.Drawing.Point(952, 35);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 100);
            this.pictureBox.TabIndex = 29;
            this.pictureBox.TabStop = false;
            // 
            // houseBlkText
            // 
            this.houseBlkText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.houseBlkText.Location = new System.Drawing.Point(40, 94);
            this.houseBlkText.Name = "houseBlkText";
            this.houseBlkText.Size = new System.Drawing.Size(93, 20);
            this.houseBlkText.TabIndex = 4;
            this.houseBlkText.Text = "House / Blk No.";
            this.houseBlkText.Enter += new System.EventHandler(this.houseBlkText_Enter);
            this.houseBlkText.Leave += new System.EventHandler(this.houseBlkText_Leave);
            // 
            // telNoText
            // 
            this.telNoText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.telNoText.Location = new System.Drawing.Point(101, 142);
            this.telNoText.Name = "telNoText";
            this.telNoText.Size = new System.Drawing.Size(136, 20);
            this.telNoText.TabIndex = 8;
            this.telNoText.Text = "Telephone No.";
            this.telNoText.Enter += new System.EventHandler(this.telNoText_Enter);
            this.telNoText.Leave += new System.EventHandler(this.telNoText_Leave);
            // 
            // lastNameErr
            // 
            this.lastNameErr.AutoSize = true;
            this.lastNameErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameErr.ForeColor = System.Drawing.Color.Red;
            this.lastNameErr.Location = new System.Drawing.Point(40, 65);
            this.lastNameErr.Name = "lastNameErr";
            this.lastNameErr.Size = new System.Drawing.Size(0, 13);
            this.lastNameErr.TabIndex = 34;
            // 
            // givenNameErr
            // 
            this.givenNameErr.AutoSize = true;
            this.givenNameErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.givenNameErr.ForeColor = System.Drawing.Color.Red;
            this.givenNameErr.Location = new System.Drawing.Point(330, 64);
            this.givenNameErr.Name = "givenNameErr";
            this.givenNameErr.Size = new System.Drawing.Size(0, 13);
            this.givenNameErr.TabIndex = 35;
            // 
            // middleNameErr
            // 
            this.middleNameErr.AutoSize = true;
            this.middleNameErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameErr.ForeColor = System.Drawing.Color.Red;
            this.middleNameErr.Location = new System.Drawing.Point(617, 64);
            this.middleNameErr.Name = "middleNameErr";
            this.middleNameErr.Size = new System.Drawing.Size(0, 13);
            this.middleNameErr.TabIndex = 36;
            // 
            // houseBlkErr
            // 
            this.houseBlkErr.AutoSize = true;
            this.houseBlkErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.houseBlkErr.ForeColor = System.Drawing.Color.Red;
            this.houseBlkErr.Location = new System.Drawing.Point(41, 120);
            this.houseBlkErr.Name = "houseBlkErr";
            this.houseBlkErr.Size = new System.Drawing.Size(0, 13);
            this.houseBlkErr.TabIndex = 37;
            // 
            // streetErr
            // 
            this.streetErr.AutoSize = true;
            this.streetErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetErr.ForeColor = System.Drawing.Color.Red;
            this.streetErr.Location = new System.Drawing.Point(195, 120);
            this.streetErr.Name = "streetErr";
            this.streetErr.Size = new System.Drawing.Size(0, 13);
            this.streetErr.TabIndex = 38;
            // 
            // cityErr
            // 
            this.cityErr.AutoSize = true;
            this.cityErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityErr.ForeColor = System.Drawing.Color.Red;
            this.cityErr.Location = new System.Drawing.Point(537, 120);
            this.cityErr.Name = "cityErr";
            this.cityErr.Size = new System.Drawing.Size(0, 13);
            this.cityErr.TabIndex = 39;
            // 
            // zipCodeErr
            // 
            this.zipCodeErr.AutoSize = true;
            this.zipCodeErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipCodeErr.ForeColor = System.Drawing.Color.Red;
            this.zipCodeErr.Location = new System.Drawing.Point(768, 120);
            this.zipCodeErr.Name = "zipCodeErr";
            this.zipCodeErr.Size = new System.Drawing.Size(0, 13);
            this.zipCodeErr.TabIndex = 40;
            // 
            // telNoErr
            // 
            this.telNoErr.AutoSize = true;
            this.telNoErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telNoErr.ForeColor = System.Drawing.Color.Red;
            this.telNoErr.Location = new System.Drawing.Point(108, 168);
            this.telNoErr.Name = "telNoErr";
            this.telNoErr.Size = new System.Drawing.Size(0, 13);
            this.telNoErr.TabIndex = 41;
            // 
            // cellNoErr
            // 
            this.cellNoErr.AutoSize = true;
            this.cellNoErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellNoErr.ForeColor = System.Drawing.Color.Red;
            this.cellNoErr.Location = new System.Drawing.Point(332, 168);
            this.cellNoErr.Name = "cellNoErr";
            this.cellNoErr.Size = new System.Drawing.Size(0, 13);
            this.cellNoErr.TabIndex = 42;
            // 
            // genderErr
            // 
            this.genderErr.AutoSize = true;
            this.genderErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderErr.ForeColor = System.Drawing.Color.Red;
            this.genderErr.Location = new System.Drawing.Point(46, 242);
            this.genderErr.Name = "genderErr";
            this.genderErr.Size = new System.Drawing.Size(0, 13);
            this.genderErr.TabIndex = 43;
            // 
            // weightErr
            // 
            this.weightErr.AutoSize = true;
            this.weightErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightErr.ForeColor = System.Drawing.Color.Red;
            this.weightErr.Location = new System.Drawing.Point(445, 233);
            this.weightErr.Name = "weightErr";
            this.weightErr.Size = new System.Drawing.Size(0, 13);
            this.weightErr.TabIndex = 45;
            // 
            // monthErr
            // 
            this.monthErr.AutoSize = true;
            this.monthErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthErr.ForeColor = System.Drawing.Color.Red;
            this.monthErr.Location = new System.Drawing.Point(119, 290);
            this.monthErr.Name = "monthErr";
            this.monthErr.Size = new System.Drawing.Size(0, 13);
            this.monthErr.TabIndex = 46;
            // 
            // dayErr
            // 
            this.dayErr.AutoSize = true;
            this.dayErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayErr.ForeColor = System.Drawing.Color.Red;
            this.dayErr.Location = new System.Drawing.Point(318, 290);
            this.dayErr.Name = "dayErr";
            this.dayErr.Size = new System.Drawing.Size(0, 13);
            this.dayErr.TabIndex = 47;
            // 
            // yearErr
            // 
            this.yearErr.AutoSize = true;
            this.yearErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearErr.ForeColor = System.Drawing.Color.Red;
            this.yearErr.Location = new System.Drawing.Point(447, 290);
            this.yearErr.Name = "yearErr";
            this.yearErr.Size = new System.Drawing.Size(0, 13);
            this.yearErr.TabIndex = 48;
            // 
            // educationErr
            // 
            this.educationErr.AutoSize = true;
            this.educationErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.educationErr.ForeColor = System.Drawing.Color.Red;
            this.educationErr.Location = new System.Drawing.Point(58, 518);
            this.educationErr.Name = "educationErr";
            this.educationErr.Size = new System.Drawing.Size(0, 13);
            this.educationErr.TabIndex = 49;
            // 
            // telCountryCodeText
            // 
            this.telCountryCodeText.Location = new System.Drawing.Point(40, 142);
            this.telCountryCodeText.Name = "telCountryCodeText";
            this.telCountryCodeText.Size = new System.Drawing.Size(45, 20);
            this.telCountryCodeText.TabIndex = 30;
            this.telCountryCodeText.Text = "638";
            // 
            // cellCountryCodeText
            // 
            this.cellCountryCodeText.Location = new System.Drawing.Point(264, 141);
            this.cellCountryCodeText.Name = "cellCountryCodeText";
            this.cellCountryCodeText.Size = new System.Drawing.Size(45, 20);
            this.cellCountryCodeText.TabIndex = 31;
            this.cellCountryCodeText.Text = "639";
            // 
            // heightErr
            // 
            this.heightErr.AutoSize = true;
            this.heightErr.ForeColor = System.Drawing.Color.Red;
            this.heightErr.Location = new System.Drawing.Point(298, 233);
            this.heightErr.Name = "heightErr";
            this.heightErr.Size = new System.Drawing.Size(0, 13);
            this.heightErr.TabIndex = 44;
            // 
            // skillsNone
            // 
            this.skillsNone.AutoSize = true;
            this.skillsNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillsNone.ForeColor = System.Drawing.Color.Black;
            this.skillsNone.Location = new System.Drawing.Point(345, 472);
            this.skillsNone.Name = "skillsNone";
            this.skillsNone.Size = new System.Drawing.Size(0, 13);
            this.skillsNone.TabIndex = 50;
            // 
            // progLangsNone
            // 
            this.progLangsNone.AutoSize = true;
            this.progLangsNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progLangsNone.ForeColor = System.Drawing.Color.Black;
            this.progLangsNone.Location = new System.Drawing.Point(623, 472);
            this.progLangsNone.Name = "progLangsNone";
            this.progLangsNone.Size = new System.Drawing.Size(0, 13);
            this.progLangsNone.TabIndex = 51;
            // 
            // DataHarvesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1099, 570);
            this.Controls.Add(this.progLangsNone);
            this.Controls.Add(this.skillsNone);
            this.Controls.Add(this.heightErr);
            this.Controls.Add(this.cellCountryCodeText);
            this.Controls.Add(this.telCountryCodeText);
            this.Controls.Add(this.educationErr);
            this.Controls.Add(this.yearErr);
            this.Controls.Add(this.dayErr);
            this.Controls.Add(this.monthErr);
            this.Controls.Add(this.weightErr);
            this.Controls.Add(this.genderErr);
            this.Controls.Add(this.cellNoErr);
            this.Controls.Add(this.telNoErr);
            this.Controls.Add(this.zipCodeErr);
            this.Controls.Add(this.cityErr);
            this.Controls.Add(this.streetErr);
            this.Controls.Add(this.houseBlkErr);
            this.Controls.Add(this.middleNameErr);
            this.Controls.Add(this.givenNameErr);
            this.Controls.Add(this.lastNameErr);
            this.Controls.Add(this.telNoText);
            this.Controls.Add(this.houseBlkText);
            this.Controls.Add(this.picNoteLabel);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.progLangCheckedList);
            this.Controls.Add(this.progLangLabel);
            this.Controls.Add(this.skillsCheckedList);
            this.Controls.Add(this.skillsLabel);
            this.Controls.Add(this.educationGroup);
            this.Controls.Add(this.bmiOutputText);
            this.Controls.Add(this.bmiLabel);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.yearSelectCombo);
            this.Controls.Add(this.daySelectCombo);
            this.Controls.Add(this.monthSelectCombo);
            this.Controls.Add(this.birthdateLabel);
            this.Controls.Add(this.weightKgText);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.heightCmText);
            this.Controls.Add(this.genderGroup);
            this.Controls.Add(this.cellNoText);
            this.Controls.Add(this.citySelectCombo);
            this.Controls.Add(this.zipCodeText);
            this.Controls.Add(this.streetText);
            this.Controls.Add(this.middleNameText);
            this.Controls.Add(this.givenNameText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.personalInfoLabel);
            this.Name = "DataHarvesterForm";
            this.Text = "Data Harvester";
            this.Load += new System.EventHandler(this.DataHarvesterForm_Load);
            this.genderGroup.ResumeLayout(false);
            this.genderGroup.PerformLayout();
            this.educationGroup.ResumeLayout(false);
            this.educationGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label personalInfoLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox givenNameText;
        private System.Windows.Forms.TextBox middleNameText;
        private System.Windows.Forms.TextBox streetText;
        private System.Windows.Forms.TextBox zipCodeText;
        private System.Windows.Forms.ComboBox citySelectCombo;
        private System.Windows.Forms.TextBox cellNoText;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox genderGroup;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.TextBox heightCmText;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox weightKgText;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.ComboBox monthSelectCombo;
        private System.Windows.Forms.ComboBox daySelectCombo;
        private System.Windows.Forms.ComboBox yearSelectCombo;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.Label bmiLabel;
        private System.Windows.Forms.TextBox bmiOutputText;
        private System.Windows.Forms.GroupBox educationGroup;
        private System.Windows.Forms.RadioButton postGradRadio;
        private System.Windows.Forms.RadioButton highschoolRadio;
        private System.Windows.Forms.RadioButton gradCollegeRadio;
        private System.Windows.Forms.RadioButton undergradRadio;
        private System.Windows.Forms.Label skillsLabel;
        private System.Windows.Forms.CheckedListBox skillsCheckedList;
        private System.Windows.Forms.Label progLangLabel;
        private System.Windows.Forms.CheckedListBox progLangCheckedList;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Label picNoteLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox houseBlkText;
        private System.Windows.Forms.TextBox telNoText;
        private System.Windows.Forms.Label lastNameErr;
        private System.Windows.Forms.Label givenNameErr;
        private System.Windows.Forms.Label middleNameErr;
        private System.Windows.Forms.Label houseBlkErr;
        private System.Windows.Forms.Label streetErr;
        private System.Windows.Forms.Label cityErr;
        private System.Windows.Forms.Label zipCodeErr;
        private System.Windows.Forms.Label telNoErr;
        private System.Windows.Forms.Label cellNoErr;
        private System.Windows.Forms.Label genderErr;
        private System.Windows.Forms.Label weightErr;
        private System.Windows.Forms.Label monthErr;
        private System.Windows.Forms.Label dayErr;
        private System.Windows.Forms.Label yearErr;
        private System.Windows.Forms.Label educationErr;
        private System.Windows.Forms.TextBox telCountryCodeText;
        private System.Windows.Forms.TextBox cellCountryCodeText;
        private System.Windows.Forms.Label heightErr;
        private System.Windows.Forms.Label skillsNone;
        private System.Windows.Forms.Label progLangsNone;
    }
}

