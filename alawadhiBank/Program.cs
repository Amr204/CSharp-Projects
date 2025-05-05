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

            List<user> listUser = [];


            PrintWithColor("AL-AWADHI BANK", "blue");

            Console.WriteLine(@"1- admin
2- user
3- press any key to quit");

            switch (byte.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Admin");
                    Console.WriteLine("later");
                    break;
                case 2:
                    NewMethod(listUser);
                    break;
                case 3:
                    Console.WriteLine("later");
                    break;
                default:
                    PrintWithColor("Invalid number", "red");
                    break;



            }


            void NewMethod(List<user> list)
            {
                Console.WriteLine(@"1- LogIn
2- SignUp
3- Change Password
0- exit");
                byte a = byte.Parse(Console.ReadLine());
                while (a != 0)
                {
                    switch (a)
                    {
                        case 1:

                            Console.Write("Enter Your Name: ");
                            string name = Console.ReadLine();
                            while (string.IsNullOrWhiteSpace(name))
                                PrintWithColor("Please Enter Your Name", "red");
                            Console.Write("Enter Your Password: ");
                            string password = Console.ReadLine();
                            while (string.IsNullOrWhiteSpace(password))
                                PrintWithColor("Please Enter Your Password", "red");
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i].Name == name)
                                {
                                    if (list[i].Password == password)
                                        Console.WriteLine("Now U should go to the interface");
                                }
                                else
                                { PrintWithColor("Invalid Login", "red"); }
                                break;
                            }


                            break;
                        case 2:

                            Console.Write("Enter the Name: ");
                            string signUpName = Console.ReadLine();
                            while (true)
                            {
                                if (string.IsNullOrWhiteSpace(signUpName))
                                    PrintWithColor("Please Enter the Name", "red");
                                else
                                    break;
                            }
                        back:
                            Console.Write("Enter the Password: ");
                            string signUpPassword = Console.ReadLine();
                            while (true)
                            {
                                if (string.IsNullOrWhiteSpace(signUpPassword))
                                    PrintWithColor("Please Enter the Password", "red");
                                else
                                    break;
                            }

                            Console.Write("Confirm the Password: ");
                            string signUpConfirm = Console.ReadLine();

                            bool temp = true;
                            while (temp)
                            {
                                if (string.Equals(signUpPassword, signUpConfirm, StringComparison.Ordinal))
                                {
                                    listUser.Add(new user { Name = signUpName, Password = signUpConfirm });
                                    temp = false;
                                }
                                else
                                {
                                    PrintWithColor("Password dosen't match", "red");
                                    goto back;
                                }

                            }

                            break;
                        case 3:
                            Console.WriteLine("change password later...");
                            break;
                        case 4:

                            foreach (user user in listUser)
                            {
                                Console.WriteLine("ID: " + user.Id);
                                Console.WriteLine("Username: " + user.Name + ", Password: " + user.Password);
                                PrintWithColor("-------------------------------------------", "green");
                            }
                            break;
                        default:
                            PrintWithColor("Invalid number", "red");
                            break;

                    }
                    Console.WriteLine(@"1- LogIn
2- SignUp
3- Change Password
4- show all users
0- exit");
                    Console.Write("Enter your choise: ");
                    a = byte.Parse(Console.ReadLine());
                }

                Console.WriteLine("Thank you for using AL-AWADHI Bank");

            }

        }
    }
}