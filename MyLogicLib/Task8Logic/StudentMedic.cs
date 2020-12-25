using System.Threading;

namespace MyLogicLib.Task8Logic
{
    internal class StudentMedic: IMedic
    {

        void IMedic.HealAthlete(Athlete athlete)
        {
            athlete.UpdateState(AthleteState.StudentHealing);
            Thread.Sleep(4000);
        }
    }
}