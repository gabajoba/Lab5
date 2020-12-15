using System;

namespace Lab5.Classes.Systems
{
    //DVD-проигрыватель. Имеет выходы.

    class DVD
    {
        private bool _working = false;
        private object _videoOutput = null;
        private object _audioOutput = null;
        private bool _playback;

        //включение
        public void TurnOn()
        {
            _working = true;
            Console.WriteLine("DVD-проигрыватель включен");
        }
        //выключение
        public void TurnOff()
        {
            _working = false;
            Console.WriteLine("DVD-проигрыватель выключен");
        }
        public void SetAudioOutput(object audioOutput)
        {
            _audioOutput = audioOutput;
        }
        public void DeleteAudioOutput()
        {
            _audioOutput = null;
        }
        public void SetVideoOutput(object videoOutput)
        {
            _videoOutput = videoOutput;
        }
        public void DeleteVideoOutput()
        {
            _videoOutput = null;
        }
        public object GetAudioOutput()
        {
            return _audioOutput;
        }
        public object GetVideoOutput()
        {
            return _videoOutput;
        }
        public void EnablePlayback()
        {
            _playback = true;
            Console.WriteLine("Воспроизведение DVD включено");
        }
    }
}
