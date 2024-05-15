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
    public partial class SelectedPostForm : Form
    {
        public static SelectedPostForm selectedPostForm;
        public static SelectedPostForm getSelectedPostForm
        {
            get
            {
                if(selectedPostForm == null)
                {
                    selectedPostForm = new SelectedPostForm();
                }
                return selectedPostForm;
            }
        }
        


        public SelectedPostForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            UserPosts posts = new UserPosts();
            posts.Show();
            this.Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectedPostForm_Load(object sender, EventArgs e)
        {
            animalTypeBox.Text = UserPosts.selectedRow.Cells[0].Value.ToString();
            breedBox.Text = UserPosts.selectedRow.Cells[1].Value.ToString();
            genderBox.Text = UserPosts.selectedRow.Cells[2].Value.ToString();
            ageBox.Text = UserPosts.selectedRow.Cells[3].Value.ToString();
            descriptionBox.Text = UserPosts.selectedRow.Cells[4].Value.ToString();
           
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dora_\Documents\users.mdf;Integrated Security=True;Connect Timeout=30");
            string addID = UserPosts.selectedRow.Cells[6].Value.ToString();
            string query = "Delete FROM adds WHERE addID='" + addID + "'";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            MessageBox.Show("Post deleted!");
            this.Hide();
            UserPosts posts = new UserPosts();
            posts.Show();
            

        }

        private void seeCommentsBtn_Click(object sender, EventArgs e)
        {
            string addID = UserPosts.selectedRow.Cells[6].Value.ToString();

            this.Hide();
            MyPostCommentsForm myPostComments = new MyPostCommentsForm(addID);
            myPostComments.ShowDialog();
           

        }
    }
}
