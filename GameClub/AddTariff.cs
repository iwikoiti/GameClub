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
    public partial class AddTariff : Form
    {
        public AddTariff(string valueTag)
        {
            InitializeComponent();
            this.Tag = valueTag;
        }

        private void tariffInput_TextChanged(object sender, EventArgs e)
        {
            if (tariffInput.Text.Length == 0 || hoursInput.Text.Length == 0 || roomInput.Text.ToString() == GCAdmin.notValueinComboBox || priceInput.Text.Length == 0)
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
            string newTariff = tariffInput.Text.ToString();
            int newHours = Convert.ToInt32(hoursInput.Text);
            string newRoom = roomInput.Text.ToString();
            int newPrice = Convert.ToInt32(priceInput.Text);

            if (this.Tag.ToString() == "add")
            {
                this.tariffTableAdapter1.InsertQuery(newTariff, newHours, newRoom, newPrice);
            }
            else
            {
                int tariffId = Convert.ToInt32(this.Tag);
                this.tariffTableAdapter1.UpdateQuery(newTariff, newHours, newRoom, newPrice, tariffId, tariffId);
            }
        }

        private void hoursInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
