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
    public partial class mainForm : Form
    {
        private Database db;
        public mainForm()
        {
            InitializeComponent();
            // db = new Database("Host=pgdb.uni-dubna.ru;Username=student25;Password=Io_228_1337;Database=student25");
            db = new Database("Host=localhost;Username=postgres;Password=Io_228;Database=mydata");
        }
        private void choose_day_Click(object sender, EventArgs e)
        {
            if (days_collection.SelectedItems.Count == 1 )
            {
                if (db.getGrid("ate",days_collection.SelectedItem.ToString()) != null)
                {
                    if (db.getGrid("workout", days_collection.SelectedItem.ToString()) != null)
                    {
                        planForm planForm = new planForm(days_collection.SelectedItem.ToString());
                        planForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Нет данных в плане тренировок на выбранный день, добавьте");
                    }
                }
                else
                {
                    MessageBox.Show("Нет данных в рационе питания на выбранный день, добавьте");
                }
            }
            else
            {
                MessageBox.Show("Выберете день");
            }
        }
        ~mainForm() { Application.Exit(); }
        // неяный курсор сделать общее количество продуктов(то есть выводить их, взяв неявным курсором select count(*) into...)
        private void but_plan_ate_Click(object sender, EventArgs e)
        {
            addAteProgramm addAteProg = new addAteProgramm();
            addAteProg.Show();
            this.Close();
        }
        private void but_add_exersice_Click(object sender, EventArgs e)
        {
            addExerForm addExerForm = new addExerForm();
            addExerForm.Show();
            this.Close();
        }
        private void but_add_product_Click(object sender, EventArgs e)
        {
            addProdForm addProdForm = new addProdForm();
            addProdForm.Show();
            this.Close();
        }
        private void but_plan_workout_Click(object sender, EventArgs e)
        {
            addExerProgramm addExerProgramm = new addExerProgramm();
            addExerProgramm.Show();
            this.Close();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
