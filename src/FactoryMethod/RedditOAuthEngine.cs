namespace PucRio.PSS.DesignPatterns.FactoryMethod
{
    /// <summary>
    /// ConcreteCreator
    /// </summary>
    class RedditOAuthEngine : OAuthEngine
    {
        protected override IIdentityProvider FactoryMethod() => new RedditIdentityProvider();
    }
}
