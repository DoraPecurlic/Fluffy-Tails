namespace zavrsni_rad.Forms
{
    partial class SubmitCommentForm
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
            this.closeBtn = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.submitCommentBtn = new System.Windows.Forms.Button();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(1065, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(23, 22);
            this.closeBtn.TabIndex = 43;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(175, 113);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(79, 29);
            this.userLabel.TabIndex = 44;
            this.userLabel.Text = "label1";
            // 
            // submitCommentBtn
            // 
            this.submitCommentBtn.BackColor = System.Drawing.Color.Bisque;
            this.submitCommentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitCommentBtn.Location = new System.Drawing.Point(444, 468);
            this.submitCommentBtn.Name = "submitCommentBtn";
            this.submitCommentBtn.Size = new System.Drawing.Size(236, 50);
            this.submitCommentBtn.TabIndex = 50;
            this.submitCommentBtn.Text = "Submit Comment";
            this.submitCommentBtn.UseVisualStyleBackColor = false;
            this.submitCommentBtn.Click += new System.EventHandler(this.submitCommentBtn_Click);
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(275, 120);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(558, 342);
            this.commentTextBox.TabIndex = 51;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Bisque;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(11, 642);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 46);
            this.backBtn.TabIndex = 52;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // SubmitCommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.submitCommentBtn);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubmitCommentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubmitCommentForm";
            this.Load += new System.EventHandler(this.SubmitCommentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button submitCommentBtn;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Button backBtn;
    }
}