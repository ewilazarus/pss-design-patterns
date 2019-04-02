namespace PucRio.PSS.DesignPatterns.FactoryMethod
{
    class RedditIdentityProvider : IIdentityProvider
    {
        public string Id => "/u/gabriel";

        public string Name => "GABRIEL";
    }
}
