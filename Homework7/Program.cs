// Decompiled with JetBrains decompiler
// Type: Homework_4.Program
// Assembly: Homework 4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AD3AAD71-EBA1-442C-AE1A-67AE3571691D
// Assembly location: C:\Users\ROG\Desktop\Homework7.exe

using System;
using System.Diagnostics;

namespace Homework_4
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Process[] processes = Process.GetProcesses();
      for (int index = 0; index < processes.Length; ++index)
      {
        Console.WriteLine();
        Console.Write((object) processes[index]);
        Console.Write(string.Format(" {0}", (object) processes[index].Id));
      }
      Console.WriteLine();
      Console.WriteLine();
      bool flag = true;
      Console.WriteLine("Please choose a process you want to kill right now!!!!!!!!!!!");
      while (flag)
      {
        string s = Console.ReadLine();
        int result;
        if (int.TryParse(s, out result))
        {
          for (int index = 0; index < processes.Length; ++index)
          {
            if (processes[index].Id == result)
            {
              processes[index].Kill();
              Console.WriteLine("Successful Kill!");
              break;
            }
          }
          break;
        }
        for (int index = 0; index < processes.Length; ++index)
        {
          if (Convert.ToString((object) processes[index]) == s)
          {
            processes[index].Kill();
            Console.WriteLine("The kill was successful!");
            flag = false;
            break;
          }
        }
        if (flag)
          Console.WriteLine("Please enter the correct name/ID");
      }
      Console.ReadLine();
    }
  }
}
