using System;
using System.Threading.Tasks;
using MyLogicLib.Task8Logic.Utils;

namespace MyLogicLib.Task8Logic
{
    public class Competition
    {
        public delegate void ViewUpdateHandler(AthleteState state);

        public event ViewUpdateHandler UpdateView;

        private Athlete MainAthlete { get; } = new Athlete();

        private Track StartTrack { get; } = new Track();
        
        private IMedic MasterMedic { get; } = new MasterMedic();
        
        private IMedic StudentMedic { get; } = new StudentMedic();

        public async void StartAthlete(Random random)
        {
            MainAthlete.Update += HandleUpdate;
            MainAthlete.StartCompetition += HandleReady;
            MainAthlete.Heal += HandleHeal;
            await Task.Run(() => MainAthlete.Compete(random));
        }

        private void HandleUpdate(Athlete caller, AthleteState state)
        {
            UpdateView?.Invoke(state);
        }
        
        private void HandleReady(Athlete caller)
        {
            StartTrack.StartAthlete(caller);
        }
        
        private void HandleHeal(Athlete caller)
        {
            CustomRandom random = new CustomRandom();
            random.Generator = new Random();
            if (random.IsHappened(0.5))
            {
                MasterMedic.HealAthlete(caller);
            } else
            {
                StudentMedic.HealAthlete(caller);
            }
        }
    }
}