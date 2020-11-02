namespace MyLogicLib.Task4Logic
{
    public class AthleteWithWinRecord : Athlete
    {
        public bool HaveWonAtLeastOneTime { get; set; }

        public AthleteWithWinRecord(
            string lastName, int amountOfSportEvents, 
            int sumOfWonPlaces, bool haveWonAtLeastOneTime)
            : base(lastName, amountOfSportEvents, sumOfWonPlaces)
        {
            HaveWonAtLeastOneTime = haveWonAtLeastOneTime;
        }

        protected override double CalculateQuality()
        {
            if (HaveWonAtLeastOneTime)
            {
                return 1.5 * base.CalculateQuality();
            }
            return base.CalculateQuality();
        }

        public override string GetStringInfo()
        {
            return base.GetStringInfo() +
                   "Have won at least one time - " + HaveWonAtLeastOneTime + "\n" + GetQuality();
        }
    }
}