namespace zavrsni_rad.Forms
{
    partial class SelectedPostForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.animalTypeLabel = new System.Windows.Forms.Label();
            this.breedLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.genderBox = new System.Windows.Forms.TextBox();
            this.breedBox = new System.Windows.Forms.TextBox();
            this.animalTypeBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Label();
            this.seeCommentsBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.seeCommentsBtn);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Location = new System.Drawing.Point(700, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 700);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = global::zavrsni_rad.Properties.Resources.FLUFFYTAILS1;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Enabled = false;
            this.pictureBox.Location = new System.Drawing.Point(46, 36);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 279);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Bisque;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(107, 562);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(212, 46);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete Post";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Bisque;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(32, 628);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 46);
            this.backBtn.TabIndex = 13;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // animalTypeLabel
            // 
            this.animalTypeLabel.AutoSize = true;
            this.animalTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalTypeLabel.Location = new System.Drawing.Point(175, 102);
            this.animalTypeLabel.Name = "animalTypeLabel";
            this.animalTypeLabel.Size = new System.Drawing.Size(137, 29);
            this.animalTypeLabel.TabIndex = 16;
            this.animalTypeLabel.Text = "Animal type";
            // 
            // breedLabel
            // 
            this.breedLabel.AutoSize = true;
            this.breedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breedLabel.Location = new System.Drawing.Point(175, 179);
            this.breedLabel.Name = "breedLabel";
            this.breedLabel.Size = new System.Drawing.Size(79, 29);
            this.breedLabel.TabIndex = 17;
            this.breedLabel.Text = "Breed";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(175, 257);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(94, 29);
            this.genderLabel.TabIndex = 18;
            this.genderLabel.Text = "Gender";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(175, 335);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(56, 29);
            this.ageLabel.TabIndex = 19;
            this.ageLabel.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Description";
            // 
            // ageBox
            // 
            this.ageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageBox.Location = new System.Drawing.Point(365, 335);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(300, 34);
            this.ageBox.TabIndex = 22;
            // 
            // genderBox
            // 
            this.genderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderBox.Location = new System.Drawing.Point(365, 257);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(300, 34);
            this.genderBox.TabIndex = 23;
            // 
            // breedBox
            // 
            this.breedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breedBox.Location = new System.Drawing.Point(365, 179);
            this.breedBox.Name = "breedBox";
            this.breedBox.Size = new System.Drawing.Size(300, 34);
            this.breedBox.TabIndex = 24;
            // 
            // animalTypeBox
            // 
            this.animalTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalTypeBox.Location = new System.Drawing.Point(365, 102);
            this.animalTypeBox.Name = "animalTypeBox";
            this.animalTypeBox.Size = new System.Drawing.Size(300, 34);
            this.animalTypeBox.TabIndex = 25;
            // 
            // descriptionBox
            // 
            this.descriptionBox.BackColor = System.Drawing.SystemColors.Window;
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(365, 431);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(300, 177);
            this.descriptionBox.TabIndex = 27;
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.BackColor = System.Drawing.SystemColors.Window;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(1065, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(25, 24);
            this.closeBtn.TabIndex = 28;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // seeCommentsBtn
            // 
            this.seeCommentsBtn.BackColor = System.Drawing.Color.Bisque;
            this.seeCommentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeCommentsBtn.Location = new System.Drawing.Point(107, 369);
            this.seeCommentsBtn.Name = "seeCommentsBtn";
            this.seeCommentsBtn.Size = new System.Drawing.Size(212, 109);
            this.seeCommentsBtn.TabIndex = 10;
            this.seeCommentsBtn.Text = "See Comments On This Post";
            this.seeCommentsBtn.UseVisualStyleBackColor = false;
            this.seeCommentsBtn.Click += new System.EventHandler(this.seeCommentsBtn_Click);
            // 
            // SelectedPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.animalTypeBox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.breedBox);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.breedLabel);
            this.Controls.Add(this.animalTypeLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectedPostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectedAddForm";
            this.Load += new System.EventHandler(this.SelectedPostForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label animalTypeLabel;
        private System.Windows.Forms.Label breedLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox genderBox;
        private System.Windows.Forms.TextBox breedBox;
        private System.Windows.Forms.TextBox animalTypeBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Button seeCommentsBtn;
    }
}