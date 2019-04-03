using System;

namespace PucRio.PSS.DesignPatterns.Bridge
{
    /// <summary>
    /// ConcreteImplementor
    /// </summary>
    class Television : IDevice
    {
        public bool Power
        {
            get
            {
                return _power;
            }
            set
            {
                _power = value;
                Console.WriteLine($"TELEVISION: power set to '{(_power ? "on" : "off")}'");
            }
        }

        public int Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                _volume = Math.Min(100, Math.Max(0, value));
                Console.WriteLine($"TELEVISION: volume set to '{_volume}'");
            }
        }

        public int Channel
        {
            get
            {
                return _channel;
            }
            set
            {
                _channel = value;
                Console.WriteLine($"TELEVISION: channel set to '{_channel}'");
            }
        }

        private bool _power;
        private int _volume;
        private int _channel;
    }
}
