using System.Collections.Generic;

namespace MyLogicLib.Task7Logic.Closets
{
    public class DishesCloset : Closet
    {
        private int AmountOfDishes { get; set; }

        private int MaxAmountOfDishes { get; set; }

        public DishesCloset(int ownedAmount, double volume, int shelvesAmount, int amountOfDishes, int maxAmountOfDishes)
        {
            OwnedAmount = ownedAmount;
            Volume = volume;
            ShelvesAmount = shelvesAmount;
            AmountOfDishes = amountOfDishes;
            MaxAmountOfDishes = maxAmountOfDishes;
        }

        public string AddDish()
        {
            if (AmountOfDishes < MaxAmountOfDishes)
            {
                AmountOfDishes++;
            }

            return GetTextInfo();
        }

        public string RemoveDish()
        {
            if (AmountOfDishes > 0)
            {
                AmountOfDishes--;
            }

            return GetTextInfo();
        }

        public override string GetTextInfo()
        {
            return base.GetTextInfo() +
                   "Amount of dishes - " + AmountOfDishes + "\n" +
                   "Max amount of dishes - " + MaxAmountOfDishes + "\n";
        }

        public static string GetTextInfoForList(List<IFurniture> dishClosets)
        {
            string output = "";
            for (int i = 0; i < dishClosets.Count; i++)
            {
                output += "INDEX " + i + "\n" + dishClosets[i].GetTextInfo() + "\n";
            }

            return output;
        }
    }
}