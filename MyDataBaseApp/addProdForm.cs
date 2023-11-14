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
            db = new Database("Host=pgdb.uni-dubna.ru;Username=student25;Password=Io_228_1337;Database=student25");
        }

        private void but_add_prod_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.OpenConnection())
                {
                    string select_request = "SELECT * FROM get_product_table(@nameProd)";
                    NpgsqlCommand select_npgSqlCommand = new NpgsqlCommand(select_request, db.Connection);
                    select_npgSqlCommand.Parameters.AddWithValue("@nameProd", tbNameProd.Text);

                    bool userExists = false;

                    using (NpgsqlDataReader select_npgSqlDataReader = select_npgSqlCommand.ExecuteReader())
                    {
                        userExists = select_npgSqlDataReader.HasRows;
                    }

                    if (!userExists)
                    {
                        if (tbNameProd.Text != "" && tbProteins.Text != "" && tbFats.Text != "" && tbUgly.Text != "")
                        {
                            string insert_request = "CALL insert_product(@name, @pfc);";
                            NpgsqlCommand insert_npgSqlCommand = new NpgsqlCommand(insert_request, db.Connection);
                            insert_npgSqlCommand.Parameters.AddWithValue("@name", tbNameProd.Text);
                            insert_npgSqlCommand.Parameters.AddWithValue("@pfc", tbProteins.Text + "/" + tbFats.Text + "/" + tbUgly.Text);

                            insert_npgSqlCommand.ExecuteScalar();
                            MessageBox.Show("Продукт добавлен");

                        }
                        else { MessageBox.Show("Заполните поля!"); }
                    }
                    else
                    {
                        MessageBox.Show("Продукт уже существует");
                    }
                }
                else
                {
                    MessageBox.Show("Нет соединения");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
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

