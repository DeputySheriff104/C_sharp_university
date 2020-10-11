namespace MyLogicLib.Task4Logic
{
    public class Athlete
    {
        private string _lastName;
        private int _amountOfSportEvents;
        private int _sumOfWonPlaces;

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public int AmountOfSportEvents
        {
            get => _amountOfSportEvents;
            set => _amountOfSportEvents = value;
        }

        public int SumOfWonPlaces
        {
            get => _sumOfWonPlaces;
            set => _sumOfWonPlaces = value;
        }

        public Athlete(string lastName, int amountOfSportEvents, int sumOfWonPlaces)
        {
            _lastName = lastName;
            _amountOfSportEvents = amountOfSportEvents;
            _sumOfWonPlaces = sumOfWonPlaces;
        }

        public virtual double GetQuality()
        {
            return (double)_amountOfSportEvents / _sumOfWonPlaces;
        }
        
        public virtual string GetStringInfo()
        {
            return "Last name - " + _lastName + "\n" +
                   "Amount of sport events - " + _amountOfSportEvents + "\n" +
                   "Sum of won places - " + _sumOfWonPlaces + "\n" +
                   "Quality - " + GetQuality() + "\n";
        }
    }
}