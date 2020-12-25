using System;

namespace MyLogicLib.Task8Logic.Utils
{
    internal class CustomRandom

    {
        internal Random Generator { get; set; }
        
        internal bool IsHappened(double probability)
        {
            return Generator.Next(1000) < Math.Round(1000 * probability);
        }
    }
}