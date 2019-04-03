namespace PucRio.PSS.DesignPatterns.FactoryMethod
{
    /// <summary>
    /// ConcreteCreator
    /// </summary>
    class GoogleOAuthEngine : OAuthEngine
    {
        protected override IIdentityProvider FactoryMethod() => new GoogleIdentityProvider();
    }
}
