namespace GameClub
{
    partial class AddReservation
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
            this.button1 = new System.Windows.Forms.Button();
            this.panelEditInfo = new System.Windows.Forms.Panel();
            this.roomInput = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timestartInput = new System.Windows.Forms.ComboBox();
            this.tariffInput = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.resdateInput = new System.Windows.Forms.DateTimePicker();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.reservationTableAdapter1 = new GameClub.GamuClubDBDataSetTableAdapters.ReservationTableAdapter();
            this.tariffTableAdapter1 = new GameClub.GamuClubDBDataSetTableAdapters.TariffTableAdapter();
            this.panelEditInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(15, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 33);
            this.button1.TabIndex = 29;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelEditInfo
            // 
            this.panelEditInfo.Controls.Add(this.roomInput);
            this.panelEditInfo.Controls.Add(this.label2);
            this.panelEditInfo.Controls.Add(this.timestartInput);
            this.panelEditInfo.Controls.Add(this.tariffInput);
            this.panelEditInfo.Controls.Add(this.label19);
            this.panelEditInfo.Controls.Add(this.label20);
            this.panelEditInfo.Controls.Add(this.label21);
            this.panelEditInfo.Controls.Add(this.resdateInput);
            this.panelEditInfo.Location = new System.Drawing.Point(15, 22);
            this.panelEditInfo.Name = "panelEditInfo";
            this.panelEditInfo.Size = new System.Drawing.Size(522, 197);
            this.panelEditInfo.TabIndex = 28;
            // 
            // roomInput
            // 
            this.roomInput.FormattingEnabled = true;
            this.roomInput.Location = new System.Drawing.Point(276, 138);
            this.roomInput.Name = "roomInput";
            this.roomInput.Size = new System.Drawing.Size(200, 28);
            this.roomInput.TabIndex = 33;
            this.roomInput.SelectedIndexChanged += new System.EventHandler(this.tariffInput_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Зал:";
            // 
            // timestartInput
            // 
            this.timestartInput.FormattingEnabled = true;
            this.timestartInput.Items.AddRange(new object[] {
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00"});
            this.timestartInput.Location = new System.Drawing.Point(276, 97);
            this.timestartInput.Name = "timestartInput";
            this.timestartInput.Size = new System.Drawing.Size(200, 28);
            this.timestartInput.TabIndex = 31;
            this.timestartInput.SelectedIndexChanged += new System.EventHandler(this.tariffInput_SelectedIndexChanged);
            // 
            // tariffInput
            // 
            this.tariffInput.FormattingEnabled = true;
            this.tariffInput.Location = new System.Drawing.Point(276, 22);
            this.tariffInput.Name = "tariffInput";
            this.tariffInput.Size = new System.Drawing.Size(200, 28);
            this.tariffInput.TabIndex = 30;
            this.tariffInput.SelectedIndexChanged += new System.EventHandler(this.tariffInput_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(43, 103);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(133, 20);
            this.label19.TabIndex = 27;
            this.label19.Text = "Время начала:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(43, 65);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 20);
            this.label20.TabIndex = 26;
            this.label20.Text = "Дата:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(43, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 20);
            this.label21.TabIndex = 25;
            this.label21.Text = "Тариф:";
            // 
            // resdateInput
            // 
            this.resdateInput.Checked = false;
            this.resdateInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.resdateInput.Location = new System.Drawing.Point(276, 60);
            this.resdateInput.Name = "resdateInput";
            this.resdateInput.Size = new System.Drawing.Size(200, 27);
            this.resdateInput.TabIndex = 7;
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveInfo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveInfo.Location = new System.Drawing.Point(337, 243);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(200, 33);
            this.btnSaveInfo.TabIndex = 27;
            this.btnSaveInfo.Text = "Сохранить";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // reservationTableAdapter1
            // 
            this.reservationTableAdapter1.ClearBeforeFill = true;
            // 
            // tariffTableAdapter1
            // 
            this.tariffTableAdapter1.ClearBeforeFill = true;
            // 
            // AddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 298);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelEditInfo);
            this.Controls.Add(this.btnSaveInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddReservation";
            this.panelEditInfo.ResumeLayout(false);
            this.panelEditInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelEditInfo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.DateTimePicker resdateInput;
        public System.Windows.Forms.Button btnSaveInfo;
        private GamuClubDBDataSetTableAdapters.ReservationTableAdapter reservationTableAdapter1;
        private GamuClubDBDataSetTableAdapters.TariffTableAdapter tariffTableAdapter1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox tariffInput;
        public System.Windows.Forms.ComboBox timestartInput;
        public System.Windows.Forms.ComboBox roomInput;
    }
}