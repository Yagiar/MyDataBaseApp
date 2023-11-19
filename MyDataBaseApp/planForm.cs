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
        string day;
        public planForm(string dayOfWeek)
        {
            InitializeComponent();
            day = dayOfWeek;
            db = new Database("Host=pgdb.uni-dubna.ru;Username=student25;Password=Io_228_1337;Database=student25");
        }

        private void planForm_Load(object sender, EventArgs e)
        {
            DataGridView grid = db.getGrid(day);

            if (grid != null)
            {
                panelProducts.Controls.Add(grid);
            }
            labelBZU.Text = "Общее количество бжу: "+db.getBZU(day);
        }

        private void butReturn_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            main.Show();
            this.Close();
        }
    }
}
