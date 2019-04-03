namespace PucRio.PSS.DesignPatterns.FactoryMethod
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    class RedditIdentityProvider : IIdentityProvider
    {
        public string Id => "/u/gabriel";

        public string Name => "GABRIEL";
    }
}
