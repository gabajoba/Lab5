using System;

namespace Lab5.Classes.Systems
{
    //Акустика
    class SoundSystem
    {
        private bool _working = false;

        //включение
        public void TurnOn()
        {
            _working = true;
            Console.WriteLine("Акустическая система включена");
        }
        //выключение
        public void TurnOff()
        {
            _working = false;
            Console.WriteLine("Акустическая система выключена");
        }
    }
}
