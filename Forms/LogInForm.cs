using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace zavrsni_rad.Forms
{
    public partial class LogInForm : Form
    {
        
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dora_\Documents\users.mdf;Integrated Security=True;Connect Timeout=30");
        public LogInForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

       
     
        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Please fil all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();

                        string selectData = "SELECT * FROM users WHERE username = @username and pass = @pass";

                        using(SqlCommand cmd = new SqlCommand(selectData, connection))
                        {
                            cmd.Parameters.AddWithValue("@username", usernameBox.Text);
                            cmd.Parameters.AddWithValue("@pass", passwordBox.Text);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            

                            if(table.Rows.Count >= 1) 
                            {
                                UserDetails.Username = table.Rows[0][2].ToString();
                                UserDetails.UserID =  (int) table.Rows[0][0];

                                MainForm mainForm = new MainForm(); 
                                mainForm.Show();
                                this.Hide();    
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username or password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
           

        }

        private void signUpHere_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logInClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
