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
    public partial class planForm : Form
    {
        private Database db;
        DataGridView gridAte;
        DataGridView gridWorkout;
        string day;
        public planForm(string dayOfWeek)
        {
            InitializeComponent();
            day = dayOfWeek;
            // db = new Database("Host=pgdb.uni-dubna.ru;Username=student25;Password=Io_228_1337;Database=student25");
            db = new Database("Host=localhost;Username=postgres;Password=Io_228;Database=mydata");
        }
        private void getGrids()
        {
            panelExercise.Controls.Clear();
            panelProducts.Controls.Clear();
            if (db.getGrid("ate", day )!= null)
            {
                if (db.getGrid("workout", day) != null)
                {
                    gridAte = db.getGrid("ate", day);
                    gridWorkout = db.getGrid("workout", day);

                    DataGridViewButtonColumn deleteButtonColumnAte = new DataGridViewButtonColumn();
                    deleteButtonColumnAte.HeaderText = "Удалить";
                    deleteButtonColumnAte.Text = "Удалить";
                    deleteButtonColumnAte.UseColumnTextForButtonValue = true;
                    gridAte.Columns.Insert(0, deleteButtonColumnAte);

                    DataGridViewButtonColumn deleteButtonColumnWorkout = new DataGridViewButtonColumn();
                    deleteButtonColumnWorkout.HeaderText = "Удалить";
                    deleteButtonColumnWorkout.Text = "Удалить";
                    deleteButtonColumnWorkout.UseColumnTextForButtonValue = true;

                    DataGridViewButtonColumn editButtonColumnWorkout = new DataGridViewButtonColumn();
                    editButtonColumnWorkout.HeaderText = "Изменить";
                    editButtonColumnWorkout.Text = "Изменить";
                    editButtonColumnWorkout.UseColumnTextForButtonValue = true;

                    gridWorkout.Columns.Insert(0, deleteButtonColumnWorkout);
                    gridWorkout.Columns.Insert(1, editButtonColumnWorkout);

                    gridAte.CellContentClick += GridAte_CellContentClick;
                    gridWorkout.CellContentClick += GridWorkout_CellContentClick;

                    gridWorkout.Dock = DockStyle.Fill;
                    gridAte.Dock = DockStyle.Fill;

                    panelExercise.Controls.Add(gridWorkout);
                    panelProducts.Controls.Add(gridAte);

                    labelBZU.Text = "Общее количество бжу: " + db.getBZU(day);
                }
                else
                {
                    MessageBox.Show("Нет данных в плане тренировок на выбранный день, добавьте");
                    ComeBack();
                }
            }
            else
            {
                MessageBox.Show("Нет данных в рационе питания на выбранный день, добавьте");
                ComeBack();
            }
            
        }
        private void planForm_Load(object sender, EventArgs e)
        {
             getGrids();
        }

        private void GridAte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && sender!=null)
            {
                var cellValue = gridAte.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (cellValue != null)
                {
                    string name = gridAte.Rows[e.RowIndex].Cells["product_name"].Value.ToString();
                    string command = cellValue.ToString();
                    if (command=="Удалить")
                    {
                        db.DeleteRecordByName("ate",name);
                        getGrids();
                        this.Refresh();
                    }
                    
                }
            }
        }

        private void GridWorkout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && sender != null)
            {
                var cellValue = gridWorkout.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (cellValue != null)
                {
                    string name = gridWorkout.Rows[e.RowIndex].Cells["exercise_name"].Value.ToString();
                    string command = cellValue.ToString();
                    if (command == "Удалить")
                    {
                        db.DeleteRecordByName("workout", name);
                        getGrids();
                        this.Refresh();
                    }
                    else if(command=="Изменить")
                    {
                        MessageBox.Show(name);
                    }

                }
            }
        }


        private void ComeBack()
        {
            mainForm main = new mainForm();
            main.Show();
            this.Close();
        }

        private void butReturn_Click(object sender, EventArgs e)
        {
            ComeBack();
        }
    }
}
