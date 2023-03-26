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
            string name = textBox4.Text;
            string user_name = textBox3.Text;
            string password = textBox2.Text;
            int count = password.Length;
            string retype_pass = textBox1.Text;
            if (utility.users.Count > 0)
            {
                foreach (user u in utility.users)
                {
                    if (u.username == user_name)
                    {

                        if (count >= 6)
                        {
                            if (password == retype_pass)
                            {
                                string path = @"G:\IUT\Semester\1-2\SWE 4202\E-Commerce(Project)\Information.txt";
                                StreamWriter sw = File.AppendText(path);
                                user uu = new user(user_name, name, password);
                                utility.users.Add(uu);
                                string ss = $"{user_name},{password},{name}";
                                sw.WriteLine(ss);
                                sw.Close();

                                Form1 lf = new Form1();
                                lf.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Passwords do not match");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Password must be 6 or more characters");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username exists. Try another");
                    }
                }
            }
            else
            {

                string path = @"G:\IUT\Semester\1-2\SWE 4202\E-Commerce(Project)\Information.txt";
                StreamWriter sw = File.AppendText(path);
                user uu = new user(user_name, name, password);
                utility.users.Add(uu);
                string ss = $"{user_name},{password},{name}";
                sw.WriteLine(ss);
                sw.Close();

                Form1 lf = new Form1();
                lf.Show();
                this.Hide();
            }



        }
            
           
    }
}

