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
    }

    /* Бронирование */


}
