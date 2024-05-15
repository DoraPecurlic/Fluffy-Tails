namespace zavrsni_rad.Forms
{
    partial class SubmitPostForm
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
            this.animalTypeLabel = new System.Windows.Forms.Label();
            this.breedLabel = new System.Windows.Forms.Label();
            this.breedBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maleRadioBtn = new System.Windows.Forms.RadioButton();
            this.femaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.genderLabel = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.animalTypeBox = new System.Windows.Forms.ComboBox();
            this.closeBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // animalTypeLabel
            // 
            this.animalTypeLabel.AutoSize = true;
            this.animalTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalTypeLabel.Location = new System.Drawing.Point(425, 102);
            this.animalTypeLabel.Name = "animalTypeLabel";
            this.animalTypeLabel.Size = new System.Drawing.Size(241, 29);
            this.animalTypeLabel.TabIndex = 0;
            this.animalTypeLabel.Text = "Select an animal type";
            // 
            // breedLabel
            // 
            this.breedLabel.AutoSize = true;
            this.breedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breedLabel.Location = new System.Drawing.Point(425, 183);
            this.breedLabel.Name = "breedLabel";
            this.breedLabel.Size = new System.Drawing.Size(140, 29);
            this.breedLabel.TabIndex = 2;
            this.breedLabel.Text = "Enter breed";
            this.breedLabel.Click += new System.EventHandler(this.breedLabel_Click);
            // 
            // breedBox
            // 
            this.breedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breedBox.Location = new System.Drawing.Point(725, 178);
            this.breedBox.Name = "breedBox";
            this.breedBox.Size = new System.Drawing.Size(300, 34);
            this.breedBox.TabIndex = 3;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(425, 328);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(117, 29);
            this.AgeLabel.TabIndex = 4;
            this.AgeLabel.Text = "Enter age";
            // 
            // ageBox
            // 
            this.ageBox.BackColor = System.Drawing.SystemColors.Window;
            this.ageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageBox.Location = new System.Drawing.Point(725, 323);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(300, 34);
            this.ageBox.TabIndex = 5;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(425, 396);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(195, 29);
            this.DescriptionLabel.TabIndex = 6;
            this.DescriptionLabel.Text = "Enter description";
            // 
            // descriptionBox
            // 
            this.descriptionBox.BackColor = System.Drawing.SystemColors.Window;
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(725, 393);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(300, 177);
            this.descriptionBox.TabIndex = 7;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = global::zavrsni_rad.Properties.Resources.FLUFFYTAILS1;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Enabled = false;
            this.pictureBox.Location = new System.Drawing.Point(40, 102);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 300);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // UploadBtn
            // 
            this.UploadBtn.BackColor = System.Drawing.Color.Bisque;
            this.UploadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadBtn.Location = new System.Drawing.Point(89, 408);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(212, 46);
            this.UploadBtn.TabIndex = 9;
            this.UploadBtn.Text = "Upload image";
            this.UploadBtn.UseVisualStyleBackColor = false;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Bisque;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(12, 643);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 45);
            this.backBtn.TabIndex = 13;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.UploadBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 700);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // maleRadioBtn
            // 
            this.maleRadioBtn.AutoSize = true;
            this.maleRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadioBtn.Location = new System.Drawing.Point(725, 253);
            this.maleRadioBtn.Name = "maleRadioBtn";
            this.maleRadioBtn.Size = new System.Drawing.Size(87, 33);
            this.maleRadioBtn.TabIndex = 17;
            this.maleRadioBtn.TabStop = true;
            this.maleRadioBtn.Text = "Male";
            this.maleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // femaleRadioBtn
            // 
            this.femaleRadioBtn.AutoSize = true;
            this.femaleRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadioBtn.Location = new System.Drawing.Point(869, 253);
            this.femaleRadioBtn.Name = "femaleRadioBtn";
            this.femaleRadioBtn.Size = new System.Drawing.Size(116, 33);
            this.femaleRadioBtn.TabIndex = 18;
            this.femaleRadioBtn.TabStop = true;
            this.femaleRadioBtn.Text = "Female";
            this.femaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(425, 257);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(164, 29);
            this.genderLabel.TabIndex = 19;
            this.genderLabel.Text = "Select gender";
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.Bisque;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(725, 614);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(300, 61);
            this.submitBtn.TabIndex = 20;
            this.submitBtn.Text = "Submit Your Post";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // animalTypeBox
            // 
            this.animalTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalTypeBox.FormattingEnabled = true;
            this.animalTypeBox.Location = new System.Drawing.Point(725, 102);
            this.animalTypeBox.Name = "animalTypeBox";
            this.animalTypeBox.Size = new System.Drawing.Size(300, 37);
            this.animalTypeBox.TabIndex = 23;
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(1065, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(23, 22);
            this.closeBtn.TabIndex = 29;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // SubmitAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.animalTypeBox);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.femaleRadioBtn);
            this.Controls.Add(this.maleRadioBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.breedBox);
            this.Controls.Add(this.breedLabel);
            this.Controls.Add(this.animalTypeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubmitAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubmitAddForm";
            this.Load += new System.EventHandler(this.SubmitAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label animalTypeLabel;
        private System.Windows.Forms.Label breedLabel;
        private System.Windows.Forms.TextBox breedBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton maleRadioBtn;
        private System.Windows.Forms.RadioButton femaleRadioBtn;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.ComboBox animalTypeBox;
        private System.Windows.Forms.Label closeBtn;
    }
}