using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDataBaseApp;
using Npgsql;
using NpgsqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
    public int GetIdByName(string table,string name)
    {
        NpgsqlCommand npgSqlCommand = null;
        switch (table)
        {
            case "users":
                {
                    string request = "SELECT id FROM users WHERE username = @username";
                    npgSqlCommand = new NpgsqlCommand(request, Connection);
                    npgSqlCommand.Parameters.AddWithValue("@username", name);
                    break;
                }
            case "product":
                {
                    string request = "SELECT id FROM product WHERE name = @name";
                    npgSqlCommand = new NpgsqlCommand(request, Connection);
                    npgSqlCommand.Parameters.AddWithValue("@name", name);
                    break;
                }
            case "exercise":
                {
                    string request = "SELECT id FROM exercise WHERE name = @name";
                    npgSqlCommand = new NpgsqlCommand(request, Connection);
                    npgSqlCommand.Parameters.AddWithValue("@name", name);
                    break;
                }
        }
        try
        {
            if (OpenConnection())
            {
                using (NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader())
                {
                    if (npgSqlDataReader.HasRows)
                    {
                        npgSqlDataReader.Read();
                        return npgSqlDataReader.GetInt32(0); // Возвращаем ID пользователя
                    }
                    else
                    {
                        MessageBox.Show("Не найдено");
                        return -1; // Или другое значение, указывающее на отсутствие пользователя
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет соединения");
                return -1;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка: " + ex.Message);
            return -1;
        }
        finally
        {
            CloseConnection();
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
    public bool LoginUser(string username, string hashpwd)
    {
        try
        {
            if (OpenConnection())
            {
                string request = "SELECT * FROM users WHERE username = @username and hash_pwd = @pwd";
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand(request, Connection);
                npgSqlCommand.Parameters.AddWithValue("@username", username);
                npgSqlCommand.Parameters.AddWithValue("@pwd", hashpwd);

                using (NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader())
                {
                    if (npgSqlDataReader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет соединения");
                return false;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка: " + ex.Message);
            return false;
        }
        finally
        {
            CloseConnection();
        }
    }
    public void RegistrationUser(string username, string hashpwd)
    {
        try
        {
            if (OpenConnection())
            {
                string select_request = "SELECT * FROM users WHERE username = @username";
                NpgsqlCommand select_npgSqlCommand = new NpgsqlCommand(select_request, Connection);
                select_npgSqlCommand.Parameters.AddWithValue("@username", username);

                bool userExists = false;

                using (NpgsqlDataReader select_npgSqlDataReader = select_npgSqlCommand.ExecuteReader())
                {
                    userExists = select_npgSqlDataReader.HasRows;
                }

                if (!userExists)
                {
                    string insert_request = "INSERT INTO users (username, hash_pwd) VALUES (@username, @hash_pwd);";
                    NpgsqlCommand insert_npgSqlCommand = new NpgsqlCommand(insert_request, Connection);
                    insert_npgSqlCommand.Parameters.AddWithValue("@username", username);
                    insert_npgSqlCommand.Parameters.AddWithValue("@hash_pwd", hashpwd);

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
            CloseConnection();
        }
    }
    public void AddExerciseIntoTable(string NameExer,string NameMuscleGroup)
    {
        try
        {
            if (OpenConnection())
            {
                string select_request = "SELECT * FROM get_exercise_table(@nameExer);";
                NpgsqlCommand select_npgSqlCommand = new NpgsqlCommand(select_request, Connection);
                select_npgSqlCommand.Parameters.AddWithValue("@nameExer", NameExer);

                bool userExists = false;

                using (NpgsqlDataReader select_npgSqlDataReader = select_npgSqlCommand.ExecuteReader())
                {
                    userExists = select_npgSqlDataReader.HasRows;
                }

                if (!userExists)
                {

                        string insert_request = "CALL insert_exercise(@nameExer, @mustle_group);";
                        NpgsqlCommand insert_npgSqlCommand = new NpgsqlCommand(insert_request, Connection);
                        insert_npgSqlCommand.Parameters.AddWithValue("@nameExer", NameExer);
                        insert_npgSqlCommand.Parameters.AddWithValue("@mustle_group", NameMuscleGroup);

                        int rowsAffected = insert_npgSqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Упражение добавлено.");

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
            CloseConnection();
        }
    }
    public void AddProductIntoTable(string NameProduct,string pfc)
    {

        try
        {
            if (OpenConnection())
            {
                string select_request = "SELECT * FROM get_product_table(@nameProd)";
                NpgsqlCommand select_npgSqlCommand = new NpgsqlCommand(select_request, Connection);
                select_npgSqlCommand.Parameters.AddWithValue("@nameProd", NameProduct);

                bool userExists = false;

                using (NpgsqlDataReader select_npgSqlDataReader = select_npgSqlCommand.ExecuteReader())
                {
                    userExists = select_npgSqlDataReader.HasRows;
                }

                if (!userExists)
                {
                    string insert_request = "CALL insert_product(@name, @pfc);";
                    NpgsqlCommand insert_npgSqlCommand = new NpgsqlCommand(insert_request, Connection);
                    insert_npgSqlCommand.Parameters.AddWithValue("@name", NameProduct);
                    insert_npgSqlCommand.Parameters.AddWithValue("@pfc", pfc);
                    
                    insert_npgSqlCommand.ExecuteScalar();
                    MessageBox.Show("Продукт добавлен");

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
            CloseConnection();
        }
    }
    public void InsertPlan(int product_id,string day)
    {
        try
        {
            if (OpenConnection())
            {
                string insert_request = "INSERT INTO Daily_products (user_id, product_id, day) VALUES (@user_id, @product_id, @day);";
                NpgsqlCommand insert_npgSqlCommand = new NpgsqlCommand(insert_request, Connection);
                insert_npgSqlCommand.Parameters.AddWithValue("@user_id", authForm.user_id);
                insert_npgSqlCommand.Parameters.AddWithValue("@product_id", product_id);
                insert_npgSqlCommand.Parameters.AddWithValue("@day", day);
                
                insert_npgSqlCommand.ExecuteScalar();
                MessageBox.Show("Добавлено");
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
            CloseConnection();
        }
    }
    public void InsertPlan(int exercise_id,int count_repetitions,int count_approaches, string day)
    {
        try
        {
            if (OpenConnection())
            {
                string insert_request = "INSERT INTO Daily_workout (user_id, exercise_id, count_repetitions, count_approaches, day) VALUES (@user_id, @exercise_id, @count_repetitions, @count_approaches, @day);";
                NpgsqlCommand insert_npgSqlCommand = new NpgsqlCommand(insert_request, Connection);
                insert_npgSqlCommand.Parameters.AddWithValue("@user_id", authForm.user_id);
                insert_npgSqlCommand.Parameters.AddWithValue("@exercise_id", exercise_id);
                insert_npgSqlCommand.Parameters.AddWithValue("@count_repetitions", count_repetitions);
                insert_npgSqlCommand.Parameters.AddWithValue("@count_approaches", count_approaches);
                insert_npgSqlCommand.Parameters.AddWithValue("@day", day);

                insert_npgSqlCommand.ExecuteScalar();
                MessageBox.Show("Добавлено");
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
            CloseConnection();
        }
    }
    public DataGridView getGrid(string option , string dayOfWeek)
    {
        string request="";
        DataTable dataTable = new DataTable();
        DataGridView dataGridView = new DataGridView();
        switch (option)
        {
            case "workout":
                {
                    request = "SELECT * FROM public.get_user_workouts(@dayOfWeek, @userId)";
                    break;
                }
            case "ate":
                {
                    request = "SELECT * FROM get_daily_nutrition(@dayOfWeek, @userId)";
                    break;
                }
        }

        try
        {
            if (OpenConnection())
            {
                
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand(request, Connection);
                npgSqlCommand.Parameters.AddWithValue("@dayOfWeek", NpgsqlDbType.Text,dayOfWeek);
                npgSqlCommand.Parameters.AddWithValue("@userId", authForm.user_id);

                using (var reader = npgSqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dataTable.Load(reader);

                        dataGridView.DataSource = dataTable;
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView.ReadOnly = true;
                        dataGridView.AutoGenerateColumns = true;
                    }
                    else
                    {
                        return null;
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
            CloseConnection();
        }
        return dataGridView;
    }
    public string getBZU(string dayOfWeek)
    {
        try
        {
            if (OpenConnection())
            {
                string request = "SELECT * FROM get_total_bpu(@dayOfWeek, @userId)";
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand(request, Connection);
                npgSqlCommand.Parameters.AddWithValue("@dayOfWeek", NpgsqlDbType.Text, dayOfWeek);
                npgSqlCommand.Parameters.AddWithValue("@userId", authForm.user_id);


                var result = npgSqlCommand.ExecuteScalar();
                return result != null ? result.ToString() : "0/0/0";
            }
            else
            {
                MessageBox.Show("Нет соединения");
                return "0/0/0";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка: " + ex.Message);
            return "0/0/0";
        }
        finally
        {
            CloseConnection();
        }
    }
    public void DeleteRecordByName(string option, string name)
    {
        string request = "";
        int uniq_id=0;

        switch (option)
        {
            case "workout":
                request = "DELETE FROM Daily_workout WHERE exercise_id = @uniq_id AND user_id = @userId";
                uniq_id = GetIdByName("exercise", name);
                break;

            case "ate":
                request = "DELETE FROM Daily_products WHERE product_id = @uniq_id  AND user_id = @userId";
                uniq_id = GetIdByName("product", name);
                break;
        }

        try
        {
            if (OpenConnection())
            {
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand(request, Connection);
                npgSqlCommand.Parameters.AddWithValue("@uniq_id", NpgsqlDbType.Integer, uniq_id);
                npgSqlCommand.Parameters.AddWithValue("@userId", NpgsqlDbType.Integer, authForm.user_id);

                npgSqlCommand.ExecuteScalar();
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
            CloseConnection();
        }
    }
  

}
