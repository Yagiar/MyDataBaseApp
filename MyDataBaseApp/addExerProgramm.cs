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
            db = new Database("Host=pgdb.uni-dubna.ru;Username=student25;Password=Io_228_1337;Database=student25");
        }

        private void butAddProgramm_Click(object sender, EventArgs e)
        {

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
