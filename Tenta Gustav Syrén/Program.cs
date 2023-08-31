using System.Collections.Generic;

namespace Tenta_Gustav_Syrén
{
    internal class Program
    {
        static void Welcome() //Metoden skriver ut ett välkommstmeddelande
        {
            Console.WriteLine("Welcome to my program!\n");
            Console.WriteLine("The program will help you determine if a specified year is a leap year or not.");
            Console.WriteLine("Please follow any instructions that are given.");
            Console.WriteLine("----------------------------------------------");

        }

        static int GetYear() //Metoden tar in årtalet som användaren vill kontrollera
        {
            while (true)
            {
                try
                {
                    Console.Write("\nInput the year you want to check: ");
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Your input was incorrect. Please input a year using numbers.");
                }
            } 
        }

        static bool IsLeapYear(int year) //Metoden räknar ut hurvida angivet är är ett skottår eller inte
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
           
        }

        static void PrintResult(bool isLeapYear, int year) //Metoden skriver ut vikket år använderen angav och hurvida det är ett skottår eller inte
        {
            if (isLeapYear)
            {
                Console.WriteLine($"The year you entered ({year}) IS a leap year.\n");
            }
            else
            {
                Console.WriteLine($"The year you entered ({year}) ISN'T a leap year.\n");
            }
        }

        static bool NextLap() //Metoden frågar om användaren vill kontrollera flera årtal. Om ja kör vi ett varv till, annars avslutas programmet. Läste för dåligt och hade redan gjort metoden som ett menyval istället för att upprepa tills man skrev i ett negativt val, hoppas att det inte gör något. 
        {
            while (true)
            {
                try
                {
                    Console.Write("Do you want to check another year? [Y]es or [N]o: ");
                    string choice = Console.ReadLine();

                    if (choice.ToUpper() == "Y")
                    {
                        return true;
                    }
                    else if (choice.ToUpper() == "N")
                    {
                        return false;
                    }
                }
                catch
                {
                    Console.WriteLine("Your input was incorrect, you have to pick [Y]es or [N}o");
                }
            } 
        }

        static void GoodBye() //Metoden skriver ut ett hejdåmeddelande
        {
            Console.WriteLine("\nThanks for using my program to check for leap years!");
            Console.WriteLine("The program is now closing, see you next time!");
            Console.WriteLine("----------------------------------------------");
        }


        static void Main(string[] args)
        {
            Welcome();

            bool nextLap = true;
            while (nextLap)
            {
                
                int year = GetYear();
                bool isLeapYear = IsLeapYear(year);
                PrintResult(isLeapYear, year);
                nextLap = NextLap();
               
            }
            GoodBye();
        }
    }
}