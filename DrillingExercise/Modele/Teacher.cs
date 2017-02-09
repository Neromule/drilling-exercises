using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drilling
{
    class Teacher : User
    {
        public Teacher(String firstName, String lastName, String mail, String password) : base(firstName, lastName, mail, password)
        {

        }
    }
}
