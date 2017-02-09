using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drilling
{
    abstract public class User
    {
        private int id;
        private String firstName;
        private String lastName;
        private String mail;
        private String password;

        public int Id
        {
            get
            {
                return id;
            }
        }

        public String FirstName
        {
            get
            {
                return firstName;
            }
        }

        public String LastName
        {
            get
            {
                return lastName;
            }
        }

        public String Mail
        {
            get
            {
                return mail;
            }
        }

        public String Password
        {
            get
            {
                return password;
            }
        }

        public User(String firstName, String lastName, String mail, String password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.mail = mail;
            this.password = password;
        }
    }
}
