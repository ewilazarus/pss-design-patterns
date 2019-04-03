using System;

namespace PucRio.PSS.DesignPatterns.Memento
{
    /// <summary>
    /// Memento
    /// </summary>
    class Memento
    {
        public string Buffer
        {
            get
            {
                Console.WriteLine("MEMENTO: Getting state");
                return _buffer;
            }
            set
            {
                Console.WriteLine("MEMENTO: Setting state");
                _buffer = value;
            }
        }

        private string _buffer;
    }
}
