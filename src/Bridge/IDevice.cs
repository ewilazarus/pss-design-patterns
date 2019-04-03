namespace PucRio.PSS.DesignPatterns.Bridge
{
    /// <summary>
    /// Implementor
    /// </summary>
    interface IDevice
    {
        bool Power { get; set; }

        int Volume { get; set; }

        int Channel { get; set; }
    }
}
