using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            do
            {
                int number;
                string userChoice;
                Console.Write("Please, enter your number: ");
                number = int.Parse(Console.ReadLine()); // "Convert.ToInt32(number);"

                if (number >= 10 && number <= 20)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Your number, which is " + number + ", is even.");
                    }
                    else
                    {
                        Console.WriteLine("Your number, which is " + number + ", is odd.");
                    }

                    Console.WriteLine();
                    Console.Write("Do you want to continue?(Y/N): ");
                    userChoice = Console.ReadLine();
                    if (userChoice.ToUpper() == "YES" || userChoice.ToUpper() == "Y")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Program has been stopped!\n");
                        Console.WriteLine("=====================================");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You should be take a number between 10 and 20!");
                    Console.WriteLine();
                }


            } while (true);
            Console.ReadLine();
        }
    }
}