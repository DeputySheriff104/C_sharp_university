using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLogicLib.Task4Logic;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void athleteShowInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AreAllParamsNotEmpty(
                    athleteLastNameInputTextBox,
                    athleteAmountOfSportEventsInputTextBox,
                    athleteSumOfWonPlacesInputTextBox))
                {
                    string lastName = athleteLastNameInputTextBox.Text;
                    int amountOfSportEvents = Convert.ToInt32(athleteAmountOfSportEventsInputTextBox.Text);
                    int sumOfWonPlaces = Convert.ToInt32(athleteSumOfWonPlacesInputTextBox.Text);
                    if (AreIntParamsValid(amountOfSportEvents, sumOfWonPlaces))
                    {
                        Athlete athlete = new Athlete(lastName, amountOfSportEvents, sumOfWonPlaces);
                        athleteOutputRichTextBox.Text = athlete.GetStringInfo();
                    }
                }
            }
            catch (Exception exception)
            {
                // ignored
            }
        }

        private void athleteWithWinRecordShowInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AreAllParamsNotEmpty(
                    athleteWithWinRecordLastNameInputTextBox,
                    athleteWithWinRecordAmountOfSportEventsInputTextBox,
                    athleteWithWinRecordSumOfWonPlacesInputTextBox))
                {
                    string lastName = athleteWithWinRecordLastNameInputTextBox.Text;
                    int amountOfSportEvents = Convert.ToInt32(athleteWithWinRecordAmountOfSportEventsInputTextBox.Text);
                    int sumOfWonPlaces = Convert.ToInt32(athleteWithWinRecordSumOfWonPlacesInputTextBox.Text);
                    if (AreIntParamsValid(amountOfSportEvents, sumOfWonPlaces))
                    {
                        bool haveWonAtLeastOneTime = athleteWithWinRecordHaveWonAtLeastOneTimeCheckBox.Checked;
                        AthleteWithWinRecord athlete = new AthleteWithWinRecord(
                            lastName, amountOfSportEvents, sumOfWonPlaces, haveWonAtLeastOneTime);
                        athleteWithWinRecordOutputRichTextBox.Text = athlete.GetStringInfo();
                    }
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }
        
        private static bool AreIntParamsValid(int amountOfSportEvents, int sumOfWonPlaces)
        {
            return amountOfSportEvents <= sumOfWonPlaces;
        }

        private bool AreAllParamsNotEmpty(
            TextBox lastName, TextBox amountOfSportEvents, TextBox sumOfWonPlaces)
        {
            return lastName.Text != "" &&
                   amountOfSportEvents.Text != "" &&
                   sumOfWonPlaces.Text != "";
        }
    }
}