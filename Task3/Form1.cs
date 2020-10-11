using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLogicLib.Task3Logic;


namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void drawButton_Click(object sender, EventArgs e)
        {
            try
            {
                Graphics g = drawPanel.CreateGraphics();
                g.Clear(Color.White);
                Pen blackPen = new Pen(Color.Black, 3);
                Brush redBrush = new SolidBrush(Color.Red);
                if (AreAllDrawParamsNotEmpty())
                {
                    int radius = Convert.ToInt32(radiusCircleInputTextBox.Text);
                    int xCircle = Convert.ToInt32(xCircleInputTextBox.Text);
                    int yCircle = Convert.ToInt32(yCircleInputTextBox.Text);
                    int xDot = Convert.ToInt32(xDotInputTextBox.Text);
                    int yDot = Convert.ToInt32(yDotInputTextBox.Text);
                    Circle circle = new Circle(new Dot(xCircle, yCircle), new Round(radius));
                    Dot dot = new Dot(xDot, yDot);
                    if (AreParamsValid(radius, xCircle, yCircle, xDot, yDot))
                    {
                        DrawCircle(g, blackPen, circle);
                        FillDot(g, redBrush, dot);
                        questionLabel.Text = "Is dot in circle?";
                        if (circle.IsDotInCircle(dot))
                        {
                            answerLabel.Text = "YES";
                        }
                        else
                        {
                            answerLabel.Text = "NO";
                        }
                    }
                    else
                    {
                        questionLabel.Text = "";
                        answerLabel.Text = "";
                    }
                }
            }
            catch (Exception exception)
            {
                // ignored
            }
        }

        private static bool AreParamsValid(int radius, int xCircle, int yCircle, int xDot, int yDot)
        {
            return radius > 0 &&
                   xCircle >= radius &&
                   yCircle >= radius &&
                   xDot >= 0 &&
                   yDot >= 0;
        }

        private bool AreAllDrawParamsNotEmpty()
        {
            return radiusCircleInputTextBox.Text != "" &&
                   xCircleInputTextBox.Text != "" &&
                   yCircleInputTextBox.Text != "" &&
                   xDotInputTextBox.Text != "" &&
                   yDotInputTextBox.Text != "";
        }

        private void DrawCircle(Graphics g, Pen pen, Circle circle)
        {
            g.DrawEllipse(pen,
                circle.Center.X - circle.Round.Radius, 
                circle.Center.Y - circle.Round.Radius,
                circle.Round.Radius * 2, 
                circle.Round.Radius * 2);
        }

        private void FillDot(Graphics g, Brush brush, Dot dot)
        {
            g.FillEllipse(brush, 
                dot.X-3, dot.Y-3, 
                6, 6);
        }
    }
}