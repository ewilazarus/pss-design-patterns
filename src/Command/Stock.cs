using System;

namespace PucRio.PSS.DesignPatterns.Command
{
    /// <summary>
    /// Receiver
    /// </summary>
    class Stock
    {
        public Stock(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void Buy() => Console.WriteLine($"{Name} bought");

        public void Sell() => Console.WriteLine($"{Name} sold");
    }
}
