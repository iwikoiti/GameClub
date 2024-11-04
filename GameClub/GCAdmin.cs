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
    public partial class GCAdmin : Form
    {
        public GCAdmin()
        {
            InitializeComponent();
        }

        private void GCAdmin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gamuClubDBDataSet.FoodMenu". При необходимости она может быть перемещена или удалена.
            this.foodMenuTableAdapter.Fill(this.gamuClubDBDataSet.FoodMenu);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gamuClubDBDataSet.Tariff". При необходимости она может быть перемещена или удалена.
            this.tariffTableAdapter.Fill(this.gamuClubDBDataSet.Tariff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gamuClubDBDataSet.Room". При необходимости она может быть перемещена или удалена.
            this.roomTableAdapter.Fill(this.gamuClubDBDataSet.Room);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gamuClubDBDataSet.PC". При необходимости она может быть перемещена или удалена.
            this.pCTableAdapter.Fill(this.gamuClubDBDataSet.PC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gamuClubDBDataSet.Console". При необходимости она может быть перемещена или удалена.
            this.consoleTableAdapter.Fill(this.gamuClubDBDataSet.Console);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gamuClubDBDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.gamuClubDBDataSet.User);

        }

        void Updating(string n)
        {
            this.Validate();
            switch (n) {
                case "clients":
                    this.userBindingSource.EndEdit();
                    this.userTableAdapter.Update(this.gamuClubDBDataSet.User);
                    gamuClubDBDataSet.AcceptChanges();
                    this.userTableAdapter.Fill(this.gamuClubDBDataSet.User);
                    break;

                case "tariffs":
                    this.tariffBindingSource.EndEdit();
                    this.tariffTableAdapter.Update(this.gamuClubDBDataSet.Tariff);
                    gamuClubDBDataSet.AcceptChanges();
                    this.tariffTableAdapter.Fill(this.gamuClubDBDataSet.Tariff);
                    break;

                case "rooms":
                    this.roomBindingSource.EndEdit();
                    this.roomTableAdapter.Update(this.gamuClubDBDataSet.Room);
                    gamuClubDBDataSet.AcceptChanges();
                    this.roomTableAdapter.Fill(this.gamuClubDBDataSet.Room);
                    break;

                case "pcs":
                    this.pCBindingSource.EndEdit();
                    this.pCTableAdapter.Update(this.gamuClubDBDataSet.PC);
                    gamuClubDBDataSet.AcceptChanges();
                    this.pCTableAdapter.Fill(this.gamuClubDBDataSet.PC);
                    break;

                case "consoles":
                    this.consoleBindingSource.EndEdit();
                    this.consoleTableAdapter.Update(this.gamuClubDBDataSet.Console);
                    gamuClubDBDataSet.AcceptChanges();
                    this.consoleTableAdapter.Fill(this.gamuClubDBDataSet.Console);
                    break;

                case "menu":
                    this.foodMenuBindingSource.EndEdit();
                    this.foodMenuTableAdapter.Update(this.gamuClubDBDataSet.FoodMenu);
                    gamuClubDBDataSet.AcceptChanges();
                    this.foodMenuTableAdapter.Fill(this.gamuClubDBDataSet.FoodMenu);
                    break;

                default:
                    MessageBox.Show("Ошибка с обновлением таблицы");
                    break;
            }
        }

        // Добавление, редактирование, удаление КЛИЕНТА
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClient clientForm = new AddClient("add");
            clientForm.btnSaveInfo.Enabled = false;
            //clientForm.Tag = "add";
            DialogResult dr = clientForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Updating("clients");
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            string userId = clientDataGrid.CurrentRow.Cells[6].Value.ToString().Trim();
            AddClient clientForm = new AddClient(userId);

            clientForm.surnameInput.Text = clientDataGrid.CurrentRow.Cells[0].Value.ToString().Trim();
            clientForm.nameInput.Text = clientDataGrid.CurrentRow.Cells[1].Value.ToString().Trim();
            clientForm.fathernameInput.Text = clientDataGrid.CurrentRow.Cells[2].Value.ToString().Trim();
            if (clientDataGrid.CurrentRow.Cells[3].Value != null && clientDataGrid.CurrentRow.Cells[3].Value.ToString() != "")
            {
                clientForm.birthdayInput.Checked = true;
                clientForm.birthdayInput.Value = Convert.ToDateTime(clientDataGrid.CurrentRow.Cells[3].Value);
            }
            else
            {
                clientForm.birthdayInput.Checked = false;
            }
            clientForm.emailInput.Text = clientDataGrid.CurrentRow.Cells[4].Value.ToString().Trim();

            string logindb = clientDataGrid.CurrentRow.Cells[5].Value.ToString().Trim();
            clientForm.loginInput.Text = logindb;

            AuthentificationDataTable dataTableAuth = this.authentificationTableAdapter1.GetDataByLogin(logindb);
            if (dataTableAuth.Rows.Count > 0)
            {
                string passworddb = dataTableAuth.Rows[0]["password"].ToString();
                clientForm.passwordInput.Text = passworddb;
            }
            else
            {
                Console.WriteLine("Пароль пользователя с логином " + logindb + " не найден");
            }

            clientForm.passwordInput.ReadOnly = true;

            Console.WriteLine("userId = " + userId);

            //clientForm.Tag = userId;
            DialogResult dr = clientForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Updating("clients");
            }
        }

        private void btnDelClient_Click(object sender, EventArgs e)
        {
            int clientDel = Convert.ToInt32(clientDataGrid.CurrentRow.Cells[6].Value);
            string surname = clientDataGrid.CurrentRow.Cells[0].Value.ToString().Trim();
            string name = clientDataGrid.CurrentRow.Cells[1].Value.ToString().Trim();
            DialogResult result;
            if (clientDataGrid.CurrentRow.Cells[2].Value.ToString() != "" && clientDataGrid.CurrentRow.Cells[2].Value != null)
            {
                string fathername = clientDataGrid.CurrentRow.Cells[2].Value.ToString().Trim();
                result = MessageBox.Show("Вы уверены, что хотите удалить клиента " + surname + " " + name + " " + fathername + "?", "Предупреждение", MessageBoxButtons.YesNo);
            }
            else
            {
                result = MessageBox.Show("Вы уверены, что хотите удалить клиента " + surname + " " + name + "?", "Предупреждение", MessageBoxButtons.YesNo);
            }

            string login = clientDataGrid.CurrentRow.Cells[5].Value.ToString().Trim();
            if (result == DialogResult.Yes)
            {
                this.userTableAdapter.DeleteQuery(clientDel);
                this.authentificationTableAdapter1.DeleteQuery(login);
                Updating("clients");
            }
        }

        // Добавление, редактирование, удаление ЕДЫ ИЗ МЕНЮ
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            AddFoodMenu menuForm = new AddFoodMenu("add");
            menuForm.btnSaveInfo.Enabled = false;
            DialogResult dr = menuForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Updating("menu");
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string foodId = menuDataGrid.CurrentRow.Cells[2].Value.ToString();
            AddFoodMenu menuForm = new AddFoodMenu(foodId);
            menuForm.foodInput.Text = menuDataGrid.CurrentRow.Cells[0].Value.ToString().Trim();
            menuForm.priceInput.Text = menuDataGrid.CurrentRow.Cells[1].Value.ToString().Trim();

            DialogResult dr = menuForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Updating("menu");
            }
        }

        private void btnDelFood_Click(object sender, EventArgs e)
        {
            int foodDel = Convert.ToInt32(menuDataGrid.CurrentRow.Cells[2].Value);
            string food = menuDataGrid.CurrentRow.Cells[0].Value.ToString().Trim();
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить " + food + "?", "Предупреждение", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.foodMenuTableAdapter.DeleteQuery(foodDel);
                Updating("menu");
            }
        }

        // Добавление, редактирование, удаление ПК
        private void btnAddPC_Click(object sender, EventArgs e)
        {
            AddPC pcForm = new AddPC("add");
            pcForm.btnSaveInfo.Enabled = false;
            DialogResult dr = pcForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Updating("pcs");
            }
        }

        private void btnEditPC_Click(object sender, EventArgs e)
        {
            string pcId = pcDataGrid.CurrentRow.Cells[0].Value.ToString();
            AddPC pcForm = new AddPC(pcId);

            pcForm.chairInput.Text = pcDataGrid.CurrentRow.Cells[1].Value.ToString().Trim();
            pcForm.cpuInput.Text = pcDataGrid.CurrentRow.Cells[2].Value.ToString().Trim();
            pcForm.hardriveInput.Text = pcDataGrid.CurrentRow.Cells[3].Value.ToString().Trim();
            pcForm.ramInput.Text = pcDataGrid.CurrentRow.Cells[4].Value.ToString().Trim();
            pcForm.videocardInput.Text = pcDataGrid.CurrentRow.Cells[5].Value.ToString().Trim();
            pcForm.storageInput.Text = pcDataGrid.CurrentRow.Cells[6].Value.ToString().Trim();
            pcForm.monitorInput.Text = pcDataGrid.CurrentRow.Cells[7].Value.ToString().Trim();
            pcForm.keybordInput.Text = pcDataGrid.CurrentRow.Cells[8].Value.ToString().Trim();
            pcForm.mouseInput.Text = pcDataGrid.CurrentRow.Cells[9].Value.ToString().Trim();

            DialogResult dr = pcForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Updating("pcs");
            }
        }

        private void btnDelPC_Click(object sender, EventArgs e)
        {
            int pcDel = Convert.ToInt32(pcDataGrid.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить ПК № " + pcDel + "?", "Предупреждение", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.pCTableAdapter.DeleteQuery(pcDel);
                Updating("pcs");
            }
        }

        // Добавление, редактирование, удаление КОНСОЛИ
        private void btnAddConsole_Click(object sender, EventArgs e)
        {
            AddConsole consoleForm = new AddConsole("add");
            consoleForm.btnSaveInfo.Enabled = false;
            DialogResult dr = consoleForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Updating("consoles");
            }
        }

        private void btnEditConsole_Click(object sender, EventArgs e)
        {
            string consoleId = consoleDataGrid.CurrentRow.Cells[0].Value.ToString();
            AddConsole consoleForm = new AddConsole(consoleId);

            consoleForm.modelInput.Text = consoleDataGrid.CurrentRow.Cells[1].Value.ToString().Trim();
            consoleForm.storageInput.Text = consoleDataGrid.CurrentRow.Cells[2].Value.ToString().Trim();
            consoleForm.resolutionInput.Text = consoleDataGrid.CurrentRow.Cells[3].Value.ToString().Trim();

            DialogResult dr = consoleForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Updating("consoles");
            }
        }

        private void btnDelConsole_Click(object sender, EventArgs e)
        {
            int consoleDel = Convert.ToInt32(consoleDataGrid.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить Консоль № " + consoleDel + "?", "Предупреждение", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.consoleTableAdapter.DeleteQuery(consoleDel);
                Updating("consoles");
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoom roomForm = new AddRoom("add");
            roomForm.btnSaveInfo.Enabled = false;
            DialogResult dr = roomForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Updating("rooms");
            }
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            AddRoom roomForm = new AddRoom("add");
            DialogResult dr = roomForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Updating("rooms");
            }
        }

        private void btnDelRoom_Click(object sender, EventArgs e)
        {

        }

        // Добавление, редактирование, удаление ИГРОВОГО ЗАЛА



    }
}
