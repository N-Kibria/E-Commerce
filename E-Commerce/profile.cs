using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E_Commerce
{
    public partial class profile : Form
    {
        private string user_name;
        public profile(string username)
        {
            InitializeComponent();
            this.user_name = username;
        }
        public profile() { }

      

        private void backbtn_Click(object sender, EventArgs e)
        {
            welcome lf = new welcome();
            lf.Show();
            this.Hide();
        }

        private void profile_Load(object sender, EventArgs e)
        {

        }

        private void infobtn_Click(object sender, EventArgs e)
        {
            // Find the user object based on the logged in user's username

            user loggedInUser = utility.users.FirstOrDefault(u => u.username == user_name);


            // Check if the user was found
            if (loggedInUser != null)
            {
                // Display the user's information
                MessageBox.Show($"Name: {loggedInUser.name}\nUsername: {loggedInUser.username}\nId: {loggedInUser.id}");
            }
            else
            {
                MessageBox.Show("User not found.");
            }

        }


        private void information_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
