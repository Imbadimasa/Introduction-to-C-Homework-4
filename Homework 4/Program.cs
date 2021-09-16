using System;
using System.Diagnostics;


namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] myProcess = Process.GetProcesses();

            for (int i = 0; i < myProcess.Length; i++)
            {
                Console.WriteLine();
                Console.Write(myProcess[i]);
                Console.Write($" {myProcess[i].Id}");
            }

            Console.WriteLine();
            Console.WriteLine();
            bool loop = true;
            Console.WriteLine("Please choose a process you want to kill.");

            while (loop == true)
            {
                string chosenProcess = Console.ReadLine();
                int processID;
                bool success = int.TryParse(chosenProcess, out processID);

                if (success)
                {
                    for (int i = 0; i < myProcess.Length; i++)
                    {
                        if (myProcess[i].Id == processID)
                        {
                            myProcess[i].Kill();
                            Console.WriteLine("Successful Kill!");
                            loop = false;
                            break;
                        }
                    }
                    break;
                }
                else
                {
                    for (int i = 0; i < myProcess.Length; i++)
                    {
                        if (Convert.ToString(myProcess[i]) == chosenProcess)
                        {
                            myProcess[i].Kill();
                            Console.WriteLine("The kill was successful!");
                            loop = false;
                            break;
                        }
                    }
                    if (loop)
                    {
                        Console.WriteLine("Please enter the correct name/ID");
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
