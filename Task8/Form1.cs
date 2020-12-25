using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MyLogicLib.Task8Logic;
using Timer = System.Windows.Forms.Timer;

namespace Task8
{
    public partial class Form1 : Form
    {
        private Competition Competition1 { get; } = new Competition();
        private Competition Competition2 { get; } = new Competition();
        
        private readonly Timer _timer = new Timer();

        private AthleteState CurrentState1 { get; set; }
        
        private AthleteState CurrentState2 { get; set; }
        
        private Image runningAthlete = Image.FromFile("C:\\Users\\Vlad\\RiderProjects\\resources\\RunningAthlete.png");
        private Image startAthlete = Image.FromFile("C:\\Users\\Vlad\\RiderProjects\\resources\\StartAthlete.png");
        private Image finishAthlete = Image.FromFile("C:\\Users\\Vlad\\RiderProjects\\resources\\FinishAthlete.png");
        private Image injuredAthlete = Image.FromFile("C:\\Users\\Vlad\\RiderProjects\\resources\\InjuredAthlete.png");
        private Image masterMedic = Image.FromFile("C:\\Users\\Vlad\\RiderProjects\\resources\\MasterMedic.png");
        private Image studentMedic = Image.FromFile("C:\\Users\\Vlad\\RiderProjects\\resources\\StudentMedic.png");

        private int _x1 = 10;
        private int _y1 = 250;
        private int _x2 = 10;
        private int _y2 = 50;
        private bool _wasHealed1 = false;
        private bool _wasHealed2 = false;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            _timer.Enabled = true;
            _timer.Interval = 1000;
            _timer.Tick += TimerCallback;
            Competition1.StartAthlete(random);
            Competition1.UpdateView += UpdateState1;
            Competition2.StartAthlete(random);
            Competition2.UpdateView += UpdateState2;
        }
        
        private void TimerCallback(object sender, EventArgs e)
        {
            Invalidate();
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            PaintGround(g);
            switch (CurrentState1)
            {
                case AthleteState.Ready:
                    break;
                case AthleteState.Start:
                    PaintStartAthlete(g, _x1, _y1);
                    break;
                case AthleteState.Stage1:
                    if (!_wasHealed1) _x1 += 100;
                    PaintRunningAthlete(g, _x1, _y1);
                    _wasHealed1 = false;
                    break;
                case AthleteState.Stage2:
                    if (!_wasHealed1) _x1 += 100;
                    PaintRunningAthlete(g, _x1, _y1);
                    _wasHealed1 = false;
                    break;
                case AthleteState.Stage3:
                    if (!_wasHealed1) _x1 += 100;
                    PaintRunningAthlete(g, _x1, _y1);
                    _wasHealed1 = false;
                    break;
                case AthleteState.Stage4:
                    if (!_wasHealed1) _x1 += 100;
                    PaintRunningAthlete(g, _x1, _y1);
                    _wasHealed1 = false;
                    break;
                case AthleteState.Stage5:
                    if (!_wasHealed1) _x1 += 100;
                    PaintRunningAthlete(g, _x1, _y1);
                    _wasHealed1 = false;
                    break;
                case AthleteState.Finish:
                    PaintFinishAthlete(g, _x1, _y1);
                    _wasHealed1 = false;
                    _x1 -= 500;
                    break;
                case AthleteState.Injured:
                    PaintInjuredAthlete(g, _x1, _y1);
                    break;
                case AthleteState.MasterHealing:
                    _wasHealed1 = true;
                    PaintInjuredAthlete(g, _x1, _y1);
                    PaintMasterMedic(g, _x1, _y1);
                    break;
                case AthleteState.StudentHealing:
                    _wasHealed1 = true;
                    PaintInjuredAthlete(g, _x1, _y1);
                    PaintStudentMedic(g, _x1, _y1);
                    break;
            }
            switch (CurrentState2)
            {
                case AthleteState.Ready:
                    break;
                case AthleteState.Start:
                    PaintStartAthlete(g, _x2, _y2);
                    break;
                case AthleteState.Stage1:
                    if (!_wasHealed2) _x2 += 100;
                    PaintRunningAthlete(g, _x2, _y2);
                    _wasHealed2 = false;
                    break;
                case AthleteState.Stage2:
                    if (!_wasHealed2) _x2 += 100;
                    PaintRunningAthlete(g, _x2, _y2);
                    _wasHealed2 = false;
                    break;
                case AthleteState.Stage3:
                    if (!_wasHealed2) _x2 += 100;
                    PaintRunningAthlete(g, _x2, _y2);
                    _wasHealed2 = false;
                    break;
                case AthleteState.Stage4:
                    if (!_wasHealed2) _x2 += 100;
                    PaintRunningAthlete(g, _x2, _y2);
                    _wasHealed2 = false;
                    break;
                case AthleteState.Stage5:
                    if (!_wasHealed2) _x2 += 100;
                    PaintRunningAthlete(g, _x2, _y2);
                    _wasHealed2 = false;
                    break;
                case AthleteState.Finish:
                    PaintFinishAthlete(g, _x2, _y2);
                    _wasHealed2 = false;
                    _x2 -= 500;
                    break;
                case AthleteState.Injured:
                    PaintInjuredAthlete(g, _x2, _y2);
                    break;
                case AthleteState.MasterHealing:
                    _wasHealed2 = true;
                    PaintInjuredAthlete(g, _x2, _y2);
                    PaintMasterMedic(g, _x2, _y2);
                    break;
                case AthleteState.StudentHealing:
                    _wasHealed2 = true;
                    PaintInjuredAthlete(g, _x2, _y2);
                    PaintStudentMedic(g, _x2, _y2);
                    break;
            }
            base.OnPaint(e);
        }

