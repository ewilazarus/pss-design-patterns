namespace PucRio.PSS.DesignPatterns.FactoryMethod
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    class FacebookIdentityProvider : IIdentityProvider
    {
        public string Id => "fb87654321";

        public string Name => "gabriel.lima";
    }
}
