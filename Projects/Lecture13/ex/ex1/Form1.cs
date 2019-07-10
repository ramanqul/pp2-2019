using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex1
{
    public partial class Form1 : Form
    {

        private DatabaseHelper dbHelper;

        public Form1()
        {
            InitializeComponent();

            dbHelper = new DatabaseHelper("D:\\Code\\kbtu\\2019\\pp2-2019\\Projects\\Lecture13\\ex\\ex1\\db\\lab.sqlite");

        }



        private void Button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Starting query execution");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dbHelper.ExecuteQueryAsDataTable(
                "SELECT * from USERS"
                );
            Console.WriteLine("Ending query execution");
        }
    }
}
