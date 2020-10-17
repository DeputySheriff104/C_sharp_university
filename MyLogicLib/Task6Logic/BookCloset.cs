using System.Collections.Generic;

namespace MyLogicLib.Task6Logic
{
    public class BookCloset : Closet
    {
        public int AmountOfBooks { get; set; }

        public int MaxAmountOfBooks { get; set; }

        public BookCloset(int ownedAmount, double volume, int shelvesAmount, int amountOfBooks, int maxAmountOfBooks)
        {
            OwnedAmount = ownedAmount;
            Volume = volume;
            ShelvesAmount = shelvesAmount;
            AmountOfBooks = amountOfBooks;
            MaxAmountOfBooks = maxAmountOfBooks;
        }

        public void AddBook()
        {
            if (AmountOfBooks < MaxAmountOfBooks)
            {
                AmountOfBooks++;
            }
        }
        
        public void RemoveBook()
        {
            if (AmountOfBooks > 0)
            {
                AmountOfBooks--;
            }
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