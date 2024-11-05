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
            Console.WriteLine(this.Tag);
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
            int? newPC = null;
            
            if (pcInput.Text.ToString().Trim() != GCAdmin.notValueinComboBox)
            {
                newPC = Convert.ToInt32(pcInput.Text);
            }

            int? newConsole = null;

            if (consoleInput.Text.ToString().Trim() != GCAdmin.notValueinComboBox)
            {
                newConsole = Convert.ToInt32(consoleInput.Text);
            }

            string newInternet = internetInput.Text.ToString();

            if (this.Tag.ToString() == "add")
            {
                try
                {
                    this.roomTableAdapter1.InsertQuery(newRoom, newPC, newConsole, newInternet);
                } catch {
                    MessageBox.Show("Зал с таким названием уже существует.", "Предупреждение");
                }
            }
            else
            {
                string roomId = this.Tag.ToString();
                this.roomTableAdapter1.UpdateQuery(newRoom, newPC, newConsole, newInternet, roomId);
            }
        }
    }
}
