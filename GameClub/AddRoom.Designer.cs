namespace GameClub
{
    partial class AddRoom
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
            this.consoleInput = new System.Windows.Forms.ComboBox();
            this.pcInput = new System.Windows.Forms.ComboBox();
            this.internetInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roomInput = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.gamuClubDBDataSet = new GameClub.GamuClubDBDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.roomTableAdapter1 = new GameClub.GamuClubDBDataSetTableAdapters.RoomTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamuClubDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.consoleInput);
            this.panel1.Controls.Add(this.pcInput);
            this.panel1.Controls.Add(this.internetInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.roomInput);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Location = new System.Drawing.Point(36, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 233);
            this.panel1.TabIndex = 39;
            // 
            // consoleInput
            // 
            this.consoleInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.consoleInput.FormattingEnabled = true;
            this.consoleInput.Location = new System.Drawing.Point(281, 119);
            this.consoleInput.Name = "consoleInput";
            this.consoleInput.Size = new System.Drawing.Size(200, 28);
            this.consoleInput.TabIndex = 41;
            // 
            // pcInput
            // 
            this.pcInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pcInput.FormattingEnabled = true;
            this.pcInput.Location = new System.Drawing.Point(281, 80);
            this.pcInput.Name = "pcInput";
            this.pcInput.Size = new System.Drawing.Size(200, 28);
            this.pcInput.TabIndex = 40;
            // 
            // internetInput
            // 
            this.internetInput.Location = new System.Drawing.Point(281, 156);
            this.internetInput.Name = "internetInput";
            this.internetInput.Size = new System.Drawing.Size(200, 27);
            this.internetInput.TabIndex = 33;
            this.internetInput.TextChanged += new System.EventHandler(this.roomInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Скорость интернета:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Консоль №:";
            // 
            // roomInput
            // 
            this.roomInput.Location = new System.Drawing.Point(281, 42);
            this.roomInput.Name = "roomInput";
            this.roomInput.Size = new System.Drawing.Size(200, 27);
            this.roomInput.TabIndex = 27;
            this.roomInput.TextChanged += new System.EventHandler(this.roomInput_TextChanged);
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
            this.label20.Size = new System.Drawing.Size(59, 20);
            this.label20.TabIndex = 30;
            this.label20.Text = "ПК №:";
            // 
            // gamuClubDBDataSet
            // 
            this.gamuClubDBDataSet.DataSetName = "GamuClubDBDataSet";
            this.gamuClubDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(36, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 33);
            this.button1.TabIndex = 38;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveInfo.Location = new System.Drawing.Point(364, 317);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(200, 33);
            this.btnSaveInfo.TabIndex = 37;
            this.btnSaveInfo.Text = "Сохранить";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // roomTableAdapter1
            // 
            this.roomTableAdapter1.ClearBeforeFill = true;
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 362);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaveInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игровой зал";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamuClubDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox roomInput;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnSaveInfo;
        public System.Windows.Forms.TextBox internetInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private GamuClubDBDataSet gamuClubDBDataSet;
        private GamuClubDBDataSetTableAdapters.RoomTableAdapter roomTableAdapter1;
        public System.Windows.Forms.ComboBox consoleInput;
        public System.Windows.Forms.ComboBox pcInput;
    }
}