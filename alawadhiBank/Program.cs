using System;

namespace alawadhiBank
{


    class Program
    {
        static void PrintWithColor(string text, string colorName)
        {
            if (Enum.TryParse(colorName, true, out ConsoleColor color))
            {
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"Error: Color '{colorName}' not found. Using default color.");
                Console.WriteLine(text);
            }
        }

        static void Main(string[] args)
        {


            PrintWithColor("AL-AWADHI BANK", "blue");
            Console.WriteLine(@"1- admin
2- user
3- press any key to quit");
            int choise = Byte.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.WriteLine("later");
                    break;
                case 2:
                    user user = new user("Amr Khaled", "pass");
                    break;
                case 3:
                    Console.WriteLine("later");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;

               

            }
        }
    }
}