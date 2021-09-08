using System;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            getCount();
            var count = Convert.ToInt32(Console.ReadLine());
            string[] fullName = new string[count];
            for (int i = 0; i < count; i++)
            {
                fullName[i] = getFullName();
            }

            Console.WriteLine("Listed Full Names:");
            Console.WriteLine();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(fullName[i]);
            }

            Console.ReadLine();
            
        }
        static void getCount()
        {
            Console.WriteLine("How many names would you like to add?");
        }

        static string getFullName()
        {
            string firstName;
            string patronimic;
            string lastName;

            Console.WriteLine("Please enter the first name.");
            firstName = Console.ReadLine();
            Console.WriteLine("Please enter the patronimic name.");
            patronimic = Console.ReadLine();
            Console.WriteLine("Please enter the last name.");
            lastName = Console.ReadLine();

            string name;

            name = $"{firstName} " + $"{patronimic} " + $"{lastName}";
            return name;

        }
    }
}
