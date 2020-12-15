using System;

namespace Lab5.Classes.Systems
{
    //Радио. Имеет выход.
    class Tuner
    {
        private bool _working = false;        
        private object _audioOutput = null;

        //включение
        public void TurnOn()
        {
            _working = true;
            Console.WriteLine("Радио включено");
        }
        //выключение
        public void TurnOff()
        {
            _working = false;
            Console.WriteLine("Радио выключено");
        }
    }
}
