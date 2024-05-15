using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace zavrsni_rad.Forms
{
    public partial class SearchForm : Form
    {
        private string animalType;

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dora_\Documents\users.mdf;Integrated Security=True;Connect Timeout=30");

        public SearchForm(string animalType)
        {
            InitializeComponent();
            this.animalType = animalType; 
        }

        public void DisplayData(string selectData)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand(selectData, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            animalDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            animalDataGridView.RowTemplate.Height = 150;
            animalDataGridView.AllowUserToAddRows = false;

            adapter.Fill(dt);
            animalDataGridView.DataSource = dt;

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)animalDataGridView.Columns[5];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            adapter.Dispose();
            connection.Close();
        }

        private void BreedBoxFilter()
        {
            string selectData = "SELECT animalTypeID,breed, gender, age, caption, photo, addID FROM adds" +
                " WHERE animalTypeID='" + animalType + " 'AND breed='" + breedTextBox.Text + "'";
            DisplayData(selectData);
        }

        private void GenderBoxFilter()
        {
            string selectData = "SELECT animalTypeID,breed, gender, age, caption, photo, addID FROM adds " +
                "WHERE animalTypeID='" + animalType + "' AND gender='" + genderComboBox.SelectedItem.ToString() + "'";
            DisplayData(selectData);

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            string selectData = "SELECT animalTypeID,breed, gender, age, caption, photo, addID FROM adds" +
                " WHERE animalTypeID='"+ animalType +"'";
            DisplayData(selectData);
        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenderBoxFilter();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            BreedBoxFilter();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            string selectData = "SELECT animalTypeID,breed, gender, age, caption, photo, addID FROM adds WHERE animalTypeID='"+ animalType +"'";
            DisplayData(selectData);
            breedTextBox.Text = string.Empty;
            genderComboBox.Text = string.Empty;

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void addPostBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            SubmitPostForm submitAddForm = new SubmitPostForm();
            submitAddForm.Show();
        }

        public static DataGridViewRow selectedRow;

        private void animalDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                selectedRow = animalDataGridView.Rows[e.RowIndex];
                CommentsForm.GetCommentsForm.ShowDialog();
            }
        }
    }
}
