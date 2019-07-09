using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhoneBookApp
{

    /*
     Task:
     Create application which will save data into users table
     
      create table users(id int, 
        name varchar(40),  
        surname varchar(40),
        email varchar(40)
      );

      When Add button is pressed new window (InsertWindow) should appear with following 
       form items:
       1. ID 
       2. Name
       3. Surname
       4. Email
     
        In the botton of InsertWindow Save and Cancel buttons should be located.
        When Cancel button is pressed the window should be closed.
        When Save button is pressed form data should be saved into users table 
        as a new record.
         
    */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
