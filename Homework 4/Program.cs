using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;


namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World!";
            byte[] data = Encoding.ASCII.GetBytes(text);
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);     //List the bytes used for data storage
            }

            string writtenBytes = "Bytes.txt";
            File.WriteAllBytes(writtenBytes, data);

            byte[] readBytes = File.ReadAllBytes(writtenBytes);
            Console.WriteLine(Encoding.ASCII.GetString(readBytes));


            Console.ReadLine();
        }
    }
}
