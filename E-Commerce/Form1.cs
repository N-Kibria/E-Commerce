using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace E_Commerce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            utility.load_users();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_Up f2 = new Sign_Up();
            f2.Show();
            this.Hide();
        }
        public string GetUsername()
        {
            return textBox1.Text;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string user_name = textBox1.Text;
            string password = textBox2.Text;

            bool userFound = false;
            
            // Load the list of users from the text file
            utility.load_users();

            // Check if the entered username and password match a user in the list
            foreach (user u in utility.users)
            {
                if (u.username == user_name && u.password == password)
                {
                    userFound = true;

                    break;
                }
            }
           

            if (userFound)
            {
                MessageBox.Show("Successfully logged in");
                welcome p1 = new welcome( user_name);
                p1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
