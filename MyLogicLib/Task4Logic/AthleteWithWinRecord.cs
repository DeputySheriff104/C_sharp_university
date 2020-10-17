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
        
        public override double CalculateQuality()
        {
            if (HaveWonAtLeastOneTime)
            {
                return 1.5 * base.CalculateQuality();
            }
            return base.CalculateQuality();
        }

        public override string GetStringInfo()
        {
            return "Last name - " + LastName + "\n" +
                   "Amount of sport events - " + AmountOfSportEvents + "\n" +
                   "Sum of won places - " + SumOfWonPlaces + "\n" +
                   "Quality - " + GetQuality() + "\n" +
                   "Have won at least one time - " + HaveWonAtLeastOneTime + "\n";
        }
    }
}