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
    public ListBox get_table(string table)
    {
        string select_request="";
        ListBox list = new ListBox();
        switch (table)
        {
            case "exercise":
                {
                    select_request = "select * from get_exercises();";
                    break;
                }
            case "product":
                {
                    select_request = "select * from get_products();";
                    break;
                }
        }
        try
        {
            if (OpenConnection())
            {
                
                NpgsqlCommand select_npgSqlCommand = new NpgsqlCommand(select_request, Connection);

                using (NpgsqlDataReader select_npgSqlDataReader = select_npgSqlCommand.ExecuteReader())
                {
                    while (select_npgSqlDataReader.Read())
                    {
                    List<string> rowData = new List<string>();

                    for (int i = 0; i < select_npgSqlDataReader.FieldCount; i++)
                    {
                        rowData.Add(select_npgSqlDataReader[i].ToString());
                    }

                    list.Items.Add(string.Join(",", rowData));
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет соединения");
                return null;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка: " + ex.Message);
            return null;
        }
        finally
        {
            if (Connection.State == ConnectionState.Open)
            {
                CloseConnection();
            }
        }
        return list;
    } 
}