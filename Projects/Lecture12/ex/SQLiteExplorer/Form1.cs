using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQLiteExplorer
{
    public partial class Form1 : Form
    {

        private DatabaseHelper dbHelper;
        private string filePath;

        public Form1()
        {
            InitializeComponent();
        }


        private Dictionary<string, string> getDict(string col, string val)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add(col, val);

            return dict;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (dbHelper == null)
            {
                MessageBox.Show("Please select sqlite file first!");
                return;
            }


            this.dataGridView1.AutoGenerateColumns = true;

            string query = textBox1.Text;
            setStatus( string.Format("Executing {0}", query) );
            dataGridView1.DataSource = dbHelper.ExecuteQueryAsDataTable(query);

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                dbHelper = new DatabaseHelper(filePath);
                
                setStatus( string.Format("{0} was selected", filePath) );
            }
        }

        private void setStatus(string message)
        {
            toolStripStatusLabel1.Text = message;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was built by @Ramanqul");
        }
    }
}
