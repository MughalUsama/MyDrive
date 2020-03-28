namespace UserManagementSystem
{
    partial class UpdatePasswordForm
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
            this.newPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.enterCodeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newPasswordTxtBox
            // 
            this.newPasswordTxtBox.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTxtBox.Location = new System.Drawing.Point(59, 64);
            this.newPasswordTxtBox.Name = "newPasswordTxtBox";
            this.newPasswordTxtBox.PasswordChar = '*';
            this.newPasswordTxtBox.Size = new System.Drawing.Size(206, 22);
            this.newPasswordTxtBox.TabIndex = 5;
            this.newPasswordTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewPasswordTxtBox_KeyDown);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(123, 103);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(85, 28);
            this.confirmBtn.TabIndex = 4;
            this.confirmBtn.Text = "Update";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // enterCodeLabel
            // 
            this.enterCodeLabel.AutoSize = true;
            this.enterCodeLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterCodeLabel.Location = new System.Drawing.Point(86, 28);
            this.enterCodeLabel.Name = "enterCodeLabel";
            this.enterCodeLabel.Size = new System.Drawing.Size(160, 19);
            this.enterCodeLabel.TabIndex = 3;
            this.enterCodeLabel.Text = "Enter New Password";
            // 
            // UpdatePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(328, 172);
            this.Controls.Add(this.newPasswordTxtBox);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.enterCodeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdatePasswordForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newPasswordTxtBox;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label enterCodeLabel;
    }
}