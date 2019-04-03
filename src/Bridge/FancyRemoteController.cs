using System;

namespace PucRio.PSS.DesignPatterns.Bridge
{
    /// <summary>
    /// RefinedConcreteAbstraction
    /// </summary>
    class FancyRemoteController : RemoteController
    {
        public FancyRemoteController(IDevice device) : base(device) => _previousVolume = device.Volume;

        public void Mute()
        {
            Console.WriteLine("FANCY REMOTE CONTROLLER: mute");
            _previousVolume = Device.Volume;
            Device.Volume = 0;
        }

        public void UnMute()
        {
            Console.WriteLine("FANCY REMOTE CONTROLLER: unmute");
            Device.Volume = _previousVolume;
        }

        private int _previousVolume;
    }
}
