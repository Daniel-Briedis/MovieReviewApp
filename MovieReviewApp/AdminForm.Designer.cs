namespace MovieReviewApp
{
    partial class AdminUsers
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.btnViewMovies = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(351, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Users";
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(134, 137);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(530, 150);
            this.dgvUsers.TabIndex = 1;
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(238, 308);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(83, 33);
            this.btnLock.TabIndex = 2;
            this.btnLock.Text = "Lock User";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.Location = new System.Drawing.Point(356, 308);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(76, 33);
            this.btnUnlock.TabIndex = 3;
            this.btnUnlock.Text = "Unlock User";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // btnViewMovies
            // 
            this.btnViewMovies.Location = new System.Drawing.Point(475, 308);
            this.btnViewMovies.Name = "btnViewMovies";
            this.btnViewMovies.Size = new System.Drawing.Size(78, 42);
            this.btnViewMovies.TabIndex = 4;
            this.btnViewMovies.Text = "View All Movies";
            this.btnViewMovies.UseVisualStyleBackColor = true;
            this.btnViewMovies.Click += new System.EventHandler(this.btnViewMovies_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewMovies);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Button btnViewMovies;
    }
}