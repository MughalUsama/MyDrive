namespace UserManagementSystem
{
    partial class NewUserForm
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
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.loginTxtBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTxtBox = new System.Windows.Forms.RichTextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.nicLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.sportsLabel = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.NumericUpDown();
            this.nicTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.cricketCheckBox = new System.Windows.Forms.CheckBox();
            this.hockeyCheckBox = new System.Windows.Forms.CheckBox();
            this.chessCheckBox = new System.Windows.Forms.CheckBox();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider9 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider10 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider10)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(95, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(159, 25);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(171, 20);
            this.nameTxtBox.TabIndex = 1;
            this.nameTxtBox.Leave += new System.EventHandler(this.NameTxtBox_Leave);
            // 
            // loginTxtBox
            // 
            this.loginTxtBox.Location = new System.Drawing.Point(159, 58);
            this.loginTxtBox.Name = "loginTxtBox";
            this.loginTxtBox.Size = new System.Drawing.Size(171, 20);
            this.loginTxtBox.TabIndex = 3;
            this.loginTxtBox.Leave += new System.EventHandler(this.LoginTxtBox_Leave);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(95, 59);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(159, 89);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(171, 20);
            this.passwordTxtBox.TabIndex = 5;
            this.passwordTxtBox.Leave += new System.EventHandler(this.PasswordTxtBox_Leave);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(95, 90);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(159, 125);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(171, 20);
            this.emailTxtBox.TabIndex = 7;
            this.emailTxtBox.Leave += new System.EventHandler(this.EmailTxtBox_Leave);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(95, 126);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(95, 162);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(42, 13);
            this.genderLabel.TabIndex = 8;
            this.genderLabel.Text = "Gender";
            // 
            // genderBox
            // 
            this.genderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderBox.Location = new System.Drawing.Point(159, 160);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(171, 21);
            this.genderBox.TabIndex = 9;
            this.genderBox.Leave += new System.EventHandler(this.GenderBox_Leave);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(95, 225);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Address";
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(159, 187);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(171, 106);
            this.addressTxtBox.TabIndex = 11;
            this.addressTxtBox.Text = "";
            this.addressTxtBox.Leave += new System.EventHandler(this.AddressTxtBox_Leave);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(95, 308);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 12;
            this.ageLabel.Text = "Age";
            // 
            // nicLabel
            // 
            this.nicLabel.AutoSize = true;
            this.nicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicLabel.Location = new System.Drawing.Point(95, 335);
            this.nicLabel.Name = "nicLabel";
            this.nicLabel.Size = new System.Drawing.Size(25, 13);
            this.nicLabel.TabIndex = 13;
            this.nicLabel.Text = "NIC";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(95, 361);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(30, 13);
            this.dobLabel.TabIndex = 14;
            this.dobLabel.Text = "DOB";
            // 
            // sportsLabel
            // 
            this.sportsLabel.AutoSize = true;
            this.sportsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sportsLabel.Location = new System.Drawing.Point(95, 395);
            this.sportsLabel.Name = "sportsLabel";
            this.sportsLabel.Size = new System.Drawing.Size(37, 13);
            this.sportsLabel.TabIndex = 15;
            this.sportsLabel.Text = "Sports";
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(159, 306);
            this.ageBox.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.ageBox.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(103, 20);
            this.ageBox.TabIndex = 16;
            this.ageBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nicTxtBox
            // 
            this.nicTxtBox.Location = new System.Drawing.Point(159, 332);
            this.nicTxtBox.Mask = "00000-0000000-0";
            this.nicTxtBox.Name = "nicTxtBox";
            this.nicTxtBox.Size = new System.Drawing.Size(103, 20);
            this.nicTxtBox.TabIndex = 17;
            this.nicTxtBox.Leave += new System.EventHandler(this.NicTxtBox_Leave);
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(159, 359);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(198, 20);
            this.dobPicker.TabIndex = 18;
            // 
            // cricketCheckBox
            // 
            this.cricketCheckBox.AutoSize = true;
            this.cricketCheckBox.Location = new System.Drawing.Point(159, 394);
            this.cricketCheckBox.Name = "cricketCheckBox";
            this.cricketCheckBox.Size = new System.Drawing.Size(63, 17);
            this.cricketCheckBox.TabIndex = 19;
            this.cricketCheckBox.Text = "Cricket";
            this.cricketCheckBox.UseVisualStyleBackColor = true;
            // 
            // hockeyCheckBox
            // 
            this.hockeyCheckBox.AutoSize = true;
            this.hockeyCheckBox.Location = new System.Drawing.Point(224, 394);
            this.hockeyCheckBox.Name = "hockeyCheckBox";
            this.hockeyCheckBox.Size = new System.Drawing.Size(64, 17);
            this.hockeyCheckBox.TabIndex = 20;
            this.hockeyCheckBox.Text = "Hockey";
            this.hockeyCheckBox.UseVisualStyleBackColor = true;
            // 
            // chessCheckBox
            // 
            this.chessCheckBox.AutoSize = true;
            this.chessCheckBox.Location = new System.Drawing.Point(293, 394);
            this.chessCheckBox.Name = "chessCheckBox";
            this.chessCheckBox.Size = new System.Drawing.Size(56, 17);
            this.chessCheckBox.TabIndex = 21;
            this.chessCheckBox.Text = "Chess";
            this.chessCheckBox.UseVisualStyleBackColor = true;
            // 
            // userPictureBox
            // 
            this.userPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userPictureBox.Location = new System.Drawing.Point(495, 25);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(178, 156);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 22;
            this.userPictureBox.TabStop = false;
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(526, 196);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(119, 32);
            this.uploadBtn.TabIndex = 23;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(287, 446);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(95, 34);
            this.createBtn.TabIndex = 24;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(397, 446);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(95, 34);
            this.cancelBtn.TabIndex = 25;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "All Image Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff|JPG|*.jpg;*.jpeg|BMP|*.bmp|" +
    "GIF|*.gif|PNG|*.png|TIFF|*.tif;*.tiff";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // errorProvider8
            // 
            this.errorProvider8.ContainerControl = this;
            // 
            // errorProvider9
            // 
            this.errorProvider9.ContainerControl = this;
            // 
            // errorProvider10
            // 
            this.errorProvider10.ContainerControl = this;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.chessCheckBox);
            this.Controls.Add(this.hockeyCheckBox);
            this.Controls.Add(this.cricketCheckBox);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.nicTxtBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.sportsLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.nicLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginTxtBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewUserForm_FormClosing);
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox loginTxtBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.RichTextBox addressTxtBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label nicLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label sportsLabel;
        private System.Windows.Forms.NumericUpDown ageBox;
        private System.Windows.Forms.MaskedTextBox nicTxtBox;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.CheckBox cricketCheckBox;
        private System.Windows.Forms.CheckBox hockeyCheckBox;
        private System.Windows.Forms.CheckBox chessCheckBox;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.ErrorProvider errorProvider8;
        private System.Windows.Forms.ErrorProvider errorProvider9;
        private System.Windows.Forms.ErrorProvider errorProvider10;
    }
}