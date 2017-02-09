using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace Modele
=======
namespace Drilling
>>>>>>> 22e0e364a9504b8c975eff4bbe3c569647f821eb
{
    public class Theme
    {
        private int id;
        private String title;
        private String memo;
        private char minimumMark;
        private short partLength;
        private short duration;

        public int Id
        {
            get
            {
                return id;
            }
        }

        public String Title
        {
            get
            {
                return title;
            }
<<<<<<< HEAD

            set
            {
                this.title = Title;
            }
=======
>>>>>>> 22e0e364a9504b8c975eff4bbe3c569647f821eb
        }

        public String Memo
        {
            get
            {
                return memo;
            }
        }

        public char MinimumMark
        {
            get
            {
                return minimumMark;
            }
        }

        public short PartLength
        {
            get
            {
                return partLength;
            }
        }

        public short Duration
        {
            get
            {
                return duration;
            }
        }

        public Theme(String title, String memo, char minimumMark, short partLength, short duration)
        {
            this.title = title;
            this.memo = memo;
            this.minimumMark = minimumMark;
            this.partLength = partLength;
            this.duration = duration;
        }
<<<<<<< HEAD

        public static Theme fetchById(int id)
        {
            throw new Exception("Code à compléter");
        }

        public void push()
        {
            throw new Exception("Code à compléter");
        }

        public void update()
        {
            throw new Exception("Code à compléter");
        }
=======
>>>>>>> 22e0e364a9504b8c975eff4bbe3c569647f821eb
    }
}
