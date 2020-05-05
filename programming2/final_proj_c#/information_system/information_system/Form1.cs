using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace information_system
{
    public partial class login_f1 : Form
    {
        public login_f1()
        {
            InitializeComponent();
        }

        public string connectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;

        private void login_button_f1_Click(object sender, EventArgs e)
        {
            // Validate for empty values
            if (username_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please enter a username", "Error", MessageBoxButtons.OK);
                return;
            }

            if (password_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please enter a password", "Error", MessageBoxButtons.OK);
                return;
            }

            // Initiate connection to database

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(
                    "SELECT * FROM USERS WHERE Username = '" + username_textbox.Text + "' AND Password ='" + password_textbox.Text + "'", 
                    connection
                );

                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    // Close connection initiate form load
                    connection.Close();

                    information_system_f2 f2 = new information_system_f2();

                    information_system_f3 f3 = new information_system_f3(f2);
                    f3.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    // Show error for invalid login
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
            }
        }

        private void exit_button_f1_Click(object sender, EventArgs e)
        {
            // Close program
            Application.Exit();
        }
    }
}
