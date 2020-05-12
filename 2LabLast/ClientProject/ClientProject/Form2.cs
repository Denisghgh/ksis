﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Message = CommonLibrary.Messages;

namespace ClientProject
{
    public partial class Form2 : Form
    {
        public Form1 mainForm;

        public Form2()
        {
            InitializeComponent();
        }
       
        private bool ClientUserNameCheck(ref string clientUsername)
        {
            if (clientNameTextBox.Text != "")
            {
                clientUsername = clientNameTextBox.Text;
                if (clientLastNameTextBox.Text != "")
                    clientUsername = clientUsername + " " + clientLastNameTextBox.Text;
                return true;
            }
            MessageBox.Show("Client username is empty!");
            return false;
        }

        public void connectButton_Click(object sender, EventArgs e)
        {
            string clientUsername = "";
            if (ClientUserNameCheck(ref clientUsername))
            {
                Form1 Form1 = new Form1();
                Form1.ClientUsername = clientUsername;
                Form1.Owner = this;
                Form1.Show();
                //Hide();
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            
        }
 
    }
}
