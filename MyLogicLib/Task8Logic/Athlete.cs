using System;
using System.Threading;
using MyLogicLib.Task8Logic.Utils;

namespace MyLogicLib.Task8Logic
{
    public class Athlete
    {
        internal delegate void StartHandler(Athlete caller);

        internal delegate void HealHandler(Athlete caller);

        internal delegate void UpdateHandler(Athlete caller, AthleteState state);

        internal AthleteState State { get;  private set; } = AthleteState.Ready;
        
        internal double InjureChance { get; set; } = 0.3;

        internal bool CanContinue { get; set; } = true;

        internal event StartHandler StartCompetition;

        internal event HealHandler Heal;

        internal event UpdateHandler Update;
        
        private AthleteState LastStage { get; set; }
        
        private CustomRandom Random { get; set; } = new CustomRandom();

        private AthleteState NextState
        {
            get
            {
                return State switch
                {
                    AthleteState.Ready => AthleteState.Start,
                    AthleteState.Start => AthleteState.Stage1,
                    AthleteState.Stage1 => Random.IsHappened(InjureChance) ? AthleteState.Injured : AthleteState.Stage2,
                    AthleteState.Stage2 => Random.IsHappened(InjureChance) ? AthleteState.Injured : AthleteState.Stage3,
                    AthleteState.Stage3 => Random.IsHappened(InjureChance) ? AthleteState.Injured : AthleteState.Stage4,
                    AthleteState.Stage4 => Random.IsHappened(InjureChance) ? AthleteState.Injured : AthleteState.Stage5,
                    AthleteState.Stage5 => AthleteState.Finish,
                    AthleteState.Finish => AthleteState.Ready,
                    AthleteState.Injured => AthleteState.MasterHealing,
                    AthleteState.MasterHealing => LastStage,
                    AthleteState.StudentHealing => LastStage,
                    _ => throw new ArgumentException("Unknown athlete state")
                };
            }
        }

        internal void Compete(Random random)
        {
            Random.Generator = random;
            while (CanContinue)
            {
                var next = NextState;
                if (next == AthleteState.Injured)
                {
                    LastStage = State;
                }
                UpdateState(next);
                Thread.Sleep(1000);
                if (State == AthleteState.Ready)
                {
                    StartCompetition?.Invoke(this);
                } 
                else if (State == AthleteState.Injured)
                {
                    Heal?.Invoke(this);
                }
            }
        }

        internal void UpdateState(AthleteState nextState)
        {
            State = nextState;
            Update?.Invoke(this, State);
        }

    }
}