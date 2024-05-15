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
    public partial class MyPostCommentsForm : Form
    {
        private string addID;

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dora_\Documents\users.mdf;Integrated Security=True;Connect Timeout=30");

        public MyPostCommentsForm(string addID)
        {
            InitializeComponent();
            this.addID = addID;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            SelectedPostForm post = new SelectedPostForm();
            post.Show();
            this.Close();
        }

        private void commentBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            SubmitCommentOnMyPostForm comment = new SubmitCommentOnMyPostForm(addID);
            comment.ShowDialog();
        }
        public void DisplayData(string selectData)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand(selectData, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            commentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            commentDataGridView.RowTemplate.Height = 150;
            commentDataGridView.AllowUserToAddRows = false;

            adapter.Fill(dt);
            commentDataGridView.DataSource = dt;


            adapter.Dispose();
            connection.Close();
        }

        private void MyPostCommentsForm_Load(object sender, EventArgs e)
        {
            postOwnerLabel.Text = UserDetails.Username;
            postIDLabel.Text = addID;

            string selectData = "SELECT username, comment FROM comments WHERE addID='" + postIDLabel.Text + "'";
            DisplayData(selectData);
        }
    }
}
