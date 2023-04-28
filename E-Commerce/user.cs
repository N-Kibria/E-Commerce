using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
    internal class user
    {
        private static int idCounter = 21000000;

        public int id { get; }
        public string username { get; set; }
        public string name { get; set; }
        public string password { get; set; }

        public user(string username, string password, string name)
        {
            this.id = ++idCounter;
            this.username = username;
            this.name = name;
            this.password = password;
        }
    }

}
