namespace PucRio.PSS.DesignPatterns.Command
{
    /// <summary>
    /// ConcreteCommand
    /// </summary>
    class BuyStock : IOrder
    {
        public BuyStock(Stock stock) => _stock = stock;

        public void Execute() => _stock.Buy();

        private readonly Stock _stock;
    }
}
