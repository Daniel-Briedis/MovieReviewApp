namespace MovieReviewApp
{
    partial class ViewProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtCounter = new System.Windows.Forms.TextBox();
            this.DONTUSE = new System.Windows.Forms.ListBox();
            this.rtbReviewed = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movies Reviewed:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(116, 6);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 2;
            // 
            // txtCounter
            // 
            this.txtCounter.Location = new System.Drawing.Point(116, 29);
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.ReadOnly = true;
            this.txtCounter.Size = new System.Drawing.Size(34, 20);
            this.txtCounter.TabIndex = 3;
            // 
            // DONTUSE
            // 
            this.DONTUSE.FormattingEnabled = true;
            this.DONTUSE.Location = new System.Drawing.Point(977, 388);
            this.DONTUSE.Name = "DONTUSE";
            this.DONTUSE.Size = new System.Drawing.Size(152, 160);
            this.DONTUSE.TabIndex = 4;
            this.DONTUSE.SelectedIndexChanged += new System.EventHandler(this.lbMovies_SelectedIndexChanged);
            // 
            // rtbReviewed
            // 
            this.rtbReviewed.Location = new System.Drawing.Point(15, 68);
            this.rtbReviewed.Name = "rtbReviewed";
            this.rtbReviewed.ReadOnly = true;
            this.rtbReviewed.Size = new System.Drawing.Size(192, 137);
            this.rtbReviewed.TabIndex = 5;
            this.rtbReviewed.Text = "";
            // 
            // ViewProfile
            // 
            this.ClientSize = new System.Drawing.Size(251, 217);
            this.Controls.Add(this.rtbReviewed);
            this.Controls.Add(this.DONTUSE);
            this.Controls.Add(this.txtCounter);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewProfile";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblReviewed;
        private System.Windows.Forms.ListBox lbReviewed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtCounter;
        private System.Windows.Forms.ListBox DONTUSE;
        private System.Windows.Forms.RichTextBox rtbReviewed;
    }
}