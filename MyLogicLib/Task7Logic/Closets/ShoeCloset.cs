using System.Collections.Generic;

namespace MyLogicLib.Task7Logic.Closets
{
    public class ShoesCloset : Closet
    {
        private int AmountOfShoes { get; set; }

        private int MaxAmountOfShoes { get; set; }

        public ShoesCloset(int ownedAmount, double volume, int shelvesAmount, int amountOfShoes, int maxAmountOfShoes)
        {
            OwnedAmount = ownedAmount;
            Volume = volume;
            ShelvesAmount = shelvesAmount;
            AmountOfShoes = amountOfShoes;
            MaxAmountOfShoes = maxAmountOfShoes;
        }

        public string AddShoe()
        {
            if (AmountOfShoes < MaxAmountOfShoes)
            {
                AmountOfShoes++;
            }

            return GetTextInfo();
        }

        public string RemoveShoe()
        {
            if (AmountOfShoes > 0)
            {
                AmountOfShoes--;
            }

            return GetTextInfo();
        }

        public override string GetTextInfo()
        {
            return base.GetTextInfo() +
                   "Amount of shoes - " + AmountOfShoes + "\n" +
                   "Max amount of shoes - " + MaxAmountOfShoes + "\n";
        }

        public static string GetTextInfoForList(List<IFurniture> shoeClosets)
        {
            string output = "";
            for (int i = 0; i < shoeClosets.Count; i++)
            {
                output += "INDEX " + i + "\n" + shoeClosets[i].GetTextInfo() + "\n";
            }

            return output;
        }
    }
}