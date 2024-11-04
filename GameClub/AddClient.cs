using System;
using System.CodeDom.Compiler;
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
    public partial class AddClient : Form
    {
        public AddClient(string valueTag)
        {
            InitializeComponent();
            this.Tag = valueTag;
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
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

            string newLoginOrEmail = emailInput.Text.ToString();

            Console.WriteLine(newSurname + " " + newName + " " + newFathername + " " + formattedBirthday + " " + newLoginOrEmail);
            
            if (this.Tag.ToString() == "add")
            {
                this.authentificationTableAdapter1.InsertQuery(newLoginOrEmail, newPassword, "USER");
                this.userTableAdapter1.InsertQuery(newSurname, newName, newFathername, formattedBirthday, newLoginOrEmail, newLoginOrEmail);
            }
            else
            {
                int userId = Convert.ToInt32(this.Tag);
                this.userTableAdapter1.UpdateQuery(newSurname, newName, newFathername, formattedBirthday, newLoginOrEmail, userId, userId);
            }
        }

        private void surnameInput_TextChanged(object sender, EventArgs e)
        {
          
            if (this.Tag.ToString() == "add")
            {
                loginInput.Text = emailInput.Text;
            }
            

            if (surnameInput.Text.Length == 0 || nameInput.Text.Length == 0 || emailInput.Text.Length == 0 || loginInput.Text.Length == 0 || passwordInput.Text.Length == 0)
            {
                btnSaveInfo.Enabled = false;
            }
            else
            {
                btnSaveInfo.Enabled = true;
            }
        }

        string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            string generatedNum = RandomString(3) + num.Next(1000, 9999);
            Console.WriteLine(generatedNum);
            passwordInput.Text = generatedNum;
        }
    }
}
