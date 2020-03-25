namespace UserManagementSystem
{
    partial class HomeForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editProfBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.welcomeUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(529, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 145);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // editProfBtn
            // 
            this.editProfBtn.Location = new System.Drawing.Point(568, 206);
            this.editProfBtn.Name = "editProfBtn";
            this.editProfBtn.Size = new System.Drawing.Size(106, 32);
            this.editProfBtn.TabIndex = 1;
            this.editProfBtn.Text = "Edit Profile";
            this.editProfBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(568, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // welcomeUser
            // 
            this.welcomeUser.AutoSize = true;
            this.welcomeUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.welcomeUser.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeUser.Location = new System.Drawing.Point(54, 46);
            this.welcomeUser.Name = "welcomeUser";
            this.welcomeUser.Padding = new System.Windows.Forms.Padding(10);
            this.welcomeUser.Size = new System.Drawing.Size(102, 39);
            this.welcomeUser.TabIndex = 3;
            this.welcomeUser.Text = "Welcome ";
            this.welcomeUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcomeUser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.editProfBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HomeForm";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button editProfBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label welcomeUser;
    }
}