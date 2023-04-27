using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E_Commerce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_Up f2 = new Sign_Up();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = @"G:\IUT\Semester\1-2\SWE 4202\E-Commerce(Project)\Information.txt";
            StreamReader sr = new StreamReader(filepath);
            string str = sr.ReadLine();
            while(str != null) 
            {
                if((str == textBox1.Text))// & ( str == textBox2.Text))
                {
                    MessageBox.Show("success");
                }
                str=sr.ReadLine();
            }
        }
    }
}
