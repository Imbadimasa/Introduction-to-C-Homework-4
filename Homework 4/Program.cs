using System;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Homework_4
{

    class Program
    {
        static void Main()
        {
            string data = "Hello, I would like to order a pizza today!";
            string fileName = "Location.txt";
            File.WriteAllText(fileName, data);

            Console.WriteLine($"{fileName} has been modified!");
            Console.ReadLine();


        }
    }
}


