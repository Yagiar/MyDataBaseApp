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
    public partial class authForm : Form
    {
        private Database db;
        public static int user_id = 0;
        public static bool IsNumeric(string text)
        {
            return double.TryParse(text, out _);
        }
        public authForm()
        {
            InitializeComponent();
            // db = new Database("Host=pgdb.uni-dubna.ru;Username=student25;Password=Io_228_1337;Database=student25");
            db = new Database("Host=localhost;Username=postgres;Password=Io_228;Database=mydata");           // db = new Database("Host=localhost;Username=postgres;Password=Io_228;Database=mydata");
        }

        private void auth_Click(object sender, EventArgs e)
        {
            if (CheckTb())
            {
                if (db.LoginUser(username.Text, CalculateMD5Hash(password.Text)))
                {
                    user_id = db.GetIdByName("users",username.Text);
                    mainForm main = new mainForm();
                    main.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void registration_Click(object sender, EventArgs e)
        {
            if (CheckTb())
            {
                db.RegistrationUser(username.Text, CalculateMD5Hash(password.Text));
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
        private bool CheckTb()
        {
            if (username.Text != "" && password.Text != "") { return true; }
            else { return false; }
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
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }

}
