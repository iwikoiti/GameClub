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
    public partial class AddConsole : Form
    {
        public AddConsole(string valueTag)
        {
            InitializeComponent();
            this.Tag = valueTag;
        }

        private void modelInput_TextChanged(object sender, EventArgs e)
        {
            if (modelInput.Text.Length == 0 || storageInput.Text.Length == 0)
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
            string newModel = modelInput.Text.ToString();
            string newStorage = storageInput.Text.ToString();
            string newResolution = resolutionInput.Text.ToString();

            if (this.Tag.ToString() == "add")
            {
                this.consoleTableAdapter1.InsertQuery(newModel, newStorage, newResolution);
            }
            else
            {
                int consoleId = Convert.ToInt32(this.Tag);
                this.consoleTableAdapter1.UpdateQuery(newModel, newStorage, newResolution, consoleId, consoleId);
            }
        }
    }
}
