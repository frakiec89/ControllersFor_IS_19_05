using System;
using System.Collections;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Controllers.GroupController groups = new Controllers.GroupController();

            while(true)
            {
                Menu(groups);
            }
        }

        private static void Menu(Controllers.GroupController group)
        {
            Console.WriteLine("Введите Add для добавления  группы");
            Console.WriteLine("Введите Print для вывода всех групп на экран");
            Console.WriteLine("Введите Remove для Удаления группы");

            switch (Console.ReadLine().TrimStart().TrimEnd().ToUpper())
            {
                case "ADD": AddGroupo(group); break;
                case "PRINT": Print(group.Groups); break;
                case "REMOVE": RemoveGroup( group); break;



                default:
                    Console.WriteLine("Команда не  опознана");
                    break;
            }

            Console.WriteLine();
        }

        private static void RemoveGroup(Controllers.GroupController groupController)
        {
            try
            {
                Console.WriteLine("Укажите  название группы которую хотите удалить");
                var name = Console.ReadLine();
                groupController.RemoveGroup(name);
                Console.WriteLine("Группа удаленна");
                Print(groupController.Groups);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AddGroupo(Controllers.GroupController groupController)
        {
            try
            {
                Console.WriteLine("Укажите  название группы");
                var name = Console.ReadLine();
                Console.WriteLine("Укажите год  зачисления");
                var data = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Укажите  кол-во  курсов группы");
                var count = Convert.ToInt32(Console.ReadLine());
                groupController.AddGroup(name, data, count);
                Console.WriteLine("Группа добавлена");
                Print(groupController.Groups);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Print(IEnumerable queryable)
        {
            foreach (var item in queryable)
            {
                Console.WriteLine(item);
            }
        }
    }
}
