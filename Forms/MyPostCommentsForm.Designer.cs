namespace zavrsni_rad.Forms
{
    partial class MyPostCommentsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.postIDLabel = new System.Windows.Forms.Label();
            this.postOwnerLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.commentBtn = new System.Windows.Forms.Button();
            this.commentDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.commentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(1065, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(23, 22);
            this.closeBtn.TabIndex = 55;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 56;
            this.label1.Text = "Post ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 57;
            this.label2.Text = "Post owner:";
            // 
            // postIDLabel
            // 
            this.postIDLabel.AutoSize = true;
            this.postIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postIDLabel.Location = new System.Drawing.Point(255, 28);
            this.postIDLabel.Name = "postIDLabel";
            this.postIDLabel.Size = new System.Drawing.Size(79, 29);
            this.postIDLabel.TabIndex = 58;
            this.postIDLabel.Text = "label3";
            // 
            // postOwnerLabel
            // 
            this.postOwnerLabel.AutoSize = true;
            this.postOwnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postOwnerLabel.Location = new System.Drawing.Point(289, 85);
            this.postOwnerLabel.Name = "postOwnerLabel";
            this.postOwnerLabel.Size = new System.Drawing.Size(79, 29);
            this.postOwnerLabel.TabIndex = 59;
            this.postOwnerLabel.Text = "label3";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Bisque;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(12, 642);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 46);
            this.backBtn.TabIndex = 60;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // commentBtn
            // 
            this.commentBtn.BackColor = System.Drawing.Color.Bisque;
            this.commentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentBtn.Location = new System.Drawing.Point(427, 605);
            this.commentBtn.Name = "commentBtn";
            this.commentBtn.Size = new System.Drawing.Size(212, 49);
            this.commentBtn.TabIndex = 61;
            this.commentBtn.Text = "Comment";
            this.commentBtn.UseVisualStyleBackColor = false;
            this.commentBtn.Click += new System.EventHandler(this.commentBtn_Click);
            // 
            // commentDataGridView
            // 
            this.commentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentDataGridView.Location = new System.Drawing.Point(158, 117);
            this.commentDataGridView.Name = "commentDataGridView";
            this.commentDataGridView.RowHeadersWidth = 51;
            this.commentDataGridView.RowTemplate.Height = 24;
            this.commentDataGridView.Size = new System.Drawing.Size(778, 482);
            this.commentDataGridView.TabIndex = 62;
            // 
            // MyPostCommentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.commentDataGridView);
            this.Controls.Add(this.commentBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.postOwnerLabel);
            this.Controls.Add(this.postIDLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyPostCommentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPostCommentsForm";
            this.Load += new System.EventHandler(this.MyPostCommentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label postIDLabel;
        private System.Windows.Forms.Label postOwnerLabel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button commentBtn;
        private System.Windows.Forms.DataGridView commentDataGridView;
    }
}