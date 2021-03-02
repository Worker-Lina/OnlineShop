using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Service
{
    public interface UserService
    {
        public void Add()
        {
            var user = new User();
            Console.WriteLine("name: ");
            user.FullName = Console.ReadLine();
        }
    }
}
