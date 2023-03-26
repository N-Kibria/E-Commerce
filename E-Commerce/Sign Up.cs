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

namespace E_Commerce
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
                string filepath = @"G:\IUT\Semester\1-2\SWE 4202\E-Commerce(Project)\Information.txt";
                StreamWriter sw = File.AppendText(filepath);
                using (sw)
                {
                    sw.WriteLine("Name : " + textBox4.Text);
                    sw.WriteLine("Username : " + textBox3.Text);
                    sw.WriteLine("Password : " + textBox2.Text);
                    sw.WriteLine("Re-Type Password : " + textBox1.Text);
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox2.Clear();
                    textBox1.Clear();


                }
            
           
        }
    }
}
