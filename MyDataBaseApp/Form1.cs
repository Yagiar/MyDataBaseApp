using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using Npgsql;

namespace MyDataBaseApp
{
    public partial class Form1 : Form
    {
        private Database db;

        public Form1()
        {
            InitializeComponent();
            db = new Database("Host=pgdb.uni-dubna.ru;Username=student25;Password=Io_228_1337;Database=student25");
        }

        private void auth_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.OpenConnection())
                {
                    string request = "SELECT * FROM users WHERE username = @username and hash_pwd = @pwd";
                    NpgsqlCommand npgSqlCommand = new NpgsqlCommand(request, db.Connection);
                    npgSqlCommand.Parameters.AddWithValue("@username", username.Text);
                    npgSqlCommand.Parameters.AddWithValue("@pwd", CalculateMD5Hash(password.Text));

                    using (NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader())
                    {
                        if (npgSqlDataReader.HasRows)
                        {
                            MessageBox.Show("Вход успешен");
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль");
                        }
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

        private void registration_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.OpenConnection())
                {
                    string select_request = "SELECT * FROM users WHERE username = @username";
                    NpgsqlCommand select_npgSqlCommand = new NpgsqlCommand(select_request, db.Connection);
                    select_npgSqlCommand.Parameters.AddWithValue("@username", username.Text);

                    bool userExists = false;

                    using (NpgsqlDataReader select_npgSqlDataReader = select_npgSqlCommand.ExecuteReader())
                    {
                        userExists = select_npgSqlDataReader.HasRows;
                    }

                    if (!userExists)
                    {
                        string insert_request = "INSERT INTO users (username, hash_pwd) VALUES (@username, @hash_pwd);";
                        NpgsqlCommand insert_npgSqlCommand = new NpgsqlCommand(insert_request, db.Connection);
                        insert_npgSqlCommand.Parameters.AddWithValue("@username", username.Text);
                        insert_npgSqlCommand.Parameters.AddWithValue("@hash_pwd", CalculateMD5Hash(password.Text));

                        int rowsAffected = insert_npgSqlCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Регистрация успешна, можете войти");
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка при регистрации");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с данным именем уже существует");
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

        public string CalculateMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2")); // Преобразование в шестнадцатеричную строку
                }

                return sb.ToString();
            }
        }
    }

}
