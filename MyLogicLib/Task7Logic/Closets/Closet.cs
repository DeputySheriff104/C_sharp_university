namespace MyLogicLib.Task7Logic.Closets
{
    public abstract class Closet : IFurniture
    {
        public int OwnedAmount { get; set; }

        protected double Volume { get; set; }

        protected int ShelvesAmount { get; set; }

        public string Buy()
        {
            OwnedAmount++;
            return GetTextInfo();
        }

        public string Sell()
        {
            if (OwnedAmount > 0)
            {
                OwnedAmount--;
            }
            return GetTextInfo();
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