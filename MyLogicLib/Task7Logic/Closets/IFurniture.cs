namespace MyLogicLib.Task7Logic.Closets
{
    public interface IFurniture
    {
        int OwnedAmount { get; set; }

        string Buy();

        string Sell();

        string GetTextInfo();
    }
}