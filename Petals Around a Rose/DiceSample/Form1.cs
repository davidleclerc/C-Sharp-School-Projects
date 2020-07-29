//David Leclerc
//CIS 151
//assignment: petals around the rose
// date: 9/3/2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DieD6[] dice = new DieD6[5];            
        public void Form1_Load(object sender, EventArgs e)
        {                    
            // create dice picture boxes
            for (int i = 0; i < dice.Length; i++)

            {
                dice[i] = new DieD6();
                dice[i].Score = 0;
                dice[i].Image = (Image)Properties.Resources.ResourceManager.GetObject("dice_six_faces_" + (i+1));
                dice[i].Location = new System.Drawing.Point((133 + i * 100), 90);
                dice[i].Name = "pictureBox" + i;
                dice[i].Size = new System.Drawing.Size(120, 77);
                dice[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                dice[i].TabIndex = 0;
                dice[i].TabStop = false;
                this.Controls.Add(dice[i]);
            }
        }
       public void button1_Click(object sender, EventArgs e)
        {
            //rolls the dice, disables another roll until guess is made
            submitGuess.Enabled = true;
            rollDiceButton.Enabled = false;
            guessBox.Text = "";
            gameResult.Text = "";
            int totalScore = 0;
            
            //calls the roll class to generate random scores for the dice
            for (int i = 0; i < dice.Length; i++)
            {
                
                dice[i].FaceValue = Roll.RollD6();
                dice[i].Image = (Image)Properties.Resources.ResourceManager.GetObject("dice_six_faces_" +dice[i].FaceValue );
                dice[i].Score = Score.GetScore(dice[i].FaceValue);
                totalScore += dice[i].Score;
                Score.RoundScore = totalScore;            
            }                     
        }

        private void submitGuess_Click_1(object sender, EventArgs e)
        {
            //submits guess, enables new roll when pressed
            rollDiceButton.Enabled = true;
            submitGuess.Enabled = false;
            int guess;
            //checks to ensure the guess is an integer
            if (!int.TryParse(guessBox.Text,out guess))
            {
                MessageBox.Show("please enter a number");                
            }  
            //calls the game class to keep track of wins/games/runs
            if (guess == Score.RoundScore)
            {
                //if guess is correct, correct guesses and current run are increased
                Game.CurrentRun += 1;
                Game.NumGuesses += 1;
                Game.NumCorrect += 1;
                gameResult.Text = "Correct!";
                if (Game.CurrentRun > Game.BestRun)
                { Game.BestRun = Game.CurrentRun; }
            }
            else
            {
                //if guess is incorrect, current run is reset and total number of guesses increases
                gameResult.Text = "Wrong!";
                Game.CurrentRun = 0;
                Game.NumGuesses += 1;
            }
            //displays user's stats
            totalRolls.Text = "Total Rolls: " + Convert.ToString(Game.NumGuesses);
            numCorrect.Text = "Correct Guesses: " + Convert.ToString(Game.NumCorrect);
            bestRun.Text = "Best Run: " + Convert.ToString(Game.BestRun);          
        }
    }
}
