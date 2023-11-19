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
    public partial class addExerProgramm : Form
    {
        private Database db;
        public addExerProgramm()
        {
            InitializeComponent();
            // db = new Database("Host=pgdb.uni-dubna.ru;Username=student25;Password=Io_228_1337;Database=student25");
            db = new Database("Host=localhost;Username=postgres;Password=Io_228;Database=mydata");
        }

        private void butAddProgramm_Click(object sender, EventArgs e)
        {
            if(days_collection.SelectedItems.Count== 1 && listBoxExercises.SelectedItems.Count== 1 && tbCountPodhod.Text != "" && tbCountPovtor.Text !="")
            {
                string selectedExer = listBoxExercises.SelectedItem.ToString();
                string[] parts = selectedExer.Split(',');
                string nameExer = parts[0].Trim();
                string day = days_collection.SelectedItem.ToString();

                if(authForm.IsNumeric(tbCountPodhod.Text))
                {
                    if(authForm.IsNumeric(tbCountPovtor.Text))
                    {
                        db.InsertPlan(db.GetIdByName("exercise", nameExer),int.Parse(tbCountPodhod.Text),int.Parse(tbCountPovtor.Text),day);
                    }
                    else
                    {
                        MessageBox.Show("Укажите ЧИСЛО повторений");
                    }
                }
                else
                {
                    MessageBox.Show("Укажите ЧИСЛО подходов");
                }
            }
        }
        private void addExerProgramm_Load(object sender, EventArgs e)
        {
            listBoxExercises.DataSource = db.get_table("exercise").Items;
        }
        private void butReturn_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            main.Show();
            this.Close();
        }    
    }
}
