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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 252);
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
    }
}