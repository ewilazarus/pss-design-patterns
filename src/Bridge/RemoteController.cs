using System;

namespace PucRio.PSS.DesignPatterns.Bridge
{
    /// <summary>
    /// ConcreteAbstraction
    /// </summary>
    class RemoteController : IDeviceController
    {
        public RemoteController(IDevice device) => Device = device;

        public void TurnOn()
        {
            Console.WriteLine("REMOTE CONTROLLER: turn on");
            Device.Power = true;
        }

        public void TurnOff()
        {
            Console.WriteLine("REMOTE CONTROLLER: turn off");
            Device.Power = false;
        }

        public void VolumeUp()
        {
            Console.WriteLine("REMOTE CONTROLLER: volume up");
            Device.Volume++;
        }

        public void VolumeDown()
        {
            Console.WriteLine("REMOTE CONTROLLER: volume down");
            Device.Volume--;
        }

        public void ChannelUp()
        {
            Console.WriteLine("REMOTE CONTROLLER: channel up");
            Device.Channel++;
        }

        public void ChannelDown()
        {
            Console.WriteLine("REMOTE CONTROLLER: channel down");
            Device.Channel--;
        }

        protected readonly IDevice Device;
    }
}
