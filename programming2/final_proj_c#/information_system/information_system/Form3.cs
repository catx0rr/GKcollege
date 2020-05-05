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
    public partial class information_system_f3 : Form
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;

        public information_system_f2 f2;

        public information_system_f3(information_system_f2 f2)
        {
            InitializeComponent();

            this.f2 = f2;
            this.f2.f3 = this;
        }

        private void information_system_f3_Load(object sender, EventArgs e)
        {
            // Connect to SQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL command query
                SqlCommand command = new SqlCommand(
                    "SELECT * FROM STUDENTS",
                    connection
                );

                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["STUDENT_NO"].ToString(),
                        reader["FIRST_NAME"].ToString(),
                        reader["MIDDLE_NAME"].ToString(),
                        reader["LAST_NAME"].ToString(),
                        reader["BIRTHDAY"].ToString(),
                        reader["SEX"].ToString(),
                        reader["STATUS"].ToString(),
                        reader["RELIGION"].ToString(),
                        reader["ELEMENTARY_NAME"].ToString(),
                        reader["ELEMENTARY_ADDRESS"].ToString(),
                        reader["HIGHSCHOOL_NAME"].ToString(),
                        reader["HIGHSCHOOL_ADDRESS"].ToString(),
                        reader["COLLEGE_NAME"].ToString(),
                        reader["COLLEGE_ADDRESS"].ToString()
                    );
                }

                // Close connection after query
                command.Connection.Close();
            }

        }

        private void search_button_f3_Click(object sender, EventArgs e)
        {
            // Clear the dataGridView before showing the results of search query
            dataGridView1.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(
                    "SELECT * FROM STUDENTS " +
                    "WHERE FIRST_NAME LIKE '%" + search_textbox.Text + "%' " +
                    " OR MIDDLE_NAME LIKE '%" + search_textbox.Text + "%' " +
                    " OR LAST_NAME LIKE '%" + search_textbox.Text + "%' " +
                    " OR STUDENT_NO LIKE '%" + search_textbox.Text + "%' " +
                    " OR STATUS LIKE '%" + search_textbox.Text + "%' " +
                    " OR RELIGION LIKE '%" + search_textbox.Text + "%' " +
                    " OR SEX LIKE '%" + search_textbox.Text + "%' " +
                    " OR BIRTHDAY LIKE '%" + search_textbox.Text + "%' " +
                    " OR AGE LIKE '%" + search_textbox.Text + "%' " +
                    " OR ELEMENTARY_NAME LIKE '%" + search_textbox.Text + "%' " +
                    " OR ELEMENTARY_ADDRESS LIKE '%" + search_textbox.Text + "%' " +
                    " OR HIGHSCHOOL_NAME LIKE '%" + search_textbox.Text + "%' " +
                    " OR HIGHSCHOOL_ADDRESS LIKE '%" + search_textbox.Text + "%' " +
                    " OR COLLEGE_NAME LIKE '%" + search_textbox.Text + "%' " +
                    " OR COLLEGE_ADDRESS LIKE '%" + search_textbox.Text + "%' ",
                    connection
                );

                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
             

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["STUDENT_NO"].ToString(),
                        reader["FIRST_NAME"].ToString(),
                        reader["MIDDLE_NAME"].ToString(),
                        reader["LAST_NAME"].ToString(),
                        reader["BIRTHDAY"].ToString(),
                        reader["SEX"].ToString(),
                        reader["STATUS"].ToString(),
                        reader["RELIGION"].ToString(),
                        reader["ELEMENTARY_NAME"].ToString(),
                        reader["ELEMENTARY_ADDRESS"].ToString(),
                        reader["HIGHSCHOOL_NAME"].ToString(),
                        reader["HIGHSCHOOL_ADDRESS"].ToString(),
                        reader["COLLEGE_NAME"].ToString(),
                        reader["COLLEGE_ADDRESS"].ToString()
                    );
                }

                // Close connection after query
                command.Connection.Close();

            }
        }

        // When cell is click and edit is selected
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells["STUDENT_NO"].Value.ToString();
        }


        // Go to form edit
        private void edit_button_f3_Click(object sender, EventArgs e)
        {
            this.f2.edit_student(dataGridView1.SelectedRows[0].Cells["STUDENT_NO"].Value.ToString());
            this.f2.Show();
            this.Hide();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Pass the values that will be used
            string id = dataGridView1.SelectedRows[0].Cells["STUDENT_NO"].Value.ToString();
            string fname = dataGridView1.SelectedRows[0].Cells["FIRST_NAME"].Value.ToString();
            string lname = dataGridView1.SelectedRows[0].Cells["LAST_NAME"].Value.ToString();

            // Check for validity to verify before performing delete
            if (id != String.Empty)
            {
                DialogResult prompt = MessageBox.Show("Are you sure you want to delete "
                    + fname + " " + lname, "Warning", MessageBoxButtons.YesNo);

                if (prompt == DialogResult.No)
                {
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(
                        "DELETE FROM STUDENTS WHERE STUDENT_NO = '" + id + "'",
                        connection
                    );

                    // Communicate to database to delete data
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();

                    MessageBox.Show("Student record has been deleted.", "Success", MessageBoxButtons.OK);
                }

            }

            this.RefreshTable();
        }

        public void RefreshTable()
        {
            // Show again the details after performing query in the dataGridview

            dataGridView1.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(
                    "SELECT * FROM STUDENTS",
                    connection
                );

                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["STUDENT_NO"].ToString(),
                        reader["FIRST_NAME"].ToString(),
                        reader["MIDDLE_NAME"].ToString(),
                        reader["LAST_NAME"].ToString(),
                        reader["BIRTHDAY"].ToString(),
                        reader["SEX"].ToString(),
                        reader["STATUS"].ToString(),
                        reader["RELIGION"].ToString(),
                        reader["ELEMENTARY_NAME"].ToString(),
                        reader["ELEMENTARY_ADDRESS"].ToString(),
                        reader["HIGHSCHOOL_NAME"].ToString(),
                        reader["HIGHSCHOOL_ADDRESS"].ToString(),
                        reader["COLLEGE_NAME"].ToString(),
                        reader["COLLEGE_ADDRESS"].ToString()
                    );
                }

                // Close connection after query
                command.Connection.Close();
            }
        }

        private void exit_button_f3_Click(object sender, EventArgs e)
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
