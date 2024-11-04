namespace GameClub
{
    partial class AddConsole
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
            this.storageInput = new System.Windows.Forms.TextBox();
            this.modelInput = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.resolutionInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.consoleTableAdapter1 = new GameClub.GamuClubDBDataSetTableAdapters.ConsoleTableAdapter();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resolutionInput);
            this.panel1.Controls.Add(this.storageInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.modelInput);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Location = new System.Drawing.Point(30, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 155);
            this.panel1.TabIndex = 36;
            // 
            // storageInput
            // 
            this.storageInput.Location = new System.Drawing.Point(281, 65);
            this.storageInput.Name = "storageInput";
            this.storageInput.Size = new System.Drawing.Size(200, 27);
            this.storageInput.TabIndex = 28;
            this.storageInput.TextChanged += new System.EventHandler(this.modelInput_TextChanged);
            // 
            // modelInput
            // 
            this.modelInput.Location = new System.Drawing.Point(281, 29);
            this.modelInput.Name = "modelInput";
            this.modelInput.Size = new System.Drawing.Size(200, 27);
            this.modelInput.TabIndex = 27;
            this.modelInput.TextChanged += new System.EventHandler(this.modelInput_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(48, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 20);
            this.label21.TabIndex = 29;
            this.label21.Text = "Модель:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(48, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 20);
            this.label20.TabIndex = 30;
            this.label20.Text = "Память:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(30, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 33);
            this.button1.TabIndex = 35;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveInfo.Location = new System.Drawing.Point(358, 216);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(200, 33);
            this.btnSaveInfo.TabIndex = 34;
            this.btnSaveInfo.Text = "Сохранить";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // resolutionInput
            // 
            this.resolutionInput.Location = new System.Drawing.Point(281, 103);
            this.resolutionInput.Name = "resolutionInput";
            this.resolutionInput.Size = new System.Drawing.Size(200, 27);
            this.resolutionInput.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Разрешение:";
            // 
            // consoleTableAdapter1
            // 
            this.consoleTableAdapter1.ClearBeforeFill = true;
            // 
            // AddConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaveInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddConsole";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox resolutionInput;
        public System.Windows.Forms.TextBox storageInput;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox modelInput;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnSaveInfo;
        private GamuClubDBDataSetTableAdapters.ConsoleTableAdapter consoleTableAdapter1;
    }
}