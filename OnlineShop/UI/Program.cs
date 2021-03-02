using OnlineShop.Data;
using OnlineShop.Models;
using OnlineShop.Service;
using System;

namespace OnlineShop.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            InitConfiguration();

            string[] items = { "Войти", "Зарегистрироваться" };

            var menu = new ConsoleMenuService();
            string choice;
            do
            {
                Console.Clear();
                menu.Print(items);
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        {

                        }break;
                    case "2":
                        {
                            var smsRegistration = new SmsRegistrationService();
                            var userDataAccess = new UserDataAccess();

                            Console.WriteLine("Введите номер");
                            string phone = Console.ReadLine();
                            if (smsRegistration.Registration(phone))
                            {
                                var user = new User();
                                Console.WriteLine("name: ");
                                user.FullName = Console.ReadLine();
                                user.Phone = phone;
                                userDataAccess.Insert(user);
                            }
                        }break;

                }
            } while (choice != "3");
        }

        private static void InitConfiguration()
        {
            ConfigurationService.Init();
        }
    }
}
