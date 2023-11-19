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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyDataBaseApp
{
    public partial class addProdForm : Form
    {
        private Database db;
        public addProdForm()
        {
            InitializeComponent();
            // db = new Database("Host=pgdb.uni-dubna.ru;Username=student25;Password=Io_228_1337;Database=student25");
            db = new Database("Host=localhost;Username=postgres;Password=Io_228;Database=mydata");
        }

        private void but_add_prod_Click(object sender, EventArgs e)
        {
            if (tbNameProd.Text != "" && tbProteins.Text != "" && tbFats.Text != "" && tbUgly.Text != "")
            {
                if(authForm.IsNumeric(tbProteins.Text))
                {
                    if (authForm.IsNumeric(tbFats.Text))
                    {
                        if(authForm.IsNumeric(tbUgly.Text))
                        {
                            string pfc = tbProteins.Text + "/" + tbFats.Text + "/" + tbUgly.Text;
                            db.AddProductIntoTable(tbNameProd.Text, pfc);
                        }
                        else 
                        { 
                            MessageBox.Show("Введите ЧИСЛО углеводов");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите ЧИСЛО жиров");
                    }
                }
                else
                {
                    MessageBox.Show("Введите ЧИСЛО белков");
                }     
            }
            else { MessageBox.Show("Заполните поля!"); }
        }

        private void but_return_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            main.Show();
            this.Close();
        }
        
    }
}

