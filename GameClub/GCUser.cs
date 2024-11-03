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
    public partial class GCUser : Form
    {
        public GCUser(string surnamedb, string namedb, string fathernamedb, string birthdaydb, string emaildb, string logindb, string passworddb)
        {
            InitializeComponent();
            if (fathernamedb == "" || fathernamedb == null)
            {
                fathernamedb = "-";
                emaildb = "-";
            }
            surnameLabel.Text = surnamedb;
            nameLabel.Text = namedb;
            fathernameLabel.Text = fathernamedb;
            birthdayLabel.Text = birthdaydb;
            emailLabel.Text = emaildb;
            loginLabel.Text = logindb;
            passwordLabel.Text = passworddb;
        }

        private void GCUser_Load(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //GCLogIn.Show();
            //this.Close();
        }
    }
}
