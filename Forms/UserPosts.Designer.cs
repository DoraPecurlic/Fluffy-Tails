namespace zavrsni_rad.Forms
{
    partial class UserPosts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usersPostsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addPostBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.signUpClose = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersPostsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usersPostsDataGridView
            // 
            this.usersPostsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.usersPostsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersPostsDataGridView.GridColor = System.Drawing.Color.SaddleBrown;
            this.usersPostsDataGridView.Location = new System.Drawing.Point(9, 142);
            this.usersPostsDataGridView.Name = "usersPostsDataGridView";
            this.usersPostsDataGridView.RowHeadersWidth = 51;
            this.usersPostsDataGridView.RowTemplate.Height = 24;
            this.usersPostsDataGridView.Size = new System.Drawing.Size(1079, 469);
            this.usersPostsDataGridView.TabIndex = 0;
            this.usersPostsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersAddsDataGridView_CellContentClick);
            this.usersPostsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.usersAddsDataGridView_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Posts";
            // 
            // addPostBtn
            // 
            this.addPostBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.addPostBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPostBtn.Location = new System.Drawing.Point(760, 21);
            this.addPostBtn.Name = "addPostBtn";
            this.addPostBtn.Size = new System.Drawing.Size(151, 40);
            this.addPostBtn.TabIndex = 28;
            this.addPostBtn.Text = "+ Add Post";
            this.addPostBtn.UseVisualStyleBackColor = false;
            this.addPostBtn.Click += new System.EventHandler(this.addPostBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.Location = new System.Drawing.Point(917, 21);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(120, 40);
            this.logOutBtn.TabIndex = 29;
            this.logOutBtn.Text = "Log out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // signUpClose
            // 
            this.signUpClose.AutoSize = true;
            this.signUpClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpClose.Location = new System.Drawing.Point(1065, 9);
            this.signUpClose.Name = "signUpClose";
            this.signUpClose.Size = new System.Drawing.Size(23, 22);
            this.signUpClose.TabIndex = 30;
            this.signUpClose.Text = "X";
            this.signUpClose.Click += new System.EventHandler(this.signUpClose_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Bisque;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(9, 642);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 46);
            this.backBtn.TabIndex = 31;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // UserPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.signUpClose);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.addPostBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersPostsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserPosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserAdds";
            this.Load += new System.EventHandler(this.UserAdds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersPostsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView usersPostsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPostBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Label signUpClose;
        private System.Windows.Forms.Button backBtn;
    }
}