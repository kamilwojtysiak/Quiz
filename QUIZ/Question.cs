using System;
using System.Collections.Generic;
using System.Text;

namespace QUIZ
{
    public class Question
    {
        public Answer[] _answers;
        public string _correctanswer;

        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
