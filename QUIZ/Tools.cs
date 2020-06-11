using System;
using System.Collections.Generic;
using System.Text;

namespace QUIZ
{
    static class Tools
    {
        public static void ColorWriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        
        public static void AskingQuestions()
        {
            List<Question> question = new List<Question>();

            question.Add(new Question { Text = "1. Jak długo Amazon działa na polskim rynku?", Correctanswer = "D", answers = new List<Answer>() });
            question.Add(new Question { Text = "2. Kto jest założycielem Amazon.com?", Correctanswer = "B", answers = new List<Answer>() });
            question.Add(new Question { Text = "3. Jak nazywa się jeden z głównych modeli sprzedaży na Amazon.com", Correctanswer = "B", answers = new List<Answer>() });
            question.Add(new Question { Text = "4. Czego sprzedażą początkowo zajmował się Amazon?", Correctanswer = "B", answers = new List<Answer>() });
            question.Add(new Question { Text = "5. Jaka firma była głównym konkurentem Amazona w Stanach Zjednoczonych?", Correctanswer = "D", answers = new List<Answer>() });

            question[0].answers.Add(new Answer { Text = "A) rok" });
            question[0].answers.Add(new Answer { Text = "B) 2 lata" });
            question[0].answers.Add(new Answer { Text = "C) 5 lat" });
            question[0].answers.Add(new Answer { Text = "D) Amazon nie działa w Polsce" });

            question[1].answers.Add(new Answer { Text = "A) Steve Jobs" });
            question[1].answers.Add(new Answer { Text = "B) Jeff Bezos" });
            question[1].answers.Add(new Answer { Text = "C) Al Pacino" });
            question[1].answers.Add(new Answer { Text = "D) Diego Simeone" });

            question[2].answers.Add(new Answer { Text = "A) KFC" });
            question[2].answers.Add(new Answer { Text = "B) FBA" });
            question[2].answers.Add(new Answer { Text = "C) RPA" });
            question[2].answers.Add(new Answer { Text = "D) ZTM" });

            question[3].answers.Add(new Answer { Text = "A) Artykuły buirowe" });
            question[3].answers.Add(new Answer { Text = "B) Książki" });
            question[3].answers.Add(new Answer { Text = "C) Płyty CD" });
            question[3].answers.Add(new Answer { Text = "D) Narzędzia" });

            question[4].answers.Add(new Answer { Text = "A) Allegro" });
            question[4].answers.Add(new Answer { Text = "B) Etsy" });
            question[4].answers.Add(new Answer { Text = "C) OLX" });
            question[4].answers.Add(new Answer { Text = "D) e-Bay" });

            int result = 0;
            
            foreach (var question in question)
            {
                Console.WriteLine(question.Text);

                foreach (var answer in question.answers)
                {
                    Console.WriteLine(answer.Text);
                }

                Console.Write("Answer: ");

                string userAnswer = Console.ReadLine();

                if (userAnswer.ToUpper() == question.Correctanswer)
                {
                    Tools.ColorWriteLine("Correct!", ConsoleColor.Green);
                    result++;
                }
                else
                {
                    Tools.ColorWriteLine("Wrong answer!", ConsoleColor.Red);
                }
            }

            Tools.ColorWriteLine($"You got {result} point, its {Math.Round((decimal)result / question.Count * 100)}%", ConsoleColor.Blue);
        }
    }
}

