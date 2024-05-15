using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zavrsni_rad.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signUpClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Log out?", 
                "Log Out?", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                this.Close();
                LogInForm logInForm = new LogInForm();
                logInForm.Show();
            }
            
        }

      
        private void submitAddBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            SubmitPostForm submitAddForm = new SubmitPostForm();
            submitAddForm.Show();
        }


        private void myPostsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            UserPosts posts = new UserPosts();
            posts.Show();
        }

        private void birdsLable_Click(object sender, EventArgs e)
        {

        }

        private void dogsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchForm dogForm = new SearchForm("dog");
            dogForm.Show();
        }

        private void catsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchForm dogForm = new SearchForm("cat");
            dogForm.Show();
        }

        private void rodentsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchForm dogForm = new SearchForm("fish");
            dogForm.Show();
        }

        private void reptilesBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchForm dogForm = new SearchForm("reptile");
            dogForm.Show();
        }

        private void birdsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchForm dogForm = new SearchForm("rodent");
            dogForm.Show();
        }

        private void fishBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchForm dogForm = new SearchForm("bird");
            dogForm.Show();
        }
    }
}
