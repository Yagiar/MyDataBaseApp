using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDataBaseApp
{
    public partial class addAteProgramm : Form
    {
        private Database db;
        public addAteProgramm()
        {
            InitializeComponent();
            db = new Database("Host=pgdb.uni-dubna.ru;Username=student25;Password=Io_228_1337;Database=student25");

        }

        private void butAddProgramm_Click(object sender, EventArgs e)
        {
            if(days_collection.SelectedItems.Count == 1 && listBoxProducts.SelectedItems.Count == 1)
            {
                string selectedProd = listBoxProducts.SelectedItem.ToString();
                string[] parts = selectedProd.Split(',');
                string nameProd = parts[0].Trim();
                string day = days_collection.SelectedItem.ToString();

                db.InsertPlan(db.GetIdByName("product", nameProd), day);
            }
            else
            {
                MessageBox.Show("Выберете все поля");
            }
        }
        private void addAteProg_Load(object sender, EventArgs e)
        {
            listBoxProducts.DataSource = db.get_table("product").Items;
        }
        private void butReturn_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            main.Show();
            this.Close();
        }

    }
}
