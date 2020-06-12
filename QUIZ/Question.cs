using System;
using System.Collections.Generic;
using System.Text;

namespace QUIZ
{
    public class Question
    {
        public List<Answer> Answers { get; set; }

        public string CorrectAnswer { get; set; }

        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
