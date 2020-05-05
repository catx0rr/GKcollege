using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace information_system
{
    public partial class information_system_f2 : Form
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;

        public information_system_f3 f3;
        public information_system_f2()
        {
            InitializeComponent();
        }

        public void edit_student(string id)
        {
            // Validate the selected row on the previous form
            student_no_textbox.Text = id;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL command
                SqlCommand command = new SqlCommand(
                    "SELECT * FROM STUDENTS WHERE STUDENT_NO = '" + student_no_textbox.Text + "'",
                    connection
                );

                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // fetch data from the database and show the results to the textboxes

                    fname_textbox.Text = reader["FIRST_NAME"].ToString();
                    mname_textbox.Text = reader["MIDDLE_NAME"].ToString();
                    lname_textbox.Text = reader["LAST_NAME"].ToString();
                    datetime_picker_box.Text = reader["BIRTHDAY"].ToString();
                    sex_cmbbox.Text = reader["SEX"].ToString();
                    civil_stats_cmbbox.Text = reader["STATUS"].ToString();
                    religion_textbox.Text = reader["RELIGION"].ToString();
                    elementary_name_textbox.Text = reader["ELEMENTARY_NAME"].ToString();
                    elementary_add_textbox.Text = reader["ELEMENTARY_ADDRESS"].ToString();
                    highschool_name_textbox.Text = reader["HIGHSCHOOL_NAME"].ToString();
                    highschool_add_textbox.Text = reader["HIGHSCHOOL_ADDRESS"].ToString();
                    college_name_textbox.Text = reader["COLLEGE_NAME"].ToString();
                    college_add_textbox.Text = reader["COLLEGE_ADDRESS"].ToString();

                }

                // Close connection after query
                command.Connection.Close();
            }
        }

        private void information_system_f2_Load(object sender, EventArgs e)
        {
            // Add items to sex combo box on load
            sex_cmbbox.Items.Add("Male");
            sex_cmbbox.Items.Add("Female");

            // Add items to civil status on load
            civil_stats_cmbbox.Items.Add("Single");
            civil_stats_cmbbox.Items.Add("Married");
            civil_stats_cmbbox.Items.Add("Widowed");
            civil_stats_cmbbox.Items.Add("Separated");

        }

        private void add_crud_button_Click(object sender, EventArgs e)
        {

            // Validation for empty values
            if (fname_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("First Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             
            if (mname_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Middle Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lname_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Middle Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (civil_stats_cmbbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Civil Status is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (student_no_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Student No is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sex_cmbbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Sex is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (religion_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Religion is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (elementary_name_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Elementary School is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (elementary_add_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("School address is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (highschool_name_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Highschool is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (highschool_add_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("School address is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (college_name_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("College is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (college_add_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("School address is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL command
                SqlCommand command = new SqlCommand(
                    "INSERT INTO STUDENTS (FIRST_NAME, MIDDLE_NAME, LAST_NAME, STUDENT_NO, BIRTHDAY, SEX, RELIGION, STATUS, ELEMENTARY_NAME, ELEMENTARY_ADDRESS, HIGHSCHOOL_NAME, HIGHSCHOOL_ADDRESS, COLLEGE_NAME, COLLEGE_ADDRESS) VALUES (" +
                           "'" + fname_textbox.Text.ToString() + "', " +
                           "'" + mname_textbox.Text.ToString() + "', " +
                           "'" + lname_textbox.Text.ToString() + "', " +
                           "'" + student_no_textbox.Text.ToString() + "', " +
                           "'" + datetime_picker_box.Value.Date.ToString("yyyyMMdd") + "', " +
                           "'" + sex_cmbbox.Text.ToString() + "', " +
                           "'" + religion_textbox.Text.ToString() + "', " +
                           "'" + civil_stats_cmbbox.Text.ToString() + "', " +
                           "'" + elementary_name_textbox.Text.ToString() + "', " +
                           "'" + elementary_add_textbox.Text.ToString() + "', " +
                           "'" + highschool_name_textbox.Text.ToString() + "', " +
                           "'" + highschool_add_textbox.Text.ToString() + "', " +
                           "'" + college_name_textbox.Text.ToString() + "', " +
                           "'" + college_add_textbox.Text.ToString() + "' " +
                           ")", connection
                     );
                // Communicate to database to add data
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();

                MessageBox.Show("A Student record has been added to the database", "Success", MessageBoxButtons.OK);

                // Clear all the details after writing
                fname_textbox.Clear();
                mname_textbox.Clear();
                lname_textbox.Clear();
                student_no_textbox.Clear();
                datetime_picker_box.Refresh();
                sex_cmbbox.Text = String.Empty;
                religion_textbox.Clear();
                civil_stats_cmbbox.Text = String.Empty;
                elementary_name_textbox.Clear();
                elementary_add_textbox.Clear();
                highschool_name_textbox.Clear();
                highschool_add_textbox.Clear();
                college_name_textbox.Clear();
                college_add_textbox.Clear();

                // Refresh table after adding into table
                this.f3.RefreshTable();
            }
        }

        private void update_crud_button_Click(object sender, EventArgs e)
        {
            // Validation for empty values
            if (fname_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("First Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            if (mname_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Middle Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lname_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Middle Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (civil_stats_cmbbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Civil Status is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (student_no_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Student No is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sex_cmbbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Sex is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (religion_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Religion is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (elementary_name_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Elementary School is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (elementary_add_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("School address is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (highschool_name_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Highschool is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (highschool_add_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("School address is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (college_name_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("College is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (college_add_textbox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("School address is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL command
                SqlCommand command = new SqlCommand(
                    "UPDATE STUDENTS SET " +
                    "FIRST_NAME = '" + fname_textbox.Text.ToString() + "', " +
                    "MIDDLE_NAME = '" + mname_textbox.Text.ToString() + "', " +
                    "LAST_NAME = '" + lname_textbox.Text.ToString() + "', " +
                    "BIRTHDAY = '" + datetime_picker_box.Value.Date.ToString("yyyyMMdd") + "', " +
                    "SEX = '" + sex_cmbbox.Text.ToString() + "', " +
                    "RELIGION = '" + religion_textbox.Text.ToString() + "', " +
                    "STATUS = '" + civil_stats_cmbbox.Text.ToString() + "', " +
                    "ELEMENTARY_NAME= '" + elementary_name_textbox.Text.ToString() + "', " +
                    "ELEMENTARY_ADDRESS = '" + elementary_add_textbox.Text.ToString() + "', " +
                    "HIGHSCHOOL_NAME = '" + highschool_name_textbox.Text.ToString() + "', " +
                    "HIGHSCHOOL_ADDRESS = '" + highschool_add_textbox.Text.ToString() + "', " +
                    "COLLEGE_NAME = '" + college_name_textbox.Text.ToString() + "', " +
                    "COLLEGE_ADDRESS = '" + college_add_textbox.Text.ToString() + "' " +
                    "WHERE STUDENT_NO = '" + student_no_textbox.Text + "'", connection
                     );

                // Communicate to database to add data
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();

                MessageBox.Show("A Student record has been updated", "Success", MessageBoxButtons.OK);

                // Refresh the table after updating row
                this.f3.RefreshTable();
                this.f3.Show();
                this.Hide();
            }
        }

        private void back_button_f2_Click(object sender, EventArgs e)
        {
            // Refresh after clicking back button
            this.f3.RefreshTable();
            this.f3.Show();
            this.Hide();
        }

        private void exit_button_f2_Click(object sender, EventArgs e)
        {
            // Close application
            DialogResult prompt = MessageBox.Show("Do you want to quit the application?", "Warning", MessageBoxButtons.YesNo);
            if (prompt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
