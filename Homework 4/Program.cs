using System;

namespace Homework_4
{
    class Program
    {
        string error;
        [Flags]

        enum Seasons
        {
            Winter = 1,
            Spring = 2,
            Summer = 4,
            Autumn = 8,

        }
        static void Main(string[] args)
        {


                    Console.WriteLine("Please enter the number of the month.");
                    int input = Convert.ToInt32(Console.ReadLine());

                    Seasons season = (Seasons)determineSeason(input, out string error);

                    Seasons winter = season & Seasons.Winter;
                    Seasons spring = season & Seasons.Spring;
                    Seasons summer = season & Seasons.Summer;
                    Seasons autumn = season & Seasons.Autumn;

                    bool isWinter = winter == season;
                    bool isSpring = spring == season;
                    bool isSummer = summer == season;
                    bool isAutumn = autumn == season;

                    if (isWinter)
                    {
                        Console.WriteLine("It is Winter");
                    }
                    else if (isSummer)
                    {
                        Console.WriteLine("It is Summer");
                    }
                    else if (isSpring)
                    {
                        Console.WriteLine("It is Spring");
                    }
                    else if (isAutumn)
                    {
                        Console.WriteLine("It is Autumn");
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }

                    Console.ReadKey();
                
        }

        public static int determineSeason(int input, out string error)
        {
            if (input > 2 && input < 6)
            {
                error = "";
                return 2; //Spring
            }
            else if (input > 5 && input < 9)
            {
                error = "";
                return 4; //Summer
            }
            else if (input > 8 && input < 12)
            {
                error = "";
                return 8; //Autumn
            }
            else if ((input > 0 && input < 9)|| input == 12)
            {
                error = "";
                return 1; //Winter
            }
            error = "Please enter the correct number";
            return 5;
        }
    }
}
