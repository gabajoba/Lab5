using System;

namespace Lab5.Classes.Systems
{
    //Аппарат для попкорна
    class Popper
    {
        private bool _working = false;
        private bool _cooking = false;
        //включение
        public void TurnOn()
        {
            _working = true;
            Console.WriteLine("Аппарат для попкорна включен");
        }
        //выключение
        public void TurnOff()
        {
            _working = false;
            Console.WriteLine("Аппарат для попкорна выключен");
        }
        public void MakePopcorn()
        {
            if (_working)
            {
                _cooking = true;
                Console.WriteLine("Запущено приготовление попкорна");
            } else
            {
                Console.WriteLine("Невозможно запустить приготовление попкорна, так как аппарат не включен");
            }
         
        }
    }
}
