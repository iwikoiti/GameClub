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
    public partial class GCLogIn : Form
    {
        public GCLogIn()
        {
            InitializeComponent();
        }

        private void GCLogIn_Load(object sender, EventArgs e)
        {
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            string login = (loginInput.Text).ToString();
            string password = (passwordInput.Text).ToString();

            var role = (authentificationTableAdapter1.GetDataBy(login, password)).ToString();

            if (role == "ADMIN")
            {
                GCAdmin gcAdmin = new GCAdmin();
                gcAdmin.Show();
                //this.Hide();
                //this.Show();
            }
            else
            {
                GCUser gcUser = new GCUser();
                gcUser.Show();
                //this.Hide();
                //this.Show();

            }
        }

    }
}
