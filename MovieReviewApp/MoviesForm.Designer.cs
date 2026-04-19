namespace MovieReviewApp
{
    partial class MoviesForm
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
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnDeleteReview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(335, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Movies";
            // 
            // dgvMovies
            // 
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Location = new System.Drawing.Point(138, 168);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.Size = new System.Drawing.Size(508, 150);
            this.dgvMovies.TabIndex = 1;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(268, 348);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(95, 25);
            this.btnDeleteMovie.TabIndex = 2;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnDeleteReview
            // 
            this.btnDeleteReview.Location = new System.Drawing.Point(407, 348);
            this.btnDeleteReview.Name = "btnDeleteReview";
            this.btnDeleteReview.Size = new System.Drawing.Size(95, 23);
            this.btnDeleteReview.TabIndex = 3;
            this.btnDeleteReview.Text = "Delete Review";
            this.btnDeleteReview.UseVisualStyleBackColor = true;
            this.btnDeleteReview.Click += new System.EventHandler(this.btnDeleteReview_Click);
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteReview);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.dgvMovies);
            this.Controls.Add(this.label1);
            this.Name = "MoviesForm";
            this.Text = "MoviesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnDeleteReview;
    }
}