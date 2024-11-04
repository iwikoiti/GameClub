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
    public partial class GCAdmin : Form
    {
        public GCAdmin()
        {
            InitializeComponent();
        }

        private void GCAdmin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gamuClubDBDataSet.FoodMenu". При необходимости она может быть перемещена или удалена.
            this.foodMenuTableAdapter.Fill(this.gamuClubDBDataSet.FoodMenu);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gamuClubDBDataSet.Tariff". При необходимости она может быть перемещена или удалена.
            this.tariffTableAdapter.Fill(this.gamuClubDBDataSet.Tariff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gamuClubDBDataSet.Room". При необходимости она может быть перемещена или удалена.
            this.roomTableAdapter.Fill(this.gamuClubDBDataSet.Room);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gamuClubDBDataSet.PC". При необходимости она может быть перемещена или удалена.
            this.pCTableAdapter.Fill(this.gamuClubDBDataSet.PC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gamuClubDBDataSet.Console". При необходимости она может быть перемещена или удалена.
            this.consoleTableAdapter.Fill(this.gamuClubDBDataSet.Console);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gamuClubDBDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.gamuClubDBDataSet.User);

        }
    }
}
