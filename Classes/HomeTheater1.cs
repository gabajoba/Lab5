using Lab5.Classes.Systems;
using Lab5.Interfaces;
using System;

namespace Lab5.Classes
{
    class HomeTheater1 : IHomeTheater
    {
        private Popper _popper;
        private Screen _screen;
        private Projector _projector;
        private Amplifier _amplifier;
        private SoundSystem _soundSystem;
        private DVD _dvd;
        private CD _cd;
        private Tuner _tuner;
        
        public HomeTheater1(Popper popper, Screen screen, Projector projector,Amplifier amplifier, SoundSystem soundSystem, DVD dvd, CD cd, Tuner tuner)
        {
            _popper = popper;
            _screen = screen;
            _projector = projector;
            _amplifier = amplifier;
            _soundSystem = soundSystem;
            _dvd = dvd;
            _cd = cd;
            _tuner = tuner;   
        }
        public void TurnOnDVD()
        {
            _popper?.TurnOn();
            _popper?.MakePopcorn();
            _screen?.TurnOn();
            _screen?.LowerScreen();
            _projector?.TurnOn();
            _projector?.ConnectToDVD(_dvd);        
            _projector?.EnableFullScreenMode();
            _amplifier?.TurnOn();
            _amplifier?.ConnectToDVD(_dvd);
            _amplifier?.EnableAmbientSoundMode();
            _amplifier?.SetVolume(5);
            _dvd?.TurnOn();
            _dvd?.EnablePlayback();           
        }
        public void TurnOffDVD()
        {
        }
        public void TurnOnCD()
        {
        }
        public void TurnOffCD()
        {
        }
        public void TurnOnRadio()
        {
        }
        public void TurnOffRadio()
        {
        }

    }
}
