namespace PucRio.PSS.DesignPatterns.Bridge
{
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
