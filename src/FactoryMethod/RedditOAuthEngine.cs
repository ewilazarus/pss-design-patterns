namespace PucRio.PSS.DesignPatterns.FactoryMethod
{
    class RedditOAuthEngine : OAuthEngine
    {
        protected override IIdentityProvider FactoryMethod() => new RedditIdentityProvider();
    }
}
