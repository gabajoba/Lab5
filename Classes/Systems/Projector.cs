using System;

namespace Lab5.Classes.Systems
{
    //Проектор. Имеет вход.
    class Projector
    {
        private bool _working;
        private bool _fullScreenMode;
        private object _input;
        //включение
        public void TurnOn()
        {
            _working = true;
            Console.WriteLine("Проектор включен");
        }
        //выключение
        public void TurnOff()
        {
            _working = false;
            Console.WriteLine("Проектор выключен");
        }

        //подключение к DVD
        public void ConnectToDVD(DVD dvd)
        {
            this._input = dvd;
            dvd.SetVideoOutput(this);
            Console.WriteLine("Проектор связан с видеовыходом DVD");
        }
        public void DisconnectFromDVD()
        {
            (_input as DVD).SetVideoOutput(null);
            _input = null;            
            Console.WriteLine("Проектор отсоединен от DVD");
        }

        //Включение полноэкранного режима
        public void EnableFullScreenMode()
        {
            if (_working)
            {
                _fullScreenMode = true;
                Console.WriteLine("Полноэкранный режим включен");
            }
            else
            {
                Console.WriteLine("Невозможно включить полноэкранный режим, так как проектор не запущен");
            }
            
        }
        //Выключение полноэкранного режима
        public void DisableFullScreenMode()
        {
            if (_working)
            {
                _fullScreenMode = true;
                Console.WriteLine("Полноэкранный режим выключен");
            }
            else
            {
                Console.WriteLine("Невозможно выключить полноэкранный режим, так как проектор не включен");
            }
        }
    }
}
