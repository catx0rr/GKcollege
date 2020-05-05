namespace information_system
{
    partial class information_system_f3
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
            this.search_label = new System.Windows.Forms.Label();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.search_button_f3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STUDENT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIRST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MIDDLE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIRTHDAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RELIGION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ELEMENTARY_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ELEMENTARY_ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HIGHSCHOOL_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HIGHSCHOOL_ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLLEGE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLLEGE_ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit_button_f3 = new System.Windows.Forms.Button();
            this.exit_button_f3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.delete_crud_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Location = new System.Drawing.Point(12, 21);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(44, 13);
            this.search_label.TabIndex = 0;
            this.search_label.Text = "Search:";
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(62, 18);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(284, 20);
            this.search_textbox.TabIndex = 1;
            // 
            // search_button_f3
            // 
            this.search_button_f3.Image = global::information_system.Properties.Resources.search_magni;
            this.search_button_f3.Location = new System.Drawing.Point(352, 18);
            this.search_button_f3.Name = "search_button_f3";
            this.search_button_f3.Size = new System.Drawing.Size(33, 20);
            this.search_button_f3.TabIndex = 2;
            this.search_button_f3.UseVisualStyleBackColor = true;
            this.search_button_f3.Click += new System.EventHandler(this.search_button_f3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STUDENT_NO,
            this.FIRST_NAME,
            this.MIDDLE_NAME,
            this.LAST_NAME,
            this.BIRTHDAY,
            this.SEX,
            this.STATUS,
            this.RELIGION,
            this.ELEMENTARY_NAME,
            this.ELEMENTARY_ADDRESS,
            this.HIGHSCHOOL_NAME,
            this.HIGHSCHOOL_ADDRESS,
            this.COLLEGE_NAME,
            this.COLLEGE_ADDRESS});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(906, 346);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // STUDENT_NO
            // 
            this.STUDENT_NO.HeaderText = "Student No.";
            this.STUDENT_NO.Name = "STUDENT_NO";
            // 
            // FIRST_NAME
            // 
            this.FIRST_NAME.HeaderText = "First Name";
            this.FIRST_NAME.Name = "FIRST_NAME";
            // 
            // MIDDLE_NAME
            // 
            this.MIDDLE_NAME.HeaderText = "Middle name";
            this.MIDDLE_NAME.Name = "MIDDLE_NAME";
            // 
            // LAST_NAME
            // 
            this.LAST_NAME.HeaderText = "Last Name";
            this.LAST_NAME.Name = "LAST_NAME";
            // 
            // BIRTHDAY
            // 
            this.BIRTHDAY.HeaderText = "Birthday";
            this.BIRTHDAY.Name = "BIRTHDAY";
            // 
            // SEX
            // 
            this.SEX.HeaderText = "Sex";
            this.SEX.Name = "SEX";
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "Status";
            this.STATUS.Name = "STATUS";
            // 
            // RELIGION
            // 
            this.RELIGION.HeaderText = "Religion";
            this.RELIGION.Name = "RELIGION";
            // 
            // ELEMENTARY_NAME
            // 
            this.ELEMENTARY_NAME.HeaderText = "Elementary";
            this.ELEMENTARY_NAME.Name = "ELEMENTARY_NAME";
            // 
            // ELEMENTARY_ADDRESS
            // 
            this.ELEMENTARY_ADDRESS.HeaderText = "Elementary Address";
            this.ELEMENTARY_ADDRESS.Name = "ELEMENTARY_ADDRESS";
            // 
            // HIGHSCHOOL_NAME
            // 
            this.HIGHSCHOOL_NAME.HeaderText = "Highschool";
            this.HIGHSCHOOL_NAME.Name = "HIGHSCHOOL_NAME";
            // 
            // HIGHSCHOOL_ADDRESS
            // 
            this.HIGHSCHOOL_ADDRESS.HeaderText = "Highschool Address";
            this.HIGHSCHOOL_ADDRESS.Name = "HIGHSCHOOL_ADDRESS";
            // 
            // COLLEGE_NAME
            // 
            this.COLLEGE_NAME.HeaderText = "College";
            this.COLLEGE_NAME.Name = "COLLEGE_NAME";
            // 
            // COLLEGE_ADDRESS
            // 
            this.COLLEGE_ADDRESS.HeaderText = "College Address";
            this.COLLEGE_ADDRESS.Name = "COLLEGE_ADDRESS";
            // 
            // edit_button_f3
            // 
            this.edit_button_f3.Location = new System.Drawing.Point(409, 415);
            this.edit_button_f3.Name = "edit_button_f3";
            this.edit_button_f3.Size = new System.Drawing.Size(75, 23);
            this.edit_button_f3.TabIndex = 5;
            this.edit_button_f3.Text = "Edit";
            this.edit_button_f3.UseVisualStyleBackColor = true;
            this.edit_button_f3.Click += new System.EventHandler(this.edit_button_f3_Click);
            // 
            // exit_button_f3
            // 
            this.exit_button_f3.Location = new System.Drawing.Point(843, 415);
            this.exit_button_f3.Name = "exit_button_f3";
            this.exit_button_f3.Size = new System.Drawing.Size(75, 23);
            this.exit_button_f3.TabIndex = 7;
            this.exit_button_f3.Text = "Exit";
            this.exit_button_f3.UseVisualStyleBackColor = true;
            this.exit_button_f3.Click += new System.EventHandler(this.exit_button_f3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete_crud_button
            // 
            this.delete_crud_button.Location = new System.Drawing.Point(530, 415);
            this.delete_crud_button.Name = "delete_crud_button";
            this.delete_crud_button.Size = new System.Drawing.Size(75, 23);
            this.delete_crud_button.TabIndex = 6;
            this.delete_crud_button.Text = "Delete";
            this.delete_crud_button.UseVisualStyleBackColor = true;
            this.delete_crud_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // information_system_f3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.delete_crud_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit_button_f3);
            this.Controls.Add(this.edit_button_f3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_button_f3);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.search_label);
            this.MaximizeBox = false;
            this.Name = "information_system_f3";
            this.Text = "Information System";
            this.Load += new System.EventHandler(this.information_system_f3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button search_button_f3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button edit_button_f3;
        private System.Windows.Forms.Button exit_button_f3;
        private System.Windows.Forms.DataGridViewTextBoxColumn STUDENT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIRST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MIDDLE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIRTHDAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEX;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn RELIGION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ELEMENTARY_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ELEMENTARY_ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HIGHSCHOOL_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn HIGHSCHOOL_ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLLEGE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLLEGE_ADDRESS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delete_crud_button;
    }
}