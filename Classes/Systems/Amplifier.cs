using System;

namespace Lab5.Classes.Systems
{
    //Усилитель звука. Имеет входы и выход.
    class Amplifier
    {
        private bool _working = false;
        private bool _ambientSoundMode;
        private object _input = null;
        private object _output = null;
        private int _volume;
        
        //включение
        public void TurnOn()
        {
            _working = true;
            Console.WriteLine("Усилитель включен");
        }
        //выключение
        public void TurnOff()
        {
            _working = false;
            Console.WriteLine("Усилитель выключен");
        }

        public Amplifier ConnectToDVD(DVD dvd)
        {
            this._input = dvd;
            dvd.SetAudioOutput(this);
            Console.WriteLine("Усилитель связан с выходом DVD");
            return this;
        }
        public void EnableAmbientSoundMode()
        {
            if (_working)
            {
                _ambientSoundMode = true;
                Console.WriteLine("Режим окружающего звука включен");
            }
            else
            {
                Console.WriteLine("Невозможно запустить Режим окружающего звука, так как усилитель выключен");
            }         
        }
        public void SetVolume(int volume)
        {
            if (volume > 10) _volume = 10;
            else if (volume < 0) _volume = 0;
            else _volume = volume;
            Console.WriteLine($"Установлена новая громкость усилителя => {_volume}");
        }
        
    }
}
