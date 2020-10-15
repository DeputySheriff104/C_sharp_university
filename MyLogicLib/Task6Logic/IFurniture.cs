namespace MyLogicLib.Task6Logic
{
    public interface IFurniture
    {
        int OwnedAmount
        {
            get;
            set;
        }

        void Buy();

        void Sell();

        string GetTextInfo();
    }
}