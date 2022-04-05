using System;
using System.Collections.Generic;
using System.Text;

namespace _6AprelTask
{
    internal class Order
    {
        static int _no;
        public int No { get;}
        public int ProductCount { get; set; }
        public double TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        public Order()
        {
            _no++;
            No = _no;
        }
    }
}
