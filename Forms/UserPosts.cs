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
    public partial class UserPosts : Form
    {
        public UserPosts()
        {
            InitializeComponent();
        }

        private void UserAdds_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dora_\Documents\users.mdf;Integrated Security=True;Connect Timeout=30");

            string selectData = "SELECT animalTypeID,breed, gender, age, caption, photo, addID FROM adds WHERE userID='" + UserDetails.UserID+"'";

            SqlCommand cmd = new SqlCommand(selectData, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            usersPostsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            usersPostsDataGridView.RowTemplate.Height = 150;
            usersPostsDataGridView.AllowUserToAddRows = false;

            adapter.Fill(dt);
            usersPostsDataGridView.DataSource = dt;
            
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)usersPostsDataGridView.Columns[5];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            adapter.Dispose();
        }

        public static DataGridViewRow selectedRow;

        private void usersAddsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                selectedRow = usersPostsDataGridView.Rows[e.RowIndex];
                SelectedPostForm.getSelectedPostForm.ShowDialog();
            }
        }

        private void usersAddsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addPostBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            SubmitPostForm submitAddForm = new SubmitPostForm();
            submitAddForm.Show();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Log out?",
                "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
                LogInForm logInForm = new LogInForm();
                logInForm.Show();
            }
        }

        private void signUpClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}
