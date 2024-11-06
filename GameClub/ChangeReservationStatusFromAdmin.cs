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
    public partial class ChangeReservationStatusFromAdmin : Form
    {
        public ChangeReservationStatusFromAdmin(string valueTag)
        {
            InitializeComponent();
            this.Tag = valueTag;
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            string newStatus = statusInput.Text.ToString();
            int resID = Convert.ToInt32(this.Tag);

            this.reservationTableAdapter1.UpdateReservationStatus(newStatus, resID, resID);
        }
    }
}