        private void UpdateState1(AthleteState state)
        {
            switch (state)
            {
                case AthleteState.Ready:
                    CurrentState1 = AthleteState.Ready;
                    break;
                case AthleteState.Start:
                    CurrentState1 = AthleteState.Start;
                    break;
                case AthleteState.Stage1:
                    CurrentState1 = AthleteState.Stage1;
                    break;
                case AthleteState.Stage2:
                    CurrentState1 = AthleteState.Stage2;
                    break;
                case AthleteState.Stage3:
                    CurrentState1 = AthleteState.Stage3;
                    break;
                case AthleteState.Stage4:
                    CurrentState1 = AthleteState.Stage4;
                    break;
                case AthleteState.Stage5:
                    CurrentState1 = AthleteState.Stage5;
                    break;
                case AthleteState.Finish:
                    CurrentState1 = AthleteState.Finish;
                    break;
                case AthleteState.Injured:
                    CurrentState1 = AthleteState.Injured;
                    break;
                case AthleteState.MasterHealing:
                    CurrentState1 = AthleteState.MasterHealing;
                    break;
                case AthleteState.StudentHealing:
                    CurrentState1 = AthleteState.StudentHealing;
                    break;
            }
        }
        
        private void UpdateState2(AthleteState state)
        {
            switch (state)
            {
                case AthleteState.Ready:
                    CurrentState2 = AthleteState.Ready;
                    break;
                case AthleteState.Start:
                    CurrentState2 = AthleteState.Start;
                    break;
                case AthleteState.Stage1:
                    CurrentState2 = AthleteState.Stage1;
                    break;
                case AthleteState.Stage2:
                    CurrentState2 = AthleteState.Stage2;
                    break;
                case AthleteState.Stage3:
                    CurrentState2 = AthleteState.Stage3;
                    break;
                case AthleteState.Stage4:
                    CurrentState2 = AthleteState.Stage4;
                    break;
                case AthleteState.Stage5:
                    CurrentState2 = AthleteState.Stage5;
                    break;
                case AthleteState.Finish:
                    CurrentState2 = AthleteState.Finish;
                    break;
                case AthleteState.Injured:
                    CurrentState2 = AthleteState.Injured;
                    break;
                case AthleteState.MasterHealing:
                    CurrentState2 = AthleteState.MasterHealing;
                    break;
                case AthleteState.StudentHealing:
                    CurrentState2 = AthleteState.StudentHealing;
                    break;
            }
        }

        private void PaintGround(Graphics g)
        {
            g.DrawLine(Pens.Black, 0, 350, 1000, 350);
            g.DrawLine(Pens.Black, 0, 150, 1000, 150);
        }

        private void PaintRunningAthlete(Graphics g, int x, int y)
        {
            var destRect = new Rectangle(x, y, 100, 100);
            g.DrawImage(runningAthlete, destRect, 0, 0, 1167.0F, 1280.0F, GraphicsUnit.Pixel);
        }
        
        private void PaintStartAthlete(Graphics g, int x, int y)
        {
            var destRect = new Rectangle(x, y, 100, 100);
            g.DrawImage(startAthlete, destRect, 0, 0, 183.0F, 512.0F, GraphicsUnit.Pixel);
        }
        
        private void PaintFinishAthlete(Graphics g, int x, int y)
        {
            var destRect = new Rectangle(x, y, 100, 100);
            g.DrawImage(finishAthlete, destRect, 0, 0, 512.0F, 512.0F, GraphicsUnit.Pixel);
        }
        
        private void PaintInjuredAthlete(Graphics g, int x, int y)
        {
            var destRect = new Rectangle(x, y, 100, 100);
            g.DrawImage(injuredAthlete, destRect, 0, 0, 512.0F, 405.0F, GraphicsUnit.Pixel);
        }
        
        private void PaintMasterMedic(Graphics g, int x, int y)
        {
            var destRect = new Rectangle(x+100, y, 100, 100);
            g.DrawImage(masterMedic, destRect, 0, 0, 300.0F, 410.0F, GraphicsUnit.Pixel);
        }
        
        private void PaintStudentMedic(Graphics g, int x, int y)
        {
            var destRect = new Rectangle(x+100, y, 100, 100);
            g.DrawImage(studentMedic, destRect, 0, 0, 512.0F, 512.0F, GraphicsUnit.Pixel);
        }
    }
}