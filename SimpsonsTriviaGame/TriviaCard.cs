using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpsonsTriviaGame
{
    class TriviaCard
    {
        private int id = 0;
        private char type = 'N';
        private string question = string.Empty;
        private string option1 = string.Empty;
        private string option2 = string.Empty;
        private string answer = string.Empty;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public char Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        public string Option1
        {
            get { return option1; }
            set { option1 = value; }
        }

        public string Option2
        {
            get { return option2; }
            set { option2 = value; }
        }

        public TriviaCard()
        {
        }

        public TriviaCard(int i, char t, string q, string o1, string o2, string a) 
        {
            id = i;
            type = t;
            question = q;
            option1 = o1;
            option2 = o2;
            answer = a;
        }
    }
}
