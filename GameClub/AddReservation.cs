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
    public partial class AddReservation : Form
    {
        public AddReservation(string valueTag)
        {
            InitializeComponent();
            this.Tag = valueTag;
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(this.Tag);
            string newTariff  = tariffInput.Text.ToString();
            string newRoom = roomInput.Text.ToString();
            string newStatus = "Не оплачено";

            DateTime newDate = Convert.ToDateTime(resdateInput.Text.ToString());
            DateTime newStartTime = Convert.ToDateTime(timestartInput.Text.ToString());

            TariffDataTable dataTableTariff = tariffTableAdapter1.GetDataByTariffAndRoom(newTariff, newRoom);

            if (dataTableTariff.Rows.Count > 0)
            {
                int tariffId = Convert.ToInt32(dataTableTariff.Rows[0]["tariffID"]);
                int tariffHours = Convert.ToInt32(dataTableTariff.Rows[0]["hoursCount"]);

                DateTime newEndTime = newStartTime.AddHours(tariffHours);

                DateTime finalStartDateTime = newDate.Date.Add(newStartTime.TimeOfDay); // Дата + Время начала
                DateTime finalEndDateTime = newDate.Date.Add(newEndTime.TimeOfDay); // Дата + Время конца

                //Console.WriteLine("meme = " + userId + " " + tariffId + " " + newRoom  + " " + finalStartDateTime + " " + finalEndDateTime + " " + newStatus);
                this.reservationTableAdapter1.InsertQuery(userId, tariffId, finalStartDateTime, finalEndDateTime, newStatus);
            }
            else
            {
                MessageBox.Show("Такого тарифа нет. Повторите попытку.", "Предупреждение");
            }

        }

        private void tariffInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tariffInput.Text.ToString() == GCAdmin.notValueinComboBox || timestartInput.Text.ToString() == GCAdmin.notValueinComboBox || roomInput.Text.ToString() == GCAdmin.notValueinComboBox)
            {
                btnSaveInfo.Enabled = false;
            }
            else
            {
                btnSaveInfo.Enabled = true;
            }
        }
    }
}
