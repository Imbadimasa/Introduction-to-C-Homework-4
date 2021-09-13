using System;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = DateTime.Now.ToString("T");           
            Console.WriteLine($"The time now is {time}");

            string fileName = "startup.txt";
            File.AppendAllText(fileName, Environment.NewLine);
            File.AppendAllText(fileName, time);

            string check = File.ReadAllText(fileName);
            Console.WriteLine("Here is the log of time when the application has been open:");
            Console.WriteLine(check);

            Console.ReadLine();

        }
    }
}
