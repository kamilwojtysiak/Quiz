using System;
using System.Collections.Generic;
using System.Text;

namespace QUIZ
{
    public static class Tools
    {
        public static void ColorWriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        
        public static List<Question> AddQuestions()
        {
            List<Question> questions = new List<Question>();

            questions.Add(new Question { Text = "1. Jak długo Amazon działa na polskim rynku?", CorrectAnswer = "D", Answers = new List<Answer>()
            { 
                new Answer { Text = "A) rok" }, 
                new Answer { Text = "B) 2 lata" }, 
                new Answer { Text = "C) 5 lat" },
                new Answer { Text = "D) Amazon nie działa w Polsce" } } });

            questions.Add(new Question { Text = "2. Kto jest założycielem Amazon.com?", CorrectAnswer = "B", Answers = new List<Answer>() 
            {
                new Answer { Text = "A) Steve Jobs" }, 
                new Answer { Text = "B) Jeff Bezos" }, 
                new Answer { Text = "C) Al Pacino" },
                new Answer { Text = "D) Diego Simeone" } } });

            questions.Add(new Question { Text = "3. Jak nazywa się jeden z głównych modeli sprzedaży na Amazon.com", CorrectAnswer = "B", Answers = new List<Answer>() 
            { 
                new Answer { Text = "A) KFC" }, 
                new Answer { Text = "B) FBA" }, 
                new Answer { Text = "C) ZTM" }, 
                new Answer { Text = "D) RPA" } } });

            questions.Add(new Question { Text = "4. Czego sprzedażą początkowo zajmował się Amazon?", CorrectAnswer = "B", Answers = new List<Answer>() 
            { 
                new Answer { Text = "A) Artykuły biurowe" }, 
                new Answer { Text = "B) Książki" }, 
                new Answer { Text = "C) Płyty CD" },
                new Answer { Text = "D) Narzędzia" } } });

            questions.Add(new Question { Text = "5. Jaka firma była głównym konkurentem Amazona w Stanach Zjednoczonych?", CorrectAnswer = "D", Answers = new List<Answer>() 
            { 
                new Answer { Text = "A) Allegro" }, 
                new Answer { Text = "B) Etsy" }, 
                new Answer { Text = "C) OLX" }, 
                new Answer { Text = "D) e-Bay" } } });

            return questions;        
        }
    }
}

