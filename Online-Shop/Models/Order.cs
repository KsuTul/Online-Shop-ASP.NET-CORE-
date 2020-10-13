using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Price { get; set; }
        public DateTime OrderDate { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
    }
}
