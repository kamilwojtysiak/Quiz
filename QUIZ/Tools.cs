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
            List<Question> questions = new List<Question>();

            questions.Add(new Question { Text = "1. Jak długo Amazon działa na polskim rynku?", Correctanswer = "D", answers = new List<Answer>() });
            questions.Add(new Question { Text = "2. Kto jest założycielem Amazon.com?", Correctanswer = "B", answers = new List<Answer>() });
            questions.Add(new Question { Text = "3. Jak nazywa się jeden z głównych modeli sprzedaży na Amazon.com", Correctanswer = "B", answers = new List<Answer>() });
            questions.Add(new Question { Text = "4. Czego sprzedażą początkowo zajmował się Amazon?", Correctanswer = "B", answers = new List<Answer>() });
            questions.Add(new Question { Text = "5. Jaka firma była głównym konkurentem Amazona w Stanach Zjednoczonych?", Correctanswer = "D", answers = new List<Answer>() });

            questions[0].answers.Add(new Answer { Text = "A) rok" });
            questions[0].answers.Add(new Answer { Text = "B) 2 lata" });
            questions[0].answers.Add(new Answer { Text = "C) 5 lat" });
            questions[0].answers.Add(new Answer { Text = "D) Amazon nie działa w Polsce" });

            questions[1].answers.Add(new Answer { Text = "A) Steve Jobs" });
            questions[1].answers.Add(new Answer { Text = "B) Jeff Bezos" });
            questions[1].answers.Add(new Answer { Text = "C) Al Pacino" });
            questions[1].answers.Add(new Answer { Text = "D) Diego Simeone" });

            questions[2].answers.Add(new Answer { Text = "A) KFC" });
            questions[2].answers.Add(new Answer { Text = "B) FBA" });
            questions[2].answers.Add(new Answer { Text = "C) RPA" });
            questions[2].answers.Add(new Answer { Text = "D) ZTM" });

            questions[3].answers.Add(new Answer { Text = "A) Artykuły buirowe" });
            questions[3].answers.Add(new Answer { Text = "B) Książki" });
            questions[3].answers.Add(new Answer { Text = "C) Płyty CD" });
            questions[3].answers.Add(new Answer { Text = "D) Narzędzia" });

            questions[4].answers.Add(new Answer { Text = "A) Allegro" });
            questions[4].answers.Add(new Answer { Text = "B) Etsy" });
            questions[4].answers.Add(new Answer { Text = "C) OLX" });
            questions[4].answers.Add(new Answer { Text = "D) e-Bay" });

            int result = 0;
            
            foreach (var question in questions)
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

            Tools.ColorWriteLine($"You got {result} point, its {Math.Round((decimal)result / questions.Count * 100)}%", ConsoleColor.Blue);
        }
    }
}

