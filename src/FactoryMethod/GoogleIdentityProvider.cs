namespace PucRio.PSS.DesignPatterns.FactoryMethod
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    class GoogleIdentityProvider : IIdentityProvider
    {
        public string Id => "G-1234";

        public string Name => "gvclima";
    }
}
