using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        string selectedFilePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog selectFileDialog = new OpenFileDialog();

            DialogResult result = selectFileDialog.ShowDialog();

            if (selectFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = selectFileDialog.FileName;
            } else
            {
                MessageBox.Show("Please select a file!");
                return;
            }

            string content = File.ReadAllText(selectedFilePath);
            textBox1.Text = content;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(selectedFilePath, textBox1.Text);
        }
    }
}
