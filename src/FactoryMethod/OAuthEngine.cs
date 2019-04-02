using System;

namespace PucRio.PSS.DesignPatterns.FactoryMethod
{
    abstract class OAuthEngine
    {
        protected abstract IIdentityProvider FactoryMethod();

        public (string Id, string Name) GetUserInformation()
        {
            var identityProvider = FactoryMethod();

            var id = identityProvider.Id;
            var name = identityProvider.Name;

            Console.WriteLine($"GOT ID '{id}' AND NAME '{name}'");

            return (id, name);
        }
    }
}
