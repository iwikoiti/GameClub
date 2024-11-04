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
    public partial class AddPC : Form
    {
        public AddPC(string valueTag)
        {
            InitializeComponent();
            this.Tag = valueTag;
        }

        private void chairInput_TextChanged(object sender, EventArgs e)
        {
            if (cpuInput.Text.Length == 0 || hardriveInput.Text.Length == 0 || ramInput.Text.Length == 0 || videocardInput.Text.Length == 0 || storageInput.Text.Length == 0 || monitorInput.Text.Length == 0)
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
            string newChair = chairInput.Text.ToString();
            string newCpu = cpuInput.Text.ToString();
            string newHardDrive = hardriveInput.Text.ToString();
            string newRam = ramInput.Text.ToString();
            string newvideocard = videocardInput.Text.ToString();
            string newStorage = storageInput.Text.ToString();
            string newMonitor = monitorInput.Text.ToString();
            string newKeyboard = keybordInput.Text.ToString();
            string newMouse = mouseInput.Text.ToString();

            if (this.Tag.ToString() == "add")
            {
                this.pcTableAdapter1.InsertQuery(newChair, newCpu, newHardDrive, newRam, newvideocard, newStorage, newMonitor, newKeyboard, newMouse);
            }
            else
            {
                int pcId = Convert.ToInt32(this.Tag);
                this.pcTableAdapter1.UpdateQuery(newChair, newCpu, newHardDrive, newRam, newvideocard, newStorage, newMonitor, newKeyboard, newMouse, pcId, pcId);
            }
        }
    }
}
