namespace PucRio.PSS.DesignPatterns.Bridge
{
    interface IDevice
    {
        bool Power { get; set; }

        int Volume { get; set; }

        int Channel { get; set; }
    }
}
