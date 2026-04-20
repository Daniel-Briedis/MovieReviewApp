namespace MovieReviewApp
{
    partial class Main
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
            this.btnProfle = new System.Windows.Forms.Button();
            this.btnEditPf = new System.Windows.Forms.Button();
            this.lbOtherPf = new System.Windows.Forms.ListBox();
            this.lblUsers = new System.Windows.Forms.Label();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProfle
            // 
            this.btnProfle.Location = new System.Drawing.Point(12, 12);
            this.btnProfle.Name = "btnProfle";
            this.btnProfle.Size = new System.Drawing.Size(75, 23);
            this.btnProfle.TabIndex = 0;
            this.btnProfle.Text = "View Profile";
            this.btnProfle.UseVisualStyleBackColor = true;
            this.btnProfle.Click += new System.EventHandler(this.btnProfle_Click);
            // 
            // btnEditPf
            // 
            this.btnEditPf.Location = new System.Drawing.Point(12, 41);
            this.btnEditPf.Name = "btnEditPf";
            this.btnEditPf.Size = new System.Drawing.Size(75, 23);
            this.btnEditPf.TabIndex = 1;
            this.btnEditPf.Text = "Edit Profile";
            this.btnEditPf.UseVisualStyleBackColor = true;
            this.btnEditPf.Click += new System.EventHandler(this.btnEditPf_Click);
            // 
            // lbOtherPf
            // 
            this.lbOtherPf.FormattingEnabled = true;
            this.lbOtherPf.Location = new System.Drawing.Point(187, 12);
            this.lbOtherPf.Name = "lbOtherPf";
            this.lbOtherPf.Size = new System.Drawing.Size(210, 212);
            this.lbOtherPf.TabIndex = 2;
            this.lbOtherPf.SelectedIndexChanged += new System.EventHandler(this.lbOtherPf_SelectedIndexChanged);
            this.lbOtherPf.DoubleClick += new System.EventHandler(this.lbOtherPf_SelectedIndexChanged);
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(108, 17);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(73, 13);
            this.lblUsers.TabIndex = 3;
            this.lblUsers.Text = "Other Profiles:";
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(12, 70);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(75, 23);
            this.btnAddMovie.TabIndex = 4;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(12, 201);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(109, 23);
            this.btnReview.TabIndex = 5;
            this.btnReview.Text = "Write / Edit Review";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Delete Movie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete Users";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete Review";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(322, 230);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 260);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lbOtherPf);
            this.Controls.Add(this.btnEditPf);
            this.Controls.Add(this.btnProfle);
            this.Name = "Main";
            this.Text = "Movie Reviews";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProfle;
        private System.Windows.Forms.Button btnEditPf;
        private System.Windows.Forms.ListBox lbOtherPf;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLogout;
    }
}