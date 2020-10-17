namespace MyLogicLib.Task6Logic
{
    public abstract class Closet : IFurniture
    {
        public int OwnedAmount { get; set; }
        
        public double Volume { get; set; }

        public int ShelvesAmount { get; set; }

        public void Buy()
        {
            OwnedAmount++;
        }

        public void Sell()
        {
            if (OwnedAmount > 0)
            {
                OwnedAmount--;
            }
        }

        public virtual string GetTextInfo()
        {
            return "Owned amount - " + OwnedAmount + "\n" +
                   "Volume - " + Volume + "\n" +
                   "Shelves amount - " + ShelvesAmount + "\n" +
                   "Volume for shelf - " + GetVolumeForShelf() + "\n";
        }

        public double GetVolumeForShelf()
        {
            return Volume / ShelvesAmount;
        }
        
    }
}