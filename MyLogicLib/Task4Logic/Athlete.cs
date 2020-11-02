namespace MyLogicLib.Task4Logic
{
    public class Athlete
    {
        public string LastName { get; set; }

        public int AmountOfSportEvents { get; set; }

        public int SumOfWonPlaces { get; set; }

        public Athlete(string lastName, int amountOfSportEvents, int sumOfWonPlaces)
        {
            LastName = lastName;
            AmountOfSportEvents = amountOfSportEvents;
            SumOfWonPlaces = sumOfWonPlaces;
        }

        protected double GetQuality()
        {
            return CalculateQuality();
        }

        protected virtual double CalculateQuality()
        {
            return (double)AmountOfSportEvents / SumOfWonPlaces;
        }
        
        public virtual string GetStringInfo()
        {
            return "Last name - " + LastName + "\n" +
                   "Amount of sport events - " + AmountOfSportEvents + "\n" +
                   "Sum of won places - " + SumOfWonPlaces + "\n" +
                   "Quality - " + GetQuality() + "\n";
        }
    }
}