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
    public partial class GCLogIn : Form
    {
        public GCLogIn()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            string login = loginInput.Text.ToString().Trim();
            string password = passwordInput.Text.ToString().Trim();

            Console.WriteLine(login + " " + password);

            AuthentificationDataTable dataTableAuth = authentificationTableAdapter1.GetDataByRole(login, password);

            if (dataTableAuth.Rows.Count > 0)
            {
                string logindb = dataTableAuth.Rows[0]["login"].ToString().Trim();
                string passworddb = dataTableAuth.Rows[0]["password"].ToString().Trim();


                string roledb = dataTableAuth.Rows[0]["role"].ToString();
                
                if (roledb == "ADMIN")
                {
                    GCAdmin gcAdmin = new GCAdmin();
                    this.Hide();
                    DialogResult dr = gcAdmin.ShowDialog();
                    if (dr == DialogResult.Cancel)
                    {
                        this.Show();
                    }
                }
                else 
                {
                    UserDataTable dataTableUser = userTableAdapter1.GetDataByUser(login);
                    int userId = Convert.ToInt32(dataTableUser.Rows[0]["userID"]);
                    string surnamedb = dataTableUser.Rows[0]["surname"].ToString().Trim();
                    string namedb = dataTableUser.Rows[0]["name"].ToString().Trim();
                    string fathernamedb = dataTableUser.Rows[0]["fathername"].ToString().Trim();
                    string birthdaydb = dataTableUser.Rows[0]["birthday"].ToString().Trim();
                    string emaildb = dataTableUser.Rows[0]["email"].ToString().Trim();

                    Console.WriteLine(surnamedb + " " + namedb + " " + fathernamedb + " " + birthdaydb + " " + emaildb + " " + logindb + " " + passworddb);

                    GCUser gcUser = new GCUser(userId.ToString(), surnamedb, namedb, fathernamedb, birthdaydb, emaildb, logindb, passworddb);
                    //gcUser.Tag = userId;
                    this.Hide();
                    DialogResult dr = gcUser.ShowDialog();
                    if (dr == DialogResult.Cancel)
                    {
                        this.Show();
                    }
                }

            }
            else
            {
                errorLabel.Text = "Ошибка ввода данных. Повторите попытку.";
                errorLabel.Visible = true;
            }
        }

    }
}
