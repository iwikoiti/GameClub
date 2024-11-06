using GameClub.GamuClubDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GameClub.GamuClubDBDataSet;

namespace GameClub
{
    public partial class AddOrder : Form
    {
        public AddOrder(string valueTag)
        {
            InitializeComponent();
            this.Tag = valueTag;
        }

        private void foodInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFood = foodInput.SelectedItem.ToString().Trim();
            FoodMenuDataTable dataTableFood = foodMenuTableAdapter1.GetDataByFoodName(selectedFood);
            int selectedQ = Convert.ToInt32(quantityInput.Value);

            if (dataTableFood.Rows.Count > 0)
            {
                // Извлекаем цену из таблицы
                int foodPrice = Convert.ToInt32(dataTableFood.Rows[0]["foodPrice"]);
                int newPrice = foodPrice * selectedQ;

                // Устанавливаем цену в TextBox
                priceInput.Text = newPrice.ToString();
            }

            if (quantityInput.Text.Length == 0 || priceInput.Text.Length == 0 || foodInput.Text.ToString() == GCAdmin.notValueinComboBox)
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
            int newQuantity = Convert.ToInt32(quantityInput.Text);
            string newFood = foodInput.Text.ToString().Trim();
            FoodMenuDataTable dataTableFood = foodMenuTableAdapter1.GetDataByFoodName(newFood);

            if (dataTableFood.Rows.Count > 0)
            {
                int sessionId = Convert.ToInt32(this.Tag);
                int foodId = Convert.ToInt32(dataTableFood.Rows[0]["foodID"]);
                Console.WriteLine("mr = " + sessionId.ToString() + " " +  foodId + " " + newQuantity);
                this.foodOrderTableAdapter1.Insert(sessionId, foodId, newQuantity);

                //this.sessionTableAdapter1.Update()
            }

        }

        private void quantityInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
