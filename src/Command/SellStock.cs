namespace PucRio.PSS.DesignPatterns.Command
{
    class SellStock : IOrder
    {
        public SellStock(Stock stock) => _stock = stock;

        public void Execute() => _stock.Sell();

        private readonly Stock _stock;
    }
}
