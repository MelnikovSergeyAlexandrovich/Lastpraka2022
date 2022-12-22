using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastpractin2022___________
{
    internal class adminich
    {
        public static admin Admin = new admin();
        private static int selectedItem;
        private const int InputOffsetX = 30;
        private const int ArrowMenuTop = 5;

        public static void menu()
        {
            Console.WriteLine("привет admin!\t\t\t\t Роль: Администратор");
            Console.WriteLine("=====================================================================================================================");
        }
        public static void ui()
        {
            while (true)
            {

                Console.Clear();
                menu();
                Console.SetCursorPosition(85, 4);
                Console.WriteLine("/ Нажмите F1, чтобы добавить запись");
                Console.SetCursorPosition(85, 6);
                Console.WriteLine("/ Нажмите F2, чтобы найти запись");
                Console.SetCursorPosition(10, 3);
                Console.WriteLine("id:");
                Console.SetCursorPosition(25, 3);
                Console.WriteLine("login:");
                Console.SetCursorPosition(45, 3);
                Console.WriteLine("password:");
                Console.SetCursorPosition(70, 3);
                Console.WriteLine("role:");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.F1)
                {
                    append_func();
                }
                else if (key.Key == ConsoleKey.F2)
                {
                    find_any_id();
                }
            }
        }
        public static void find_any_id()
        {
            Console.Clear();
            menu();
            var user = new User();
            PrintArrowMenu(user);
            Console.SetCursorPosition(3,5);
            Console.WriteLine("\tID: ");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("\tlogin: ");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("\tpassword: ");
            Console.SetCursorPosition(3,8);
            Console.WriteLine("\tRole: ");
            poisk(user,List Users,int SelectedItem);
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.Enter:
                    InputUserProperty(user, selectedItem);
                    break;
                case ConsoleKey.Escape:
                    return;
                case ConsoleKey.UpArrow:
                    selectedItem = DecrementSelectedItem(selectedItem);
                    break;
                case ConsoleKey.DownArrow:
                    selectedItem = IncrementSelectedItem(selectedItem);
                    break;
            }

        }
            
            

    public static void append_func()
        {
            var user = new User();
            selectedItem = 0;
            while (true)
            {

                Console.Clear();
                menu();
                PrintArrowMenu(user);
                PrintHints();
                ConsoleKeyInfo key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        InputUserProperty(user, selectedItem);
                        break;
                    case ConsoleKey.Escape:
                        
                        return;
                    case ConsoleKey.UpArrow:
                        selectedItem = DecrementSelectedItem(selectedItem);
                        break;
                    case ConsoleKey.DownArrow:
                        selectedItem = IncrementSelectedItem(selectedItem);
                        break;
                    case ConsoleKey.F6:
                        Admin.Create(user);
                        return;
                }

            }

        }

        private static void InputUserProperty(User user, int selectedItem)
        {
            Console.SetCursorPosition(InputOffsetX, ArrowMenuTop + selectedItem);
            switch (selectedItem)
            {
                case 0:
                    user.id = int.Parse(Console.ReadLine()); 
                    break;
                case 1:
                    user.login = Console.ReadLine(); 
                    break;
                case 2:
                    user.password = Console.ReadLine();
                    break;
                case 3:
                    user.role = (Roles)int.Parse(Console.ReadLine()); 
                    break;


            }

        }
        private static void poisk(User user,List Users,int selectedItem)
        {
            Console.WriteLine("Выберете индекс, по котором будете искать пользователя");
            Console.WriteLine("Введите перенную для поиска.");
            string index = Console.ReadLine();
            Console.SetCursorPosition(InputOffsetX, ArrowMenuTop + selectedItem);
            switch (selectedItem)
            {
                case 0:
                    user.id = Console.ReadLine();
                    break;
                case 1:
                    user.login = Console.ReadLine();
                    break;
                case 2:
                    user.password = Console.ReadLine();
                    break;
                case 3:
                    user.role = Console.ReadLine();
                    break;


            }
            if (selectedItem == 0)
            {
                foreach (user in Users)
                {
                    if (user.id == index)
                    {
                        Console.Clear();
                        menu();
                        Console.WriteLine(user);
                    }
                    else if (selectedItem == 1)
                    {
                        foreach (user in Users)
                        {
                            if (user.login == index)
                            {
                               
                                Console.Clear();
                                menu();
                                Console.WriteLine(user);
                                ConsoleKeyInfo key = Console.ReadKey();
                                if (key.Key == ConsoleKey.Escape)
                                {
                                    return;
                                }
                            }
                        }
                    }
                    else if (selectedItem == 2)
                    {
                        foreach (user in Users)
                        {
                            if (user.password == index)
                            {
                                Console.Clear();
                                menu();
                                Console.WriteLine(user);
                                ConsoleKeyInfo key = Console.ReadKey();
                                if (key.Key == ConsoleKey.Escape)
                                {
                                    return;
                                }
                            }
                        }
                    }
                    else if (selectedItem == 3)
                    {
                        foreach (user in Users)
                        {
                            if (user.role == index)
                            {
                                Console.Clear();
                                menu();
                                Console.WriteLine(user);
                                ;
                                ConsoleKeyInfo key = Console.ReadKey();
                                if (key.Key == ConsoleKey.Escape)
                                {
                                    return;
                                }
                            }
                        }
                    }



                    } }
        }
            
        private static int IncrementSelectedItem(int selectedItem)
        {
            selectedItem++;
            if (selectedItem == 4)
            {
                return 3;
            }
            return selectedItem;
        }
        
        private static int DecrementSelectedItem(int selectedItem)
        {
            selectedItem--;
            if (selectedItem == -1)
            {
                return 0;
            }
            return selectedItem;
        }

        private static void PrintArrowMenu(User user)
        {
            var items = new[] { "id", "login", "password", "role" };

            Console.SetCursorPosition(0, ArrowMenuTop);
            for (int i = 0; i < items.Length; i++)
            {
                string item = items[i];
                if (i == selectedItem)
                {
                    Console.Write("->");
                }
                Console.Write($"\t{item}: ");
                PrintInputUserProperty(user, i);
                Console.WriteLine();
            }

        }

        private static void PrintInputUserProperty(User user, int i)
        {
            Console.SetCursorPosition(InputOffsetX, ArrowMenuTop + i);
            switch (i)
            {
                case 0:
                    if (user.id != 0)
                    {
                        Console.Write(user.id);
                    }
                    break;
                case 1:
                    if (user.login != null)
                    {
                        Console.Write(user.login);
                    }
                    break;
                case 2:
                    if (user.password != null)
                    {
                        Console.Write(user.password);
                    }
                    break;
                case 3:
                    if (user.role != 0)
                    {
                        Console.Write(user.role);
                    }
                    break;
            }   
        }

        private static void PrintHints()
        {
            Console.SetCursorPosition(85, 4);
            Console.WriteLine("/ 0 - Администратор  ");
            Console.SetCursorPosition(85, 5);
            Console.WriteLine("/ 1 - Склад-Менеджер");
            Console.SetCursorPosition(85, 6);
            Console.WriteLine("/ 2 - Кассир");
            Console.SetCursorPosition(85, 7);
            Console.WriteLine("/ 3 - Бухгалтер");
            Console.SetCursorPosition(85, 8);
            Console.WriteLine("/ 4 - Кадровик");
            Console.SetCursorPosition(85, 10);
            Console.WriteLine("/ F6 - Сохранить изменения");
            Console.SetCursorPosition(85, 12);
            Console.WriteLine("/ Esc - Вернуться в меню");
        }
       

        

    }
}
