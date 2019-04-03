namespace PucRio.PSS.DesignPatterns.Command
{
    /// <summary>
    /// ConcreteCommand
    /// </summary>
    class SellStock : IOrder
    {
        public SellStock(Stock stock) => _stock = stock;

        public void Execute() => _stock.Sell();

        private readonly Stock _stock;
    }
}
