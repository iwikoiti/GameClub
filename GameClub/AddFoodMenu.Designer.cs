namespace GameClub
{
    partial class AddFoodMenu
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
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.foodInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.foodMenuTableAdapter1 = new GameClub.GamuClubDBDataSetTableAdapters.FoodMenuTableAdapter();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(48, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 20);
            this.label20.TabIndex = 30;
            this.label20.Text = "Цена:";
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
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(281, 78);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(200, 27);
            this.priceInput.TabIndex = 28;
            this.priceInput.TextChanged += new System.EventHandler(this.foodInput_TextChanged);
            this.priceInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceInput_KeyPress);
            // 
            // foodInput
            // 
            this.foodInput.Location = new System.Drawing.Point(281, 42);
            this.foodInput.Name = "foodInput";
            this.foodInput.Size = new System.Drawing.Size(200, 27);
            this.foodInput.TabIndex = 27;
            this.foodInput.TextChanged += new System.EventHandler(this.foodInput_TextChanged);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(12, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 33);
            this.button1.TabIndex = 32;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveInfo.Location = new System.Drawing.Point(340, 208);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(200, 33);
            this.btnSaveInfo.TabIndex = 31;
            this.btnSaveInfo.Text = "Сохранить";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.priceInput);
            this.panel1.Controls.Add(this.foodInput);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 143);
            this.panel1.TabIndex = 33;
            // 
            // foodMenuTableAdapter1
            // 
            this.foodMenuTableAdapter1.ClearBeforeFill = true;
            // 
            // AddFoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 253);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaveInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddFoodMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование меню";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox priceInput;
        public System.Windows.Forms.TextBox foodInput;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnSaveInfo;
        private System.Windows.Forms.Panel panel1;
        private GamuClubDBDataSetTableAdapters.FoodMenuTableAdapter foodMenuTableAdapter1;
    }
}