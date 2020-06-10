using System;
using System.Collections.Generic;
using System.Text;

namespace QUIZ
{
    public class Question
    {
        public Answer[] Answers;
        public string Correctanswer;

        public string Text { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
