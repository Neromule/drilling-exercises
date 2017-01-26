using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Answer
    {
        private int id;
        private Question belongsTo;
        private String text;
        private bool correct;

        public Question BelongsTo
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
        }

        public bool Correct
        {
            get
            {
                return correct;
            }
        }

        public Answer(Question belongsTo, String text, bool correct)
        {
            this.belongsTo = belongsTo;
            this.text = text;
            this.correct = correct;
        }
    }
}
