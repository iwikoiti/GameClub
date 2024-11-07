namespace GameClub
{
    partial class AddTariff
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.hoursInput = new System.Windows.Forms.TextBox();
            this.roomInput = new System.Windows.Forms.ComboBox();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tariffInput = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.tariffTableAdapter1 = new GameClub.GamuClubDBDataSetTableAdapters.TariffTableAdapter();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hoursInput);
            this.panel1.Controls.Add(this.roomInput);
            this.panel1.Controls.Add(this.priceInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tariffInput);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Location = new System.Drawing.Point(36, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 233);
            this.panel1.TabIndex = 42;
            // 
            // hoursInput
            // 
            this.hoursInput.Location = new System.Drawing.Point(281, 80);
            this.hoursInput.Name = "hoursInput";
            this.hoursInput.Size = new System.Drawing.Size(200, 27);
            this.hoursInput.TabIndex = 42;
            this.hoursInput.TextChanged += new System.EventHandler(this.tariffInput_TextChanged);
            this.hoursInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hoursInput_KeyPress);
            // 
            // roomInput
            // 
            this.roomInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomInput.FormattingEnabled = true;
            this.roomInput.Location = new System.Drawing.Point(281, 119);
            this.roomInput.Name = "roomInput";
            this.roomInput.Size = new System.Drawing.Size(200, 28);
            this.roomInput.TabIndex = 41;
            this.roomInput.SelectedIndexChanged += new System.EventHandler(this.tariffInput_TextChanged);
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(281, 156);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(200, 27);
            this.priceInput.TabIndex = 33;
            this.priceInput.TextChanged += new System.EventHandler(this.tariffInput_TextChanged);
            this.priceInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hoursInput_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Стоимость:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Зал:";
            // 
            // tariffInput
            // 
            this.tariffInput.Location = new System.Drawing.Point(281, 42);
            this.tariffInput.Name = "tariffInput";
            this.tariffInput.Size = new System.Drawing.Size(200, 27);
            this.tariffInput.TabIndex = 27;
            this.tariffInput.TextChanged += new System.EventHandler(this.tariffInput_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(48, 43);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 20);
            this.label21.TabIndex = 29;
            this.label21.Text = "Название:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(48, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(217, 20);
            this.label20.TabIndex = 30;
            this.label20.Text = "Продолжительность (ч):";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(36, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 33);
            this.button1.TabIndex = 41;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveInfo.Location = new System.Drawing.Point(364, 297);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(200, 33);
            this.btnSaveInfo.TabIndex = 40;
            this.btnSaveInfo.Text = "Сохранить";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // tariffTableAdapter1
            // 
            this.tariffTableAdapter1.ClearBeforeFill = true;
            // 
            // AddTariff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 362);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaveInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddTariff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тариф";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox hoursInput;
        public System.Windows.Forms.ComboBox roomInput;
        public System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tariffInput;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnSaveInfo;
        private GamuClubDBDataSetTableAdapters.TariffTableAdapter tariffTableAdapter1;
    }
}