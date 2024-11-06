namespace GameClub
{
    partial class GCUser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.personalProfile = new System.Windows.Forms.TabPage();
            this.panelEditInfo = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSaveInfo = new System.Windows.Forms.Button();
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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.fathernameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEditInfo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.authentificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamuClubDBDataSet = new GameClub.GamuClubDBDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter1 = new GameClub.GamuClubDBDataSetTableAdapters.UserTableAdapter();
            this.authentificationTableAdapter1 = new GameClub.GamuClubDBDataSetTableAdapters.AuthentificationTableAdapter();
            this.reservationDataGrid = new System.Windows.Forms.DataGridView();
            this.reservationTableAdapter1 = new GameClub.GamuClubDBDataSetTableAdapters.ReservationTableAdapter();
            this.tabControl1.SuspendLayout();
            this.personalProfile.SuspendLayout();
            this.panelEditInfo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authentificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamuClubDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.personalProfile);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // personalProfile
            // 
            this.personalProfile.Controls.Add(this.panelEditInfo);
            this.personalProfile.Controls.Add(this.passwordLabel);
            this.personalProfile.Controls.Add(this.loginLabel);
            this.personalProfile.Controls.Add(this.emailLabel);
            this.personalProfile.Controls.Add(this.birthdayLabel);
            this.personalProfile.Controls.Add(this.fathernameLabel);
            this.personalProfile.Controls.Add(this.nameLabel);
            this.personalProfile.Controls.Add(this.surnameLabel);
            this.personalProfile.Controls.Add(this.btnExit);
            this.personalProfile.Controls.Add(this.btnEditInfo);
            this.personalProfile.Controls.Add(this.label7);
            this.personalProfile.Controls.Add(this.label6);
            this.personalProfile.Controls.Add(this.label5);
            this.personalProfile.Controls.Add(this.label4);
            this.personalProfile.Controls.Add(this.label3);
            this.personalProfile.Controls.Add(this.label2);
            this.personalProfile.Controls.Add(this.label1);
            this.personalProfile.Location = new System.Drawing.Point(4, 29);
            this.personalProfile.Name = "personalProfile";
            this.personalProfile.Padding = new System.Windows.Forms.Padding(3);
            this.personalProfile.Size = new System.Drawing.Size(992, 529);
            this.personalProfile.TabIndex = 0;
            this.personalProfile.Text = "Личный кабинет";
            this.personalProfile.UseVisualStyleBackColor = true;
            // 
            // panelEditInfo
            // 
            this.panelEditInfo.Controls.Add(this.label15);
            this.panelEditInfo.Controls.Add(this.btnSaveInfo);
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
            this.panelEditInfo.Location = new System.Drawing.Point(441, 15);
            this.panelEditInfo.Name = "panelEditInfo";
            this.panelEditInfo.Size = new System.Drawing.Size(522, 395);
            this.panelEditInfo.TabIndex = 24;
            this.panelEditInfo.Visible = false;
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
            // btnSaveInfo
            // 
            this.btnSaveInfo.Location = new System.Drawing.Point(160, 356);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(200, 33);
            this.btnSaveInfo.TabIndex = 23;
            this.btnSaveInfo.Text = "Сохранить";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
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
            this.loginInput.Size = new System.Drawing.Size(200, 27);
            this.loginInput.TabIndex = 12;
            this.loginInput.TextChanged += new System.EventHandler(this.surnameInput_TextChanged);
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
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authentificationBindingSource, "password", true));
            this.passwordLabel.Location = new System.Drawing.Point(277, 280);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(62, 20);
            this.passwordLabel.TabIndex = 22;
            this.passwordLabel.Text = "label14";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authentificationBindingSource, "login", true));
            this.loginLabel.Location = new System.Drawing.Point(277, 240);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(62, 20);
            this.loginLabel.TabIndex = 21;
            this.loginLabel.Text = "label13";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "email", true));
            this.emailLabel.Location = new System.Drawing.Point(277, 200);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(62, 20);
            this.emailLabel.TabIndex = 20;
            this.emailLabel.Text = "label12";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "birthday", true));
            this.birthdayLabel.Location = new System.Drawing.Point(277, 160);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(62, 20);
            this.birthdayLabel.TabIndex = 19;
            this.birthdayLabel.Text = "label11";
            // 
            // fathernameLabel
            // 
            this.fathernameLabel.AutoSize = true;
            this.fathernameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "fathername", true));
            this.fathernameLabel.Location = new System.Drawing.Point(277, 120);
            this.fathernameLabel.Name = "fathernameLabel";
            this.fathernameLabel.Size = new System.Drawing.Size(62, 20);
            this.fathernameLabel.TabIndex = 18;
            this.fathernameLabel.Text = "label10";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "name", true));
            this.nameLabel.Location = new System.Drawing.Point(277, 80);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 20);
            this.nameLabel.TabIndex = 17;
            this.nameLabel.Text = "label9";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "surname", true));
            this.surnameLabel.Location = new System.Drawing.Point(277, 40);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(53, 20);
            this.surnameLabel.TabIndex = 16;
            this.surnameLabel.Text = "label8";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(44, 462);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(336, 33);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.Location = new System.Drawing.Point(44, 423);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(336, 33);
            this.btnEditInfo.TabIndex = 14;
            this.btnEditInfo.Text = "Редактировать личную информацию";
            this.btnEditInfo.UseVisualStyleBackColor = true;
            this.btnEditInfo.Click += new System.EventHandler(this.btnEditInfo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Пароль:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Логин:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата рождения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Электронная почта:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.reservationDataGrid);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 529);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Бронирование";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(628, 413);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(992, 529);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Сеанс";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // authentificationBindingSource
            // 
            this.authentificationBindingSource.DataMember = "Authentification";
            this.authentificationBindingSource.DataSource = this.gamuClubDBDataSet;
            // 
            // gamuClubDBDataSet
            // 
            this.gamuClubDBDataSet.DataSetName = "GamuClubDBDataSet";
            this.gamuClubDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.gamuClubDBDataSet;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // authentificationTableAdapter1
            // 
            this.authentificationTableAdapter1.ClearBeforeFill = true;
            // 
            // reservationDataGrid
            // 
            this.reservationDataGrid.AllowUserToAddRows = false;
            this.reservationDataGrid.AllowUserToDeleteRows = false;
            this.reservationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationDataGrid.Location = new System.Drawing.Point(34, 30);
            this.reservationDataGrid.Name = "reservationDataGrid";
            this.reservationDataGrid.ReadOnly = true;
            this.reservationDataGrid.RowHeadersWidth = 51;
            this.reservationDataGrid.RowTemplate.Height = 24;
            this.reservationDataGrid.Size = new System.Drawing.Size(926, 237);
            this.reservationDataGrid.TabIndex = 1;
            // 
            // reservationTableAdapter1
            // 
            this.reservationTableAdapter1.ClearBeforeFill = true;
            // 
            // GCUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GCUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameClub Личный кабинет";
            this.Load += new System.EventHandler(this.GCUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.personalProfile.ResumeLayout(false);
            this.personalProfile.PerformLayout();
            this.panelEditInfo.ResumeLayout(false);
            this.panelEditInfo.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.authentificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamuClubDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage personalProfile;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox surnameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox loginInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox fathernameInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Panel panelEditInfo;
        private System.Windows.Forms.Button btnSaveInfo;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label fathernameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEditInfo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.BindingSource userBindingSource;
        private GamuClubDBDataSet gamuClubDBDataSet;
        private GamuClubDBDataSetTableAdapters.UserTableAdapter userTableAdapter1;
        private GamuClubDBDataSetTableAdapters.AuthentificationTableAdapter authentificationTableAdapter1;
        private System.Windows.Forms.BindingSource authentificationBindingSource;
        private System.Windows.Forms.DateTimePicker birthdayInput;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView reservationDataGrid;
        private GamuClubDBDataSetTableAdapters.ReservationTableAdapter reservationTableAdapter1;
    }
}