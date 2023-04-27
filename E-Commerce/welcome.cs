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
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void welcome_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderstatbtn_Click(object sender, EventArgs e)
        {

        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            profile p1 = new profile();
            p1.Show();
            this.Hide();
        }

        private void cartbtn_Click(object sender, EventArgs e)
        {
            cart p1 = new cart();
            p1.Show();
            this.Hide();
        }
    }
}
