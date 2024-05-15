using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace zavrsni_rad.Forms
{
    public partial class CommentsForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dora_\Documents\users.mdf;Integrated Security=True;Connect Timeout=30");
        
        public static CommentsForm getCommentsForm;
        private string addID;
        public static CommentsForm GetCommentsForm
        {
            get
            {
                if (getCommentsForm == null)
                {
                    getCommentsForm = new CommentsForm();
                }
                return getCommentsForm;
            }
        }
        public CommentsForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void commentBtn_Click(object sender, EventArgs e)
        {
          
            SubmitCommentForm comment = new SubmitCommentForm();
            comment.ShowDialog();
            this.Close();
            
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

        private void CommentsForm_Load(object sender, EventArgs e)
        {
            postOwnerLabel.Text = UserDetails.Username;
            postIDLabel.Text = SearchForm.selectedRow.Cells[6].Value.ToString();

            string selectData = "SELECT username, comment FROM comments WHERE addID='" + postIDLabel.Text + "'";
            DisplayData(selectData);
        }

        private void postOwnerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
