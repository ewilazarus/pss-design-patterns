namespace PucRio.PSS.DesignPatterns.Bridge
{
    /// <summary>
    /// Abstraction
    /// </summary>
    interface IDeviceController
    {
        void TurnOn();

        void TurnOff();

        void VolumeUp();

        void VolumeDown();

        void ChannelUp();

        void ChannelDown();
    }
}
