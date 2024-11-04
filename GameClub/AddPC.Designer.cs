namespace GameClub
{
    partial class AddPC
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
            this.label7 = new System.Windows.Forms.Label();
            this.hardriveInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ramInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.videocardInput = new System.Windows.Forms.TextBox();
            this.cpuInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mouseInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keybordInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monitorInput = new System.Windows.Forms.TextBox();
            this.chairInput = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.pcTableAdapter1 = new GameClub.GamuClubDBDataSetTableAdapters.PCTableAdapter();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.storageInput);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.hardriveInput);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ramInput);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.videocardInput);
            this.panel1.Controls.Add(this.cpuInput);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.mouseInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.keybordInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.monitorInput);
            this.panel1.Controls.Add(this.chairInput);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Location = new System.Drawing.Point(25, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 413);
            this.panel1.TabIndex = 36;
            // 
            // storageInput
            // 
            this.storageInput.Location = new System.Drawing.Point(281, 355);
            this.storageInput.Name = "storageInput";
            this.storageInput.Size = new System.Drawing.Size(312, 27);
            this.storageInput.TabIndex = 43;
            this.storageInput.TextChanged += new System.EventHandler(this.chairInput_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Память:";
            // 
            // hardriveInput
            // 
            this.hardriveInput.Location = new System.Drawing.Point(281, 318);
            this.hardriveInput.Name = "hardriveInput";
            this.hardriveInput.Size = new System.Drawing.Size(312, 27);
            this.hardriveInput.TabIndex = 41;
            this.hardriveInput.TextChanged += new System.EventHandler(this.chairInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Жесткий диск:";
            // 
            // ramInput
            // 
            this.ramInput.Location = new System.Drawing.Point(281, 280);
            this.ramInput.Name = "ramInput";
            this.ramInput.Size = new System.Drawing.Size(312, 27);
            this.ramInput.TabIndex = 39;
            this.ramInput.TextChanged += new System.EventHandler(this.chairInput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Оперативная память:";
            // 
            // videocardInput
            // 
            this.videocardInput.Location = new System.Drawing.Point(281, 242);
            this.videocardInput.Name = "videocardInput";
            this.videocardInput.Size = new System.Drawing.Size(312, 27);
            this.videocardInput.TabIndex = 36;
            this.videocardInput.TextChanged += new System.EventHandler(this.chairInput_TextChanged);
            // 
            // cpuInput
            // 
            this.cpuInput.Location = new System.Drawing.Point(281, 206);
            this.cpuInput.Name = "cpuInput";
            this.cpuInput.Size = new System.Drawing.Size(312, 27);
            this.cpuInput.TabIndex = 35;
            this.cpuInput.TextChanged += new System.EventHandler(this.chairInput_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Процессор:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Видеокарта:";
            // 
            // mouseInput
            // 
            this.mouseInput.Location = new System.Drawing.Point(281, 154);
            this.mouseInput.Name = "mouseInput";
            this.mouseInput.Size = new System.Drawing.Size(312, 27);
            this.mouseInput.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Мышь:";
            // 
            // keybordInput
            // 
            this.keybordInput.Location = new System.Drawing.Point(281, 116);
            this.keybordInput.Name = "keybordInput";
            this.keybordInput.Size = new System.Drawing.Size(312, 27);
            this.keybordInput.TabIndex = 31;
            this.keybordInput.TextChanged += new System.EventHandler(this.chairInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Клавиатура:";
            // 
            // monitorInput
            // 
            this.monitorInput.Location = new System.Drawing.Point(281, 78);
            this.monitorInput.Name = "monitorInput";
            this.monitorInput.Size = new System.Drawing.Size(312, 27);
            this.monitorInput.TabIndex = 28;
            this.monitorInput.TextChanged += new System.EventHandler(this.chairInput_TextChanged);
            // 
            // chairInput
            // 
            this.chairInput.Location = new System.Drawing.Point(281, 42);
            this.chairInput.Name = "chairInput";
            this.chairInput.Size = new System.Drawing.Size(312, 27);
            this.chairInput.TabIndex = 27;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(48, 43);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 20);
            this.label21.TabIndex = 29;
            this.label21.Text = "Кресло:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(48, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 20);
            this.label20.TabIndex = 30;
            this.label20.Text = "Монитор:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(74, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 33);
            this.button1.TabIndex = 35;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveInfo.Location = new System.Drawing.Point(402, 442);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(200, 33);
            this.btnSaveInfo.TabIndex = 34;
            this.btnSaveInfo.Text = "Сохранить";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // pcTableAdapter1
            // 
            this.pcTableAdapter1.ClearBeforeFill = true;
            // 
            // AddPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaveInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox hardriveInput;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox ramInput;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox videocardInput;
        public System.Windows.Forms.TextBox cpuInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox mouseInput;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox keybordInput;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox monitorInput;
        public System.Windows.Forms.TextBox chairInput;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnSaveInfo;
        public System.Windows.Forms.TextBox storageInput;
        private System.Windows.Forms.Label label7;
        private GamuClubDBDataSetTableAdapters.PCTableAdapter pcTableAdapter1;
    }
}