namespace GameClub
{
    partial class AddClient
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
            this.panelEditInfo = new System.Windows.Forms.Panel();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.fathernameInput = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.surnameInput = new System.Windows.Forms.TextBox();
            this.birthdayInput = new System.Windows.Forms.DateTimePicker();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.userTableAdapter1 = new GameClub.GamuClubDBDataSetTableAdapters.UserTableAdapter();
            this.authentificationTableAdapter1 = new GameClub.GamuClubDBDataSetTableAdapters.AuthentificationTableAdapter();
            this.panelEditInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEditInfo
            // 
            this.panelEditInfo.Controls.Add(this.btnGeneratePassword);
            this.panelEditInfo.Controls.Add(this.label15);
            this.panelEditInfo.Controls.Add(this.label16);
            this.panelEditInfo.Controls.Add(this.passwordInput);
            this.panelEditInfo.Controls.Add(this.label17);
            this.panelEditInfo.Controls.Add(this.loginInput);
            this.panelEditInfo.Controls.Add(this.label18);
            this.panelEditInfo.Controls.Add(this.emailInput);
            this.panelEditInfo.Controls.Add(this.label19);
            this.panelEditInfo.Controls.Add(this.label20);
            this.panelEditInfo.Controls.Add(this.fathernameInput);
            this.panelEditInfo.Controls.Add(this.label21);
            this.panelEditInfo.Controls.Add(this.nameInput);
            this.panelEditInfo.Controls.Add(this.surnameInput);
            this.panelEditInfo.Controls.Add(this.birthdayInput);
            this.panelEditInfo.Location = new System.Drawing.Point(14, 25);
            this.panelEditInfo.Name = "panelEditInfo";
            this.panelEditInfo.Size = new System.Drawing.Size(522, 362);
            this.panelEditInfo.TabIndex = 25;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(276, 293);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(200, 48);
            this.btnGeneratePassword.TabIndex = 32;
            this.btnGeneratePassword.Text = "Сгенерировать пароль";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(43, 265);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Пароль:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(43, 225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 20);
            this.label16.TabIndex = 30;
            this.label16.Text = "Логин:";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(276, 260);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(200, 27);
            this.passwordInput.TabIndex = 13;
            this.passwordInput.TextChanged += new System.EventHandler(this.surnameInput_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(43, 145);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(146, 20);
            this.label17.TabIndex = 29;
            this.label17.Text = "Дата рождения:";
            // 
            // loginInput
            // 
            this.loginInput.Location = new System.Drawing.Point(276, 220);
            this.loginInput.Name = "loginInput";
            this.loginInput.ReadOnly = true;
            this.loginInput.Size = new System.Drawing.Size(200, 27);
            this.loginInput.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(43, 185);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(181, 20);
            this.label18.TabIndex = 28;
            this.label18.Text = "Электронная почта:";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(276, 180);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(200, 27);
            this.emailInput.TabIndex = 11;
            this.emailInput.TextChanged += new System.EventHandler(this.surnameInput_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(43, 105);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 20);
            this.label19.TabIndex = 27;
            this.label19.Text = "Отчество:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(43, 65);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 20);
            this.label20.TabIndex = 26;
            this.label20.Text = "Имя:";
            // 
            // fathernameInput
            // 
            this.fathernameInput.Location = new System.Drawing.Point(276, 100);
            this.fathernameInput.Name = "fathernameInput";
            this.fathernameInput.Size = new System.Drawing.Size(200, 27);
            this.fathernameInput.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(43, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 20);
            this.label21.TabIndex = 25;
            this.label21.Text = "Фамилия:";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(276, 60);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(200, 27);
            this.nameInput.TabIndex = 9;
            this.nameInput.TextChanged += new System.EventHandler(this.surnameInput_TextChanged);
            // 
            // surnameInput
            // 
            this.surnameInput.Location = new System.Drawing.Point(276, 24);
            this.surnameInput.Name = "surnameInput";
            this.surnameInput.Size = new System.Drawing.Size(200, 27);
            this.surnameInput.TabIndex = 8;
            this.surnameInput.TextChanged += new System.EventHandler(this.surnameInput_TextChanged);
            // 
            // birthdayInput
            // 
            this.birthdayInput.Checked = false;
            this.birthdayInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdayInput.Location = new System.Drawing.Point(276, 140);
            this.birthdayInput.Name = "birthdayInput";
            this.birthdayInput.ShowCheckBox = true;
            this.birthdayInput.Size = new System.Drawing.Size(200, 27);
            this.birthdayInput.TabIndex = 7;
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveInfo.Location = new System.Drawing.Point(336, 411);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(200, 33);
            this.btnSaveInfo.TabIndex = 23;
            this.btnSaveInfo.Text = "Сохранить";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(14, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 33);
            this.button1.TabIndex = 26;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // authentificationTableAdapter1
            // 
            this.authentificationTableAdapter1.ClearBeforeFill = true;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 463);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelEditInfo);
            this.Controls.Add(this.btnSaveInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент";
            this.panelEditInfo.ResumeLayout(false);
            this.panelEditInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEditInfo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private GamuClubDBDataSetTableAdapters.UserTableAdapter userTableAdapter1;
        private GamuClubDBDataSetTableAdapters.AuthentificationTableAdapter authentificationTableAdapter1;
        public System.Windows.Forms.TextBox emailInput;
        public System.Windows.Forms.TextBox fathernameInput;
        public System.Windows.Forms.TextBox nameInput;
        public System.Windows.Forms.TextBox surnameInput;
        public System.Windows.Forms.DateTimePicker birthdayInput;
        public System.Windows.Forms.TextBox passwordInput;
        public System.Windows.Forms.TextBox loginInput;
        public System.Windows.Forms.Button btnSaveInfo;
    }
}