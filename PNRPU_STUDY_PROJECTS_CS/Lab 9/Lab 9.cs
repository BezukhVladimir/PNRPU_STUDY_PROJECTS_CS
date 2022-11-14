﻿using InteractiveConsoleMenu;
using SpecificDataStructures;
using System.Runtime.InteropServices;

namespace Lab9
{
    public class Lab
    {
        public static Menu menu = new(
            new MenuCategory("Главное меню",
                             "Опции лабораторной работы №9", new MenuItem[]{
                new MenuBack("Завершить работу программы"),
                new MenuAction("Выполнить первое задание", SolveFirstTask),
                new MenuAction("Выполнить второе задание", SolveSecondTask),
                new MenuAction("Выполнить третье задание", SolveThirdTask)
        }));
        public static int menuStartIndex = 0;
        public static int downWorkAreaIndex = menuStartIndex;

        public static void ShowTaskMenu()
        {
            menu.Run();
        }

        private static void SolveFirstTask()
        {
            if (downWorkAreaIndex != menuStartIndex)
                ConsoleHandler.Cleaner.ClearRowsInRange(menu.downMenuIndex, downWorkAreaIndex);
            
            Console.WriteLine("\nfirst task");
            Money first = new(2, 30);
            Console.WriteLine($"{first.Rubles} {first.Kopeks}");
            first.AddKopeks(69);
            Console.WriteLine($"{first.Rubles} {first.Kopeks}");
            ++first;
            Console.WriteLine($"{first.Rubles} {first.Kopeks}");
            --first;
            Console.WriteLine($"{first.Rubles} {first.Kopeks}");
            int i_first = (int)first;
            double d_first = first;
            Console.WriteLine($"{i_first} {d_first}");
            downWorkAreaIndex = Console.CursorTop;
        }

        private static void SolveSecondTask()
        {
            if (downWorkAreaIndex != menuStartIndex)
                ConsoleHandler.Cleaner.ClearRowsInRange(menu.downMenuIndex, downWorkAreaIndex);

            Console.Write("\nsecond task");
            downWorkAreaIndex = Console.CursorTop;
        }

        private static void SolveThirdTask()
        {
            if (downWorkAreaIndex != menuStartIndex)
                ConsoleHandler.Cleaner.ClearRowsInRange(menu.downMenuIndex, downWorkAreaIndex);
            
            Console.Write("\nthird task");
            downWorkAreaIndex = Console.CursorTop;
        }
    }
}