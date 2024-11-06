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
    public partial class GCUser : Form
    {
        public GCUser(string userId, string surnamedb, string namedb, string fathernamedb, string birthdaydb, string emaildb, string logindb, string passworddb)
        {
            InitializeComponent();
            this.Tag = userId;
            if (fathernamedb == "" || fathernamedb == null)
            {
                fathernamedb = "-";
            }
            else
            {
                fathernameInput.Text = fathernamedb;
            }

            if (birthdaydb == "" || birthdaydb == null)
            {
                birthdaydb = "-";
            }
            else
            {
                birthdayInput.Checked = true;
                birthdayInput.Text = birthdaydb;
                birthdaydb = birthdaydb.Split(' ')[0];
            }
            
            surnameLabel.Text = surnamedb;
            surnameInput.Text = surnamedb;

            nameLabel.Text = namedb;
            nameInput.Text = namedb;

            fathernameLabel.Text = fathernamedb;

            birthdayLabel.Text = birthdaydb;

            emailLabel.Text = emaildb;
            emailInput.Text = emaildb;

            loginLabel.Text = logindb;
            loginInput.Text = logindb;

            passwordLabel.Text = passworddb;
            passwordInput.Text = passworddb;
        }

        private void GCUser_Load(object sender, EventArgs e)
        {
            /* Бронирование */
            //Вывод в таблицу бронирования с названием и стоимостью тарифа
            int userId = Convert.ToInt32(this.Tag);
            var reservations = reservationTableAdapter1.GetDataBy(userId);
            reservationDataGrid.DataSource = reservations;

            // Настройка свойств колонок
            foreach (DataGridViewColumn column in reservationDataGrid.Columns)
            {
                // Изменение AutoSizeMode для всех колонок, чтобы они заполнили доступное пространство
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // Скрыть колонки userID и tariffID
                if (column.Name == "userID" || column.Name == "tariffID")
                {
                    column.Visible = false;
                }

                // Переименование заголовков
                if (column.Name == "reservationID")
                {
                    column.HeaderText = "Номер бронирования";
                }
                else if (column.Name == "startDateTime")
                {
                    column.HeaderText = "Время начала";
                }
                else if (column.Name == "endDateTime")
                {
                    column.HeaderText = "Время окончания";
                }
                else if (column.Name == "statusReservation")
                {
                    column.HeaderText = "Статус бронирования";
                }
                else if (column.Name == "nameTariff")
                {
                    column.HeaderText = "Название тарифа";
                }
                else if (column.Name == "price")
                {
                    column.HeaderText = "Стоимость тарифа";
                }
            }
        }

        /* Личный кабинет */

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            panelEditInfo.Visible = true;
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            string newLogin = loginInput.Text.ToString();
            string newPassword = passwordInput.Text.ToString();

            string newSurname = surnameInput.Text.ToString();
            string newName = nameInput.Text.ToString();
            string newFathername = null;
            if (fathernameInput.Text.ToString() != "" && fathernameInput.Text.ToString() != null)
            {
                newFathername = fathernameInput.Text.ToString();
            }
            DateTime newBirthday;
            string formattedBirthday = null;
            if (birthdayInput.Checked == true)
            {
                if (DateTime.TryParse(birthdayInput.Text, out newBirthday))
                {
                    formattedBirthday = newBirthday.ToString("yyyy-MM-dd");
                }
            }

            string newEmail = emailInput.Text.ToString();
            int userID = Convert.ToInt32(this.Tag);

            Console.WriteLine(newSurname + " " + newName + " " + newFathername + " " + formattedBirthday + " " + newEmail + " " + userID + " " + userID);

            this.authentificationTableAdapter1.UpdateQuery(newLogin, newPassword, loginLabel.Text.ToString());
            this.userTableAdapter1.UpdateQuery(newSurname, newName, newFathername, formattedBirthday, newEmail, userID, userID);

            panelEditInfo.Visible = false;

        }

        private void surnameInput_TextChanged(object sender, EventArgs e)
        {
            if (surnameInput.Text.Length == 0 || nameInput.Text.Length == 0 || emailInput.Text.Length == 0 || loginInput.Text.Length == 0 || passwordInput.Text.Length == 0)
            {
                btnSaveInfo.Enabled = false;
            }
            else
            {
                btnSaveInfo.Enabled = true;
            }
        }

        void Updating(string n)
        {
            this.Validate();
            switch (n)
            {
                case "reservations":
                    /* this.reservationBindingSource.EndEdit();
                     this.reservationTableAdapter.Update(this.gamuClubDBDataSet.Reservation);
                     gamuClubDBDataSet.AcceptChanges();
                     this.reservationTableAdapter.Fill(this.gamuClubDBDataSet.Reservation);*/

                   /* int userId = Convert.ToInt32(this.Tag);
                    var reservations = reservationTableAdapter1.GetDataBy(userId);
                    reservationDataGrid.DataSource = reservations;*/
                    break;

                /*case "menu":
                    this.foodMenuBindingSource.EndEdit();
                    this.foodMenuTableAdapter.Update(this.gamuClubDBDataSet.FoodMenu);
                    gamuClubDBDataSet.AcceptChanges();
                    this.foodMenuTableAdapter.Fill(this.gamuClubDBDataSet.FoodMenu);
                    break;*/

                default:
                    MessageBox.Show("Ошибка с обновлением таблицы");
                    break;
            }
        }
        /* Бронирование */
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string userId = this.Tag.ToString();
            AddReservation resForm = new AddReservation(userId);
            resForm.btnSaveInfo.Enabled = false;

            resForm.tariffInput.Items.Add(GCAdmin.notValueinComboBox);
            resForm.tariffInput.SelectedItem = GCAdmin.notValueinComboBox;

            resForm.roomInput.Items.Add(GCAdmin.notValueinComboBox);
            resForm.roomInput.SelectedItem = GCAdmin.notValueinComboBox;

            resForm.timestartInput.Items.Add(GCAdmin.notValueinComboBox);
            resForm.timestartInput.SelectedItem = GCAdmin.notValueinComboBox;

            RoomDataTable dataTableRoom = roomTableAdapter1.GetData();

            if (dataTableRoom.Rows.Count > 0)
            {
                for (int i = 0; i < dataTableRoom.Rows.Count; i++)
                {
                    string nameRoomdb = dataTableRoom.Rows[i]["nameRoom"].ToString();
                    resForm.roomInput.Items.Add(nameRoomdb);
                }
            }

            TariffDataTable dataTableTariff = tariffTableAdapter1.GetData();

            // HashSet для исключения повторений
            HashSet<string> uniqueTariffs = new HashSet<string>();

            if (dataTableTariff.Rows.Count > 0)
            {
                for (int i = 0; i < dataTableTariff.Rows.Count; i++)
                {
                    string nameTariffdb = dataTableTariff.Rows[i]["nameTariff"].ToString();
                    uniqueTariffs.Add(nameTariffdb);
                }
            }
            string[] uniqueTariffsArray = uniqueTariffs.ToArray();

            resForm.tariffInput.Items.Clear();
            resForm.tariffInput.Items.AddRange(uniqueTariffsArray);

            DialogResult dr = resForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Updating("reservations");
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {

        }

        private void btnDelClient_Click(object sender, EventArgs e)
        {

        }
    }



}
