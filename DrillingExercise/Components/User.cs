using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drilling
{
    public class User
    {
        private string firstName;
        private string name;
        private string mail;
        private string password;

        public User(string firstName, string name, string mail, string password)
        {
            this.name = name;
            this.firstName = firstName;
            this.mail = mail;
            this.password = password;
        }

        public string Name
        {
            get { return name; }
        }

        public string FirstName
        {
            get { return firstName; }
        }

        public string Mail
        {
            get { return mail; }
        }

        public string Password
        {
            get { return password; }
        }
    }
}
