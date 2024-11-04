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
    public partial class AddRoom : Form
    {
        public AddRoom(string valueTag)
        {
            InitializeComponent();
            this.Tag = valueTag;
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gamuClubDBDataSet.Console". При необходимости она может быть перемещена или удалена.
            this.consoleTableAdapter.Fill(this.gamuClubDBDataSet.Console);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gamuClubDBDataSet.PC". При необходимости она может быть перемещена или удалена.
            this.pCTableAdapter.Fill(this.gamuClubDBDataSet.PC);

        }

        private void roomInput_TextChanged(object sender, EventArgs e)
        {
            if (roomInput.Text.Length == 0 || internetInput.Text.Length == 0)
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
            string newRoom = roomInput.Text.ToString();
            int newPC = Convert.ToInt32(pcInput.Text);
            int newConsole = Convert.ToInt32(consoleInput.Text);
            string newInternet = internetInput.Text.ToString();

            if (this.Tag.ToString() == "add")
            {
                this.roomTableAdapter1.InsertQuery(newRoom, newPC, newConsole, newInternet);
            }
            else
            {
                string roomId = this.Tag.ToString();
                this.roomTableAdapter1.UpdateQuery(newRoom, newPC, newConsole, newInternet, roomId);
            }
        }
    }
}
