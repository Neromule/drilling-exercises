using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drilling
{
    public class Question
    {
        private int id;
        private Theme belongsTo;
        private String text;
        private String memo;

        public int Id
        {
            get
            {
                return id;
            }
        }

        public Theme BelongsTo
        {
            get
            {
                return belongsTo;
            }
        }

        public String Text
        {
            get
            {
                return text;
            }
            set
            {
                this.text = Text;
            }
        }

        public String Memo
        {
            get
            {
                return memo;
            }
        }

        public Question(Theme belongsTo, String text, String memo)
        {
            this.belongsTo = belongsTo;
            this.text = text;
            this.memo = memo;
        }
    }
}
