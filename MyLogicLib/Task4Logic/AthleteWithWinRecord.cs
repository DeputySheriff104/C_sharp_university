namespace MyLogicLib.Task4Logic
{
    public class AthleteWithWinRecord : Athlete
    {
        private bool _haveWonAtLeastOneTime;

        public bool HaveWonAtLeastOneTime
        {
            get => _haveWonAtLeastOneTime;
            set => _haveWonAtLeastOneTime = value;
        }

        public AthleteWithWinRecord(
            string lastName, int amountOfSportEvents, 
            int sumOfWonPlaces, bool haveWonAtLeastOneTime)
            : base(lastName, amountOfSportEvents, sumOfWonPlaces)
        {
            _haveWonAtLeastOneTime = haveWonAtLeastOneTime;
        }

        public override double GetQuality()
        {
            if (_haveWonAtLeastOneTime)
            {
                return 1.5 * base.GetQuality();
            }
            return base.GetQuality();
        }

        public override string GetStringInfo()
        {
            return base.GetStringInfo() + 
                   "Have won at least one time - " + _haveWonAtLeastOneTime + "\n";
        }
    }
}