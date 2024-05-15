using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace zavrsni_rad.Forms
{
    public partial class SignUpForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dora_\Documents\users.mdf;Integrated Security=True;Connect Timeout=30");
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void logInHereLable_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();
        }

        private void signUpClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (emailBox.Text == "" || usernameBox.Text == ""
               || passwordBox.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();
                        String checkUsername = "SELECT * FROM users WHERE username = '"
                            + usernameBox.Text.Trim() + "'";

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connection))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(usernameBox.Text + " already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string insertData = "INSERT INTO users (email, username, pass, date_created) " +
                                    "VALUES(@email, @username, @pass, @date)";

                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connection))
                                {
                                    cmd.Parameters.AddWithValue("@email", emailBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", usernameBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", passwordBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Signed up successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LogInForm logInForm = new LogInForm();
                                    logInForm.Show();
                                    this.Hide();

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally { connection.Close(); }
                }
            }

          
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                passwordBox.PasswordChar = '\0';
            }
            else
            {
                passwordBox.PasswordChar = '*';
            }
        }
    }
}
