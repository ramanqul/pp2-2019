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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsFormValid()
        {

            bool ok = true;

            if (tbName.Text == "")
            {
                lbMsgName.Text = "This field is required!";
                ok = false;
            } else
            {
                lbMsgName.Text = "";
            }

            if (cbGender.SelectedItem == null)
            {
                lbMsgGender.Text = "This field is required!";
                ok = false;
            } else
            {
                lbMsgGender.Text = "";
            }

            return ok;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (IsFormValid())
            {
                //Save operation
                MessageBox.Show("Saved!");
            }



        }
    }
}
