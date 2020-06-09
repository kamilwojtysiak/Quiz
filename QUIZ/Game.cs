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
            Console.WriteLine();

            var questions = new Question[]
            {
                new Question
                {
                    _correctanswer = "D",
                    Text = "1. Jak długo Amazon działa na polskim rynku?",
                    _answers = new Answer[]
                    {
                        new Answer
                        {
                            Text = "A) rok",
                            _iscorrect = false
                        },
                        new Answer
                        {
                            Text = "B) 2 lata",
                            _iscorrect = false
                        },
                        new Answer
                        {
                            Text = "C) 5 lat",
                            _iscorrect = false
                        },
                        new Answer
                        {
                            Text = "D) Amazon nie działa w Polsce",
                            _iscorrect = true
                        }                 
                    }
                },
                new Question
                {
                    _correctanswer = "B",
                    Text = "2. Kto jest założycielem Amazon.com?",
                    _answers = new Answer[]
                    {
                        new Answer
                        {
                            Text = "A) Steve Jobs",
                            _iscorrect = false
                        },
                        new Answer
                        {
                            Text = "B) Jeff Bezos",
                            _iscorrect = true
                        },
                        new Answer
                        {
                            Text = "C) Al Pacino",
                            _iscorrect = false
                        },
                        new Answer
                        {
                            Text = "D) Diego Simeone",
                            _iscorrect = false
                        }
                    }
                },
                new Question
                {
                    _correctanswer = "B",
                    Text = "3. Jak nazywa się jeden z głównych modeli sprzedaży na Amazon.com",
                    _answers = new Answer[]
                    {
                        new Answer
                        {
                            Text = "A) KFC",
                            _iscorrect = false
                        },
                        new Answer
                        {
                            Text = "B) FBA",
                            _iscorrect = true
                        },
                        new Answer
                        {
                            Text = "C) ZTM",
                            _iscorrect = false
                        },
                        new Answer
                        {
                            Text = "D) RPK",
                            _iscorrect = false
                        }      
                    }
                },
                new Question
                {
                    _correctanswer = "B",
                    Text = "4. Czego sprzedażą początkowo zajmował się Amazon?",
                    _answers = new Answer[]
                    {
                        new Answer
                        {
                            Text = "A) Artykuły biurowe",
                            _iscorrect = false
                        },
                        new Answer
                        {
                            Text = "B) Książki",
                            _iscorrect = true
                        },
                        new Answer
                        {
                            Text = "C) Narzędzia",
                            _iscorrect = false
                        },
                        new Answer
                        {
                            Text = "D) Płyty CD",
                            _iscorrect = false
                        }
                    }
                },
                new Question
                {
                    _correctanswer = "D",
                    Text = "5. Jaka firma była głównym konkurentem Amazona w Stanach Zjednoczonych?",
                    _answers = new Answer[]
                    {
                        new Answer
                        {
                            Text = "A) OLX",
                            _iscorrect = false
                        },
                        new Answer
                        {
                            Text = "B) Allegro",
                            _iscorrect = false
                        },
                        new Answer
                        {
                            Text = "C) Etsy",
                            _iscorrect = false
                        },
                        new Answer
                        {
                            Text = "D) e-Bay",
                            _iscorrect = true
                        }    
                    }
                }
            };

            int result = 0;

            foreach (var question in questions)
            {
                Console.WriteLine(question);

                foreach (var answer in question._answers)
                {
                    Console.WriteLine(answer);
                }

                Console.Write("Answer: ");

                string userAnswer = Console.ReadLine();

                if (userAnswer.ToUpper() == question._correctanswer)
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