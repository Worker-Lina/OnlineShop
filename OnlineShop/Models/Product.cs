using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }
        public string Country { get; set; }
        public int Raiting { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
