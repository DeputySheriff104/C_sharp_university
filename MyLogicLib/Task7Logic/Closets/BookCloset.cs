using System.Collections.Generic;

namespace MyLogicLib.Task7Logic.Closets
{
    public class BookCloset : Closet
    {
        private int AmountOfBooks { get; set; }

        private int MaxAmountOfBooks { get; set; }

        public BookCloset(int ownedAmount, double volume, int shelvesAmount, int amountOfBooks, int maxAmountOfBooks)
        {
            OwnedAmount = ownedAmount;
            Volume = volume;
            ShelvesAmount = shelvesAmount;
            AmountOfBooks = amountOfBooks;
            MaxAmountOfBooks = maxAmountOfBooks;
        }

        public string AddBook()
        {
            if (AmountOfBooks < MaxAmountOfBooks)
            {
                AmountOfBooks++;
            }
            return GetTextInfo();
        }
        
        public string RemoveBook()
        {
            if (AmountOfBooks > 0)
            {
                AmountOfBooks--;
            }
            return GetTextInfo();
        }

        public override string GetTextInfo()
        {
            return base.GetTextInfo() +
                   "Amount of books - " + AmountOfBooks + "\n" +
                   "Max amount of books - " + MaxAmountOfBooks + "\n";
        }

        public static string GetTextInfoForList(List<IFurniture> bookClosets)
        {
            string output = "";
            for (int i = 0; i < bookClosets.Count; i++)
            {
                output += "INDEX " + i + "\n" + bookClosets[i].GetTextInfo() + "\n";
            }
            return output;
        }
    }
}