namespace PucRio.PSS.DesignPatterns.FactoryMethod
{
    /// <summary>
    /// Product
    /// </summary>
    interface IIdentityProvider
    {
        string Id { get; }
        string Name { get; }
    }
}
