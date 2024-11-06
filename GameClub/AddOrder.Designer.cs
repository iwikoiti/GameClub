namespace GameClub
{
    partial class AddOrder
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
            this.foodInput = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.foodOrderTableAdapter1 = new GameClub.GamuClubDBDataSetTableAdapters.FoodOrderTableAdapter();
            this.foodMenuTableAdapter1 = new GameClub.GamuClubDBDataSetTableAdapters.FoodMenuTableAdapter();
            this.quantityInput = new System.Windows.Forms.NumericUpDown();
            this.sessionTableAdapter1 = new GameClub.GamuClubDBDataSetTableAdapters.SessionTableAdapter();
            this.panelEditInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(15, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 33);
            this.button1.TabIndex = 32;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelEditInfo
            // 
            this.panelEditInfo.Controls.Add(this.quantityInput);
            this.panelEditInfo.Controls.Add(this.priceInput);
            this.panelEditInfo.Controls.Add(this.foodInput);
            this.panelEditInfo.Controls.Add(this.label19);
            this.panelEditInfo.Controls.Add(this.label20);
            this.panelEditInfo.Controls.Add(this.label21);
            this.panelEditInfo.Location = new System.Drawing.Point(15, 22);
            this.panelEditInfo.Name = "panelEditInfo";
            this.panelEditInfo.Size = new System.Drawing.Size(522, 162);
            this.panelEditInfo.TabIndex = 31;
            // 
            // foodInput
            // 
            this.foodInput.FormattingEnabled = true;
            this.foodInput.Location = new System.Drawing.Point(276, 22);
            this.foodInput.Name = "foodInput";
            this.foodInput.Size = new System.Drawing.Size(200, 28);
            this.foodInput.TabIndex = 30;
            this.foodInput.SelectedIndexChanged += new System.EventHandler(this.foodInput_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(43, 103);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 20);
            this.label19.TabIndex = 27;
            this.label19.Text = "Цена:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(43, 65);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(114, 20);
            this.label20.TabIndex = 26;
            this.label20.Text = "Количество:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(43, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 20);
            this.label21.TabIndex = 25;
            this.label21.Text = "Блюдо:";
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveInfo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveInfo.Location = new System.Drawing.Point(337, 208);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(200, 33);
            this.btnSaveInfo.TabIndex = 30;
            this.btnSaveInfo.Text = "Сохранить";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(276, 96);
            this.priceInput.Name = "priceInput";
            this.priceInput.ReadOnly = true;
            this.priceInput.Size = new System.Drawing.Size(200, 27);
            this.priceInput.TabIndex = 32;
            // 
            // foodOrderTableAdapter1
            // 
            this.foodOrderTableAdapter1.ClearBeforeFill = true;
            // 
            // foodMenuTableAdapter1
            // 
            this.foodMenuTableAdapter1.ClearBeforeFill = true;
            // 
            // quantityInput
            // 
            this.quantityInput.Location = new System.Drawing.Point(276, 58);
            this.quantityInput.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.quantityInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(200, 27);
            this.quantityInput.TabIndex = 34;
            this.quantityInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityInput.ValueChanged += new System.EventHandler(this.foodInput_SelectedIndexChanged);
            // 
            // sessionTableAdapter1
            // 
            this.sessionTableAdapter1.ClearBeforeFill = true;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 263);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelEditInfo);
            this.Controls.Add(this.btnSaveInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сделать заказ";
            this.panelEditInfo.ResumeLayout(false);
            this.panelEditInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelEditInfo;
        public System.Windows.Forms.ComboBox foodInput;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.Button btnSaveInfo;
        private GamuClubDBDataSetTableAdapters.FoodOrderTableAdapter foodOrderTableAdapter1;
        private GamuClubDBDataSetTableAdapters.FoodMenuTableAdapter foodMenuTableAdapter1;
        public System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.NumericUpDown quantityInput;
        private GamuClubDBDataSetTableAdapters.SessionTableAdapter sessionTableAdapter1;
    }
}