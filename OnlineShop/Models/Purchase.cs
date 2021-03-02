using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public ICollection<Product> Products { get; set; }
        public float Sum { get; set; }
        public DateTime Date { get; set; }
    }
}
