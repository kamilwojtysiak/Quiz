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
            var questions = new Question[]
            {
                new Question
                {
                    Correctanswer = "D",
                    Text = "1. Jak długo Amazon działa na polskim rynku?",
                    Answers = new Answer[]
                    {
                        new Answer
                        {
                            Text = "A) rok",
                        },
                        new Answer
                        {
                            Text = "B) 2 lata",
                        },
                        new Answer
                        {
                            Text = "C) 5 lat",
                        },
                        new Answer
                        {
                            Text = "D) Amazon nie działa w Polsce",
                        }
                    }
                },
                new Question
                {
                    Correctanswer = "B",
                    Text = "2. Kto jest założycielem Amazon.com?",
                    Answers = new Answer[]
                    {
                        new Answer
                        {
                            Text = "A) Steve Jobs",
                        },
                        new Answer
                        {
                            Text = "B) Jeff Bezos",
                        },
                        new Answer
                        {
                            Text = "C) Al Pacino",
                        },
                        new Answer
                        {
                            Text = "D) Diego Simeone",
                        }
                    }
                },
                new Question
                {
                    Correctanswer = "B",
                    Text = "3. Jak nazywa się jeden z głównych modeli sprzedaży na Amazon.com",
                    Answers = new Answer[]
                    {
                        new Answer
                        {
                            Text = "A) KFC",
                        },
                        new Answer
                        {
                            Text = "B) FBA",
                        },
                        new Answer
                        {
                            Text = "C) ZTM",
                        },
                        new Answer
                        {
                            Text = "D) RPK",
                        }
                    }
                },
                new Question
                {
                    Correctanswer = "B",
                    Text = "4. Czego sprzedażą początkowo zajmował się Amazon?",
                    Answers = new Answer[]
                    {
                        new Answer
                        {
                            Text = "A) Artykuły biurowe",
                        },
                        new Answer
                        {
                            Text = "B) Książki",
                        },
                        new Answer
                        {
                            Text = "C) Narzędzia",
                        },
                        new Answer
                        {
                            Text = "D) Płyty CD",
                        }
                    }
                },
                new Question
                {
                    Correctanswer = "D",
                    Text = "5. Jaka firma była głównym konkurentem Amazona w Stanach Zjednoczonych?",
                    Answers = new Answer[]
                    {
                        new Answer
                        {
                            Text = "A) OLX",
                        },
                        new Answer
                        {
                            Text = "B) Allegro",
                        },
                        new Answer
                        {
                            Text = "C) Etsy",
                        },
                        new Answer
                        {
                            Text = "D) e-Bay",
                        }
                    }
                }
            };

            int result = 0;

            foreach (var question in questions)
            {
                Console.WriteLine(question);

                foreach (var answer in question.Answers)
                {
                    Console.WriteLine(answer);
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

            Console.WriteLine();

            Tools.ColorWriteLine($"Your result is: {result} points", ConsoleColor.Blue);
        }
    }


}
