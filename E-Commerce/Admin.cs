using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text; 
            string correctPassword = "nafirami"; 

            if (password == correctPassword)
            {
                Shoplist sl = new Shoplist();
                sl.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sorry you cannot enter");
                Form1 lf = new Form1();
                lf.Show();
                this.Hide();
            }
        }
    }
}
