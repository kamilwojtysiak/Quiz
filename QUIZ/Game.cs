using System;
using System.Collections.Generic;
using System.Text;

namespace QUIZ
{
    class Game
    {
        public static void Main()
        {
            Console.WriteLine("Welcom in my quiz. Press any key to start.");
            Console.ReadKey();

            Tools.AskingQuestions();
        }
    }
}