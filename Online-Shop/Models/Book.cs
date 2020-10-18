using System;
using System.Collections;
using System.Collections.Generic;

namespace Online_Shop.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
