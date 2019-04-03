using System;
using System.Collections.Generic;

namespace PucRio.PSS.DesignPatterns.Command
{
    /// <summary>
    /// Invoker
    /// </summary>
    class Broker
    {
        private readonly List<IOrder> _orders = new List<IOrder>();

        public void TakeOrder(IOrder order)
        {
            Console.WriteLine("BROKER: Taking order");

            _orders.Add(order);
        }

        public void PlaceOrders()
        {
            Console.WriteLine("BROKER: Placing orders");

            foreach (var order in _orders)
            {
                order.Execute();
            }

            _orders.Clear();
        }
    }
}
