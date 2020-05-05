namespace information_system
{
    partial class login_f1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.login_button_f1 = new System.Windows.Forms.Button();
            this.exit_button_f1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(88, 25);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(181, 20);
            this.username_textbox.TabIndex = 2;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(88, 64);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '•';
            this.password_textbox.Size = new System.Drawing.Size(181, 20);
            this.password_textbox.TabIndex = 3;
            // 
            // login_button_f1
            // 
            this.login_button_f1.Location = new System.Drawing.Point(97, 113);
            this.login_button_f1.Name = "login_button_f1";
            this.login_button_f1.Size = new System.Drawing.Size(75, 23);
            this.login_button_f1.TabIndex = 4;
            this.login_button_f1.Text = "Login";
            this.login_button_f1.UseVisualStyleBackColor = true;
            this.login_button_f1.Click += new System.EventHandler(this.login_button_f1_Click);
            // 
            // exit_button_f1
            // 
            this.exit_button_f1.Location = new System.Drawing.Point(181, 113);
            this.exit_button_f1.Name = "exit_button_f1";
            this.exit_button_f1.Size = new System.Drawing.Size(75, 23);
            this.exit_button_f1.TabIndex = 5;
            this.exit_button_f1.Text = "Exit";
            this.exit_button_f1.UseVisualStyleBackColor = true;
            this.exit_button_f1.Click += new System.EventHandler(this.exit_button_f1_Click);
            // 
            // login_f1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 162);
            this.Controls.Add(this.exit_button_f1);
            this.Controls.Add(this.login_button_f1);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "login_f1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button login_button_f1;
        private System.Windows.Forms.Button exit_button_f1;
    }
}

