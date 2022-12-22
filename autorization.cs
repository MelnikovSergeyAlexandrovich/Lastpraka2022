using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastpractin2022___________
{
    static class autorization
    {
        public static string login;
        public static string password;
        static void proverka()
        {
            if ((login.Length > 20) || (login.Length < 5))
            {
                Console.SetCursorPosition(3, 6);
                Console.WriteLine("\nПопробуйте ввести логин или пароль ещё раз!Длина превышает допустимые значения");
                
                break;
                Console.Clear();
                strelki_and_menu();
            }
            else if ((password.Length > 20) || (password.Length < 5))
            {
                Console.SetCursorPosition(3, 6);
                Console.WriteLine("\nПопробуйте ввести логин или пароль ещё раз! Длина превышает допустимые значения");
                break;
                Console.Clear();
                strelki_and_menu();
            }

        }
        public static void database_proverka(User user,List Users)
        {
            foreach (user in Users)
            {
                if (user.login == login)
                {
                    if (user.password == password)
                    {
                        if (user.role == 0)
                        {
                            adminich.ui();
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка. Попробуйте ввести пароль еще раз");
                        break;
                        Console.Clear();
                        strelki_and_menu();
                    }
                }
            }
        }
        static void strelki_and_menu()
        {
            
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("это жесть))))))0");
            Console.WriteLine("=================================================================================================================");
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("\tЛогин: ");
            Console.WriteLine("\tПароль: ");
            Console.WriteLine("\tАвторизоваться");
            int pos = 2;
            string str = "->";
            ConsoleKeyInfo key = Console.ReadKey();
            while (true)
            {

                Console.SetCursorPosition(0, pos);
                Console.Write(str);
                Console.SetCursorPosition(0, 0);

                 key = Console.ReadKey();
                Console.SetCursorPosition(0, pos);
                Console.Write("   ");

                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos == 1)
                    {
                        pos = 2;
                    }
                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    if (pos == 5)
                    {
                        pos = 4;
                    }
                }
                //

                
            }
            if ((pos == 2) && (key.Key == ConsoleKey.Enter))
            {
                Console.SetCursorPosition(15, pos);
                login = Console.ReadLine();
            }
            if ((pos == 3) && (key.Key == ConsoleKey.Enter))
            {
                Console.SetCursorPosition(30, pos);
                password = Console.ReadLine();
            }
            int count = 20;
            char zv = '*';
            while ((count < 40) || (key.Key != ConsoleKey.Enter))
            {
                    char chr = Console.ReadKey(true).KeyChar;
                    if (chr == password[count])
                    {
                        Console.SetCursorPosition(count, 3);
                        Console.Write(zv);
                        count++;
                    }
                    
            }
                if ((pos == 4) && (key.Key == ConsoleKey.Enter))
                {
                proverka();
                database_proverka(User user,List Users);
                }
        
        }
        internal static void autorizationchik()
        {
            strelki_and_menu();
        }
    }
}
