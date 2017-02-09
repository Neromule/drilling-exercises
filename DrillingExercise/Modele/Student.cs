using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drilling
{
    public class Student : User
    {
        private List<Theme> toDo;
        private Dictionary<Theme, int> marks;
        private Dictionary<Theme, TimeSpan> remainingTime;

        public List<Theme> ToDo
        {
            get
            {
                return toDo;
            }
        }

        public int getMark(Theme t)
        {
            return marks[t];
        }

        public Student(String firstName, String lastName, String mail, String password) : base(firstName, lastName, mail, password)
        {

        }
    }
}
