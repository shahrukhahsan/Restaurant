using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESEntity
{
    class Cart
    {
        public string ItemName { get; set; }
        public int UserId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
