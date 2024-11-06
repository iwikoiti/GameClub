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

            /* Сеансы и заказы еды */
            var sessions = sessionTableAdapter1.GetDataBySession(userId);
            sessionDataGrid.DataSource = sessions;

            foreach (DataGridViewColumn column in sessionDataGrid.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                if (column.Name == "reservationID")
                {
                    column.Visible = false;
                }

                // Переименование заголовков
                if (column.Name == "sessionID")
                {
                    column.HeaderText = "Номер сеанса";
                }
                else if (column.Name == "totalPrice")
                {
                    column.HeaderText = "Итоговая стоимость";
                }
            }


            var orders = foodOrderTableAdapter1.GetDataByFoodName(userId);
            orderDataGrid.DataSource = orders;

            // Настройка свойств колонок
            foreach (DataGridViewColumn column in orderDataGrid.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                if (column.Name == "foodID")
                {
                    column.Visible = false;
                }

                // Переименование заголовков
                if (column.Name == "orderID")
                {
                    column.HeaderText = "Номер заказа";
                }
                else if (column.Name == "sessionID")
                {
                    column.HeaderText = "Номер сеанса";
                }
                else if (column.Name == "foodName")
                {
                    column.HeaderText = "Название блюда";
                }
                else if (column.Name == "quantity")
                {
                    column.HeaderText = "Количество блюд";
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
            int userId = Convert.ToInt32(this.Tag);
            switch (n)
            {
                case "reservations":
                    var reservations = reservationTableAdapter1.GetDataBy(userId);
                    reservationDataGrid.DataSource = reservations;
                    break;

                case "sessions":
                    var sessions = sessionTableAdapter1.GetDataBySession(userId);
                    sessionDataGrid.DataSource = sessions;
                    break;

                case "orders":
                    var orders = foodOrderTableAdapter1.GetDataByFoodName(userId);
                    orderDataGrid.DataSource = orders;
                    break;

                default:
                    MessageBox.Show("Ошибка с обновлением таблицы");
                    break;
            }
        }

        /* Бронирование */
        private void btnAddResrvation_Click(object sender, EventArgs e)
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

        private void btnCancelResrvation_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = reservationDataGrid.CurrentRow;

            int reservationID = Convert.ToInt32(currentRow.Cells["reservationID"].Value);
            string statusReservation = currentRow.Cells["statusReservation"].Value.ToString();

            if (statusReservation != "Отменено")
            {
                this.reservationTableAdapter1.UpdateReservationStatus("Отменено", reservationID, reservationID);
                Updating("reservations");
            }
            else
            {
                MessageBox.Show("Бронь уже отменена.", "Предупреждение");
            }
        }

        /* Сеансы и заказы еды */
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string sessionId = orderDataGrid.CurrentRow.Cells[1].Value.ToString().Trim();
                Console.WriteLine(sessionId);
                AddOrder orderForm = new AddOrder(sessionId);
                orderForm.btnSaveInfo.Enabled = false;

                orderForm.foodInput.Items.Add(GCAdmin.notValueinComboBox);
                orderForm.foodInput.SelectedItem = GCAdmin.notValueinComboBox;

                FoodMenuDataTable dataTableFood = foodMenuTableAdapter1.GetData();

                if (dataTableFood.Rows.Count > 0)
                {
                    for (int i = 0; i < dataTableFood.Rows.Count; i++)
                    {
                        string fooddb = dataTableFood.Rows[i]["foodName"].ToString();
                        orderForm.foodInput.Items.Add(fooddb);
                    }
                }

                DialogResult dr = orderForm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    // Вычисление итоговой стоимости (тариф + заказы)
                    SessionDataTable sessionDataTable = sessionTableAdapter1.GetDataBySessionID(Convert.ToInt32(sessionId));

                    if (sessionDataTable.Rows.Count > 0)
                    {
                        int totalPricedb = Convert.ToInt32(sessionDataTable.Rows[0]["totalPrice"]);

                        FoodOrderDataTable foodOrders = foodOrderTableAdapter1.GetDataBySessionID(Convert.ToInt32(sessionId));

                        foreach (DataRow foodOrderRow in foodOrders.Rows)
                        {
                            // Получаем foodID и quantity для этой записи
                            int foodID = Convert.ToInt32(foodOrderRow["foodID"]);
                            int quantity = Convert.ToInt32(foodOrderRow["quantity"]);

                            // Получаем цену для foodID из таблицы FoodMenu
                            FoodMenuDataTable foodMenu = foodMenuTableAdapter1.GetDataByFoodID(foodID);

                            if (foodMenu.Rows.Count > 0)
                            {
                                // Получаем цену (foodPrice)
                                int foodPrice = Convert.ToInt32(foodMenu.Rows[0]["foodPrice"]);

                                // Вычисляем стоимость для этого блюда
                                int itemTotalPrice = foodPrice * quantity;

                                // Прибавляем к общей стоимости
                                totalPricedb += itemTotalPrice;
                            }
                        }
                        this.sessionTableAdapter1.UpdateQueryByPrice(totalPricedb, Convert.ToInt32(sessionId), Convert.ToInt32(sessionId));

                        Updating("orders");
                        Updating("sessions");
                    }
                }
        }
            catch
            {
                MessageBox.Show("У вас нет текущих сеансов.", "Предупреждение");
            }
}

    }



}
