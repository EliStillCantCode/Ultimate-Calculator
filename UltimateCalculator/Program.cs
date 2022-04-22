using System;
using System.Xml;

namespace UltimateCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num01;
            double num02;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            
            Console.Write("What is the first number: ");
            num01 = Convert.ToDouble( Console.ReadLine() );
            
            Console.Write("Awesome! Input a second: ");
            num02 = Convert.ToDouble( Console.ReadLine() );

            double added = num01 + num02;
            double subtracted = num01 - num02;
            double multiplied = num01 * num02;
            double divided = num01 / num02;
            double average = (num01 + num02) / 2;
            double num01S = num01 * num01;
            double num02S = num02 * num02;
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("Added together: " + added);
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Subtracted: " + subtracted);
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Multiplied: " + multiplied);
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Divided: " + divided);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Mean average: " + average);
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Input 1 squared: " + num01S);
            
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Input 2 squared: " + num02S + "\n");
            
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("[Press SPACEBAR to exit]");


            Console.ReadKey();
        }
    }
}