namespace MyLogicLib.Task4Logic
{
    public class AthleteWithWinRecord : Athlete
    {
        public bool HaveWonAtLeastOneTime
        {
            get;
            set;
        }

        public AthleteWithWinRecord(
            string lastName, int amountOfSportEvents, 
            int sumOfWonPlaces, bool haveWonAtLeastOneTime)
            : base(lastName, amountOfSportEvents, sumOfWonPlaces)
        {
            HaveWonAtLeastOneTime = haveWonAtLeastOneTime;
        }

        public override double GetQuality()
        {
            if (HaveWonAtLeastOneTime)
            {
                return 1.5 * base.GetQuality();
            }
            return base.GetQuality();
        }

        public override string GetStringInfo()
        {
            return base.GetStringInfo() + 
                   "Have won at least one time - " + HaveWonAtLeastOneTime + "\n";
        }
    }
}