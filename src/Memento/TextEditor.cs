using System;

namespace PucRio.PSS.DesignPatterns.Memento
{
    /// <summary>
    /// Originator & CareTaker
    /// </summary>
    class TextEditor
    {
        public string Buffer
        {
            get
            {
                return _buffer;
            }
            set
            {
                Console.WriteLine("TEXT EDITOR: Setting value");

                _memento.Buffer = _buffer;
                _buffer = value;
            }
        }

        public void Undo()
        {
            Console.WriteLine("TEXT EDITOR: Undoing");

            var value = _buffer;
            _buffer = _memento.Buffer;
            _memento.Buffer = value;
        }

        private string _buffer;
        private readonly Memento _memento = new Memento();
    }
}
