﻿using System;
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
        public mainForm()
        {
            InitializeComponent();
        }
        ~mainForm() { Application.Exit(); }

        private void but_plan_ate_Click(object sender, EventArgs e)
        {
            
        }

        private void but_add_product_Click(object sender, EventArgs e)
        {
            addProdForm addProdForm = new addProdForm();
            addProdForm.Show();
            this.Close();
        }

        private void but_add_exersice_Click(object sender, EventArgs e)
        {
            addExerForm addExerForm = new addExerForm();
            addExerForm.Show();
            this.Close();
        }
    }
}