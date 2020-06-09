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
        
    }
}
