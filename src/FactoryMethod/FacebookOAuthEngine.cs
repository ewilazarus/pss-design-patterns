namespace PucRio.PSS.DesignPatterns.FactoryMethod
{
    class FacebookOAuthEngine : OAuthEngine
    {
        protected override IIdentityProvider FactoryMethod() => new FacebookIdentityProvider();
    }
}
