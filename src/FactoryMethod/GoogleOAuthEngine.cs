namespace PucRio.PSS.DesignPatterns.FactoryMethod
{
    class GoogleOAuthEngine : OAuthEngine
    {
        protected override IIdentityProvider FactoryMethod() => new GoogleIdentityProvider();
    }
}
