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
    public partial class addExerForm : Form
    {
        private Database db;
        public addExerForm()
        {
            InitializeComponent();
            // db = new Database("Host=pgdb.uni-dubna.ru;Username=student25;Password=Io_228_1337;Database=student25");
            db = new Database("Host=localhost;Username=postgres;Password=Io_228;Database=mydata");
        }

        private void but_add_exer_Click(object sender, EventArgs e)
        {
            if(tbNameExer.Text!="" && tbNameMusGroup.Text!="")
            {
                db.AddExerciseIntoTable(tbNameExer.Text, tbNameMusGroup.Text);
            }
            else
            { 
                MessageBox.Show("Заполните все поля");
            }
        }

        private void but_return_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            main.Show();
            this.Close();
        }

    }
}
