using System;
using System.Collections.Generic;
using System.Text;

namespace QUIZ
{
    public class Answer
    {
        public bool _iscorrect;

        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
