using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameClub
{
    public partial class AddFoodMenu : Form
    {
        public AddFoodMenu(string valueTag)
        {
            InitializeComponent();
            this.Tag = valueTag;
        }

        private void foodInput_TextChanged(object sender, EventArgs e)
        {
            if (foodInput.Text.Length == 0 || priceInput.Text.Length == 0)
            {
                btnSaveInfo.Enabled = false;
            }
            else
            {
                btnSaveInfo.Enabled = true;
            }
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            string newFood = foodInput.Text.ToString().Trim();
            int newPrice = Convert.ToInt32(priceInput.Text);

            if (this.Tag.ToString() == "add")
            {
                this.foodMenuTableAdapter1.InsertQuery(newFood, newPrice);
            }
            else
            {
                int foodId = Convert.ToInt32(this.Tag);
                this.foodMenuTableAdapter1.UpdateQuery(newFood, newPrice, foodId, foodId);
            }
        }

        private void priceInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
