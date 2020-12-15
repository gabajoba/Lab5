using System;

namespace Lab5.Classes.Systems
{
    //Автоматизированный экран
    class Screen
    {
        private bool _working = false;

        //включение
        public void TurnOn()
        {
            _working = true;
            Console.WriteLine("Автоматизированный экран включен");
        }
        //выключение
        public void TurnOff()
        {
            _working = false;
            Console.WriteLine("Автоматизированный экран выключен");
        }
        public void LowerScreen()
        {
            Console.WriteLine("Экран опущен");
        }
    }
}
