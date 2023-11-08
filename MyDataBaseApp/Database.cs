using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

internal class Database
{
    private readonly string connectionString;
    private NpgsqlConnection connection;
    public NpgsqlConnection Connection
    {
        get { return connection; }
    }
    public Database(string str_connection)
    {
        connectionString = str_connection;
    }

    public bool OpenConnection()
    {
        if (connection == null)
        {
            connection = new NpgsqlConnection(connectionString);
        }

        if (connection.State != ConnectionState.Open)
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (NpgsqlException ex)
            {
                // Обработка исключения при неудачном открытии соединения
                MessageBox.Show("Ошибка при открытии соединения: " + ex.Message);
                return false;
            }
        }

        return true;
    }

    public void CloseConnection()
    {
        if (connection != null && connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }

    
}

