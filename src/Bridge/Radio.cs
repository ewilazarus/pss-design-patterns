using System;

namespace PucRio.PSS.DesignPatterns.Bridge
{
    /// <summary>
    /// ConcreteImplementor
    /// </summary>
    class Radio : IDevice
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
                Console.WriteLine($"RADIO: power set to '{(_power ? "on" : "off")}'");
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
                Console.WriteLine($"RADIO: volume set to '{_volume}'");
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
                Console.WriteLine($"RADIO: channel set to '{_channel}'");
            }
        }

        private bool _power;
        private int _volume;
        private int _channel;
    }
}
