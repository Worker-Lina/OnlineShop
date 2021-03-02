using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Service
{
    public class ConsoleMenuService
    {
        public void Print(string[] items)
        {
            Console.WriteLine("\n\n\n\t\t-----------Меню--------------");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"\t\t\t{i + 1}. {items[i]}");
            }
            Console.Write("\n\t -->");
        }
    }
}
