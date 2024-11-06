namespace GameClub
{
    partial class ChangeReservationStatusFromAdmin
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
            this.statusInput = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.reservationTableAdapter1 = new GameClub.GamuClubDBDataSetTableAdapters.ReservationTableAdapter();
            this.panelEditInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(25, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 33);
            this.button1.TabIndex = 32;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelEditInfo
            // 
            this.panelEditInfo.Controls.Add(this.statusInput);
            this.panelEditInfo.Controls.Add(this.label21);
            this.panelEditInfo.Location = new System.Drawing.Point(25, 33);
            this.panelEditInfo.Name = "panelEditInfo";
            this.panelEditInfo.Size = new System.Drawing.Size(522, 74);
            this.panelEditInfo.TabIndex = 31;
            // 
            // statusInput
            // 
            this.statusInput.FormattingEnabled = true;
            this.statusInput.Items.AddRange(new object[] {
            "Оплачено",
            "Не оплачено",
            "Отменено"});
            this.statusInput.Location = new System.Drawing.Point(276, 22);
            this.statusInput.Name = "statusInput";
            this.statusInput.Size = new System.Drawing.Size(200, 28);
            this.statusInput.TabIndex = 30;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(43, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 20);
            this.label21.TabIndex = 25;
            this.label21.Text = "Статус:";
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveInfo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveInfo.Location = new System.Drawing.Point(347, 131);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(200, 33);
            this.btnSaveInfo.TabIndex = 30;
            this.btnSaveInfo.Text = "Сохранить";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // reservationTableAdapter1
            // 
            this.reservationTableAdapter1.ClearBeforeFill = true;
            // 
            // ChangeReservationStatusFromAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 176);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelEditInfo);
            this.Controls.Add(this.btnSaveInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangeReservationStatusFromAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение статуса брони";
            this.panelEditInfo.ResumeLayout(false);
            this.panelEditInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelEditInfo;
        public System.Windows.Forms.ComboBox statusInput;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.Button btnSaveInfo;
        private GamuClubDBDataSetTableAdapters.ReservationTableAdapter reservationTableAdapter1;
    }
}