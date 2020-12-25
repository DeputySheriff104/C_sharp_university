using System.Threading;

namespace MyLogicLib.Task8Logic
{
    internal class MasterMedic: IMedic
    {

        void IMedic.HealAthlete(Athlete athlete)
        {
            athlete.UpdateState(AthleteState.MasterHealing);
            Thread.Sleep(2000);
        }
    }
}