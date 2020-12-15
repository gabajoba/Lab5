using Lab5.Interfaces;

namespace Lab5.Classes
{
    class Control
    {
        private IHomeTheater _theater;
        public Control(IHomeTheater homeTheater)
        {
            _theater = homeTheater;
        }
        public void TurnOnDVD() 
        {
            _theater?.TurnOnDVD();
        }
        public void TurnOffDVD()
        {
            _theater?.TurnOffDVD();
        }
        public void TurnOnCD()
        {
            _theater?.TurnOnCD();
        }
        public void TurnOffCD()
        {
            _theater?.TurnOffCD();
        }
        public void TurnOnRadio(string fm)
        {
            _theater?.TurnOnRadio();
        }
        public void TurnOffRadio()
        {
            _theater?.TurnOffRadio();
        }

    }
}
