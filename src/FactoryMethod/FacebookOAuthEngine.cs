namespace PucRio.PSS.DesignPatterns.FactoryMethod
{
    /// <summary>
    /// ConcreteCreator
    /// </summary>
    class FacebookOAuthEngine : OAuthEngine
    {
        protected override IIdentityProvider FactoryMethod() => new FacebookIdentityProvider();
    }
}
