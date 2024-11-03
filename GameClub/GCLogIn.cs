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

            AuthentificationDataTable dataTable = authentificationTableAdapter1.GetDataByRole(login, password);

            if (dataTable.Rows.Count > 0)
            {
                string role = dataTable.Rows[0]["role"].ToString();

                if (role == "ADMIN")
                {
                    GCAdmin gcAdmin = new GCAdmin();
                    gcAdmin.Show();
                    //this.Hide();
                    //this.Show
                }
                else 
                {
                    GCUser gcUser = new GCUser();
                    gcUser.Show();
                    //this.Hide();
                    //this.Show();

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
