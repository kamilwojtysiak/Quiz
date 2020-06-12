using System;
using System.Collections.Generic;
using System.Text;

namespace QUIZ
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome in my quiz. Press any key to start.");
            Console.ReadKey();

            int result = 0;

            List<Question> newQuestions = Tools.AddQuestions();

            foreach (var question in newQuestions) 
            {
                Console.WriteLine(question.Text);

                foreach (var answer in question.Answers)
                {
                    Console.WriteLine(answer.Text);
                }

                Console.Write("Answer: ");

                string userAnswer = Console.ReadLine();

                if (userAnswer.ToUpper() == question.CorrectAnswer)
                {
                    Tools.ColorWriteLine("Correct!", ConsoleColor.Green);
                    result++;
                }
                else
                {
                    Tools.ColorWriteLine("Wrong answer!", ConsoleColor.Red);
                }
            }

            Tools.ColorWriteLine($"You got {result} point, its {Math.Round((decimal)result / newQuestions.Count * 100, 2)}%", ConsoleColor.Blue);
        }
    }
}