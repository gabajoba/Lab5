using System;

namespace Lab5.Classes.Systems
{
    //CD-проигрыватель. Имеет выходы.
    class CD
    {
        private bool _working = false;
        private object _audioOutput = null;

        //включение
        public void TurnOn()
        {
            _working = true;
            Console.WriteLine("CD-проигрыватель включен");
        }
        //выключение
        public void TurnOff()
        {
            _working = false;
            Console.WriteLine("CD-проигрыватель выключен");
        }
        public void SetAudioOutput(object audioOutput)
        {
            _audioOutput = audioOutput;
        }
        public void DeleteAudioOutput()
        {
            _audioOutput = null;
        }
        public object GetAudioOutput()
        {
            return _audioOutput;
        }
    }
}
