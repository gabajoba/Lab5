using Lab5.Classes;
using Lab5.Classes.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amplifier = new Amplifier();
            CD cd = new CD();
            DVD dvd = new DVD();
            Popper popper = new Popper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            SoundSystem soundSystem = new SoundSystem();
            Tuner tuner = new Tuner();
            Control control = new Control(new HomeTheater1(popper,  screen, projector,  amplifier, soundSystem, dvd, cd, tuner));
            control.TurnOnDVD();

            Console.Read();
        }
    }
}
