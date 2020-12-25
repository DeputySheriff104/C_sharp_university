using System.Threading;

namespace MyLogicLib.Task8Logic
{
    internal class Track
    {
        internal void StartAthlete(Athlete athlete)
        {
            athlete.UpdateState(AthleteState.Start);
            Thread.Sleep(1000);
        }
    }
}