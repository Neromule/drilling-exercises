using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    abstract class User
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

        public User(String firstName, String lastName, String mail, String password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.mail = mail;
            this.password = password;
        }

        public static User fetchById(int id)
        {
            throw new Exception("Code à compléter");
        }

        public static User fetchByMail(String mail)
        {
            throw new Exception("Code à compléter");
        }

        public void push(String code)
        {
            throw new Exception("Code à compléter");
        }

        public void update()
        {
            throw new Exception("Code à compléter");
        }
    }
}
