using System;
using System.Collections.Generic;
using System.Text;

namespace _6AprelTask
{
    internal class Shop
    {
        private List<Order> _orders= new List<Order>();

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }
        public double GetOrdersAvg()
        {
            double total = 0;
            foreach (var item in _orders)
            {
                total += item.TotalAmount;
                

            }
            total/=_orders.Count;
            return total;
            
        }
        public double GetOrdersAvg(DateTime date)
        {
            double total = 0;
            var result = _orders.FindAll(x => x.CreatedAt >= date);
            foreach (var item in result)
            {
                total += item.TotalAmount;
            }
            total /= result.Count;
            return total;
        }
        public void RemoveOrderByNo(int? no)
        {
            if (no == null)
            {
                throw new ArgumentNullException("Xeta!");
            }
            var result = _orders.Find(x=> x.No == no);
            if (result == null)
            {
                throw new ArgumentNullException("Xeta!");
            }
            _orders.Remove(result);
        }
        public List<Order> FilterOrderByPrice(double minPrice , double maxPrice)
        {
            return _orders.FindAll(x=> x.TotalAmount >= minPrice && x.TotalAmount <= maxPrice);
        }
    }
}
