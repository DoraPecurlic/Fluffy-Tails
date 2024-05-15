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
using System.IO;

namespace zavrsni_rad.Forms
{
    public partial class SubmitPostForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dora_\Documents\users.mdf;Integrated Security=True;Connect Timeout=30");

        public SubmitPostForm()
        {
            InitializeComponent();
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pictureBox.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error occured while uploading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void breedLabel_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (@animalTypeBox.Text == "" || breedBox.Text == "" || ageBox.Text == "" || descriptionBox.Text == "" || pictureBox.Image == null)
            {
                MessageBox.Show("Please fil all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlCommand checkUser = new SqlCommand("", connection))
                {

                    string insertData = "INSERT INTO adds (userID, animalTypeID, breed,gender, age, caption, date_created, photo) " +
                        "VALUES(@userID, @animalTypeID, @breed,@gender, @age, @caption, @date, @photo)";

                    DateTime date = DateTime.Today;

                    using (SqlCommand cmd = new SqlCommand(insertData, connection))
                    {
                        cmd.Parameters.AddWithValue("@userID", UserDetails.UserID);
                        cmd.Parameters.AddWithValue("@animalTypeID", animalTypeBox.GetItemText(animalTypeBox.SelectedItem));
                        cmd.Parameters.AddWithValue("@gender", GetRadioButton());
                        cmd.Parameters.AddWithValue("@breed", breedBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@age", ageBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@caption", descriptionBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@photo", GetImage());
                        cmd.Parameters.AddWithValue("@date", date);

                        cmd.ExecuteNonQuery();

                        UserPosts adds = new UserPosts();
                        adds.Show();
                        this.Hide();


                    }

                }

            }

            connection.Close();

        }

        private object GetImage()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox.Image.Save(stream, pictureBox.Image.RawFormat);
            return stream.GetBuffer();
        }

        private object GetRadioButton()
        {
            if (maleRadioBtn.Checked) return "male";
            else return "female";
        }

        private void SubmitAddForm_Load(object sender, EventArgs e)
        {
            animalTypeBox.Items.Add("Dog");
            animalTypeBox.Items.Add("Cat");
            animalTypeBox.Items.Add("Rodent");
            animalTypeBox.Items.Add("Bird");
            animalTypeBox.Items.Add("Fish");
            animalTypeBox.Items.Add("Reptile");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
