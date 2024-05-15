using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zavrsni_rad.Forms
{
    public partial class SubmitCommentForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dora_\Documents\users.mdf;Integrated Security=True;Connect Timeout=30");

        public SubmitCommentForm()
        {
            InitializeComponent();
        }

        private void SubmitCommentForm_Load(object sender, EventArgs e)
        {
            userLabel.Text = UserDetails.Username;
        }

        private void submitCommentBtn_Click(object sender, EventArgs e)
        {
            if (commentTextBox.Text == "")
            {
                MessageBox.Show("Please fill blank field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();

                string insertData = "INSERT INTO comments (username, addID, comment) " +
                      "VALUES(@username, @addID, @comment)";

                using (SqlCommand cmd = new SqlCommand(insertData, connection))
                {
                    cmd.Parameters.AddWithValue("@username", UserDetails.Username);
                    cmd.Parameters.AddWithValue("@addID", SearchForm.selectedRow.Cells[6].Value.ToString());
                    cmd.Parameters.AddWithValue("@comment", commentTextBox.Text.Trim());

                    cmd.ExecuteNonQuery();

                    this.Close();
                
                    

                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            CommentsForm comment = new CommentsForm();
            comment.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
