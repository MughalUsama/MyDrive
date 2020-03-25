namespace UserManagementSystem
{
    partial class MainScreen
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
            this.newUserBtn = new System.Windows.Forms.Button();
            this.exUserBtn = new System.Windows.Forms.Button();
            this.adminBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newUserBtn
            // 
            this.newUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserBtn.Location = new System.Drawing.Point(338, 81);
            this.newUserBtn.Name = "newUserBtn";
            this.newUserBtn.Size = new System.Drawing.Size(139, 63);
            this.newUserBtn.TabIndex = 0;
            this.newUserBtn.Text = "New User";
            this.newUserBtn.UseVisualStyleBackColor = true;
            this.newUserBtn.Click += new System.EventHandler(this.NewUserBtn_Click);
            // 
            // exUserBtn
            // 
            this.exUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exUserBtn.Location = new System.Drawing.Point(338, 150);
            this.exUserBtn.Name = "exUserBtn";
            this.exUserBtn.Size = new System.Drawing.Size(139, 63);
            this.exUserBtn.TabIndex = 1;
            this.exUserBtn.Text = "Existing User";
            this.exUserBtn.UseVisualStyleBackColor = true;
            this.exUserBtn.Click += new System.EventHandler(this.ExUserBtn_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.Location = new System.Drawing.Point(338, 219);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(139, 63);
            this.adminBtn.TabIndex = 2;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(338, 288);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(139, 63);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.exUserBtn);
            this.Controls.Add(this.newUserBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newUserBtn;
        private System.Windows.Forms.Button exUserBtn;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

