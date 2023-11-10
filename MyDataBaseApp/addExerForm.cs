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
            db = new Database("Host=pgdb.uni-dubna.ru;Username=student25;Password=Io_228_1337;Database=student25");
        }

        private void but_add_exer_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.OpenConnection())
                {
                    string select_request = "SELECT * FROM exersice WHERE name = @nameExer";
                    NpgsqlCommand select_npgSqlCommand = new NpgsqlCommand(select_request, db.Connection);
                    select_npgSqlCommand.Parameters.AddWithValue("@nameExer", tbNameExer.Text);

                    bool userExists = false;

                    using (NpgsqlDataReader select_npgSqlDataReader = select_npgSqlCommand.ExecuteReader())
                    {
                        userExists = select_npgSqlDataReader.HasRows;
                    }

                    if (!userExists)
                    {

                        string insert_request = "INSERT INTO exersice (name, mustle_group) VALUES (@nameExer, @mustle_group);";
                        NpgsqlCommand insert_npgSqlCommand = new NpgsqlCommand(insert_request, db.Connection);
                        insert_npgSqlCommand.Parameters.AddWithValue("@nameExer", tbNameExer.Text);
                        insert_npgSqlCommand.Parameters.AddWithValue("@mustle_group", tbNameMusGroup.Text);

                        int rowsAffected = insert_npgSqlCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Упражнение добавлено");
                        }
                        else
                        {
                            MessageBox.Show("Ошибка добавления");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Упражнение уже существует");
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
