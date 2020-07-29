using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class QandA : Form
    {
        private List<Player> playerList;
        private string question;
        private string answer;
        private int value;
        
        
        //constructor
        
        public QandA(List<Player> playerList, int value,string question, string answer )
        {
            
            this.playerList = playerList;
            this.question = question;
            this.answer = answer;
            this.value = value;
            

            ;
            InitializeComponent();
            timer1.Enabled = true;
            questionLabel.Text = question;
            answerLabel.Text += answer;
        }

        private void QandA_Load(object sender, EventArgs e)
        {
            //load player names to checkboxes
            playerCheck1.Text = playerList[0].Name;
            
            if (playerList.Count ==2)
            {
                playerCheck2.Visible = true;
                playerCheck2.Text = playerList[1].Name;
                
            }
            if (playerList.Count ==3)
            {
                playerCheck3.Visible = true;
                playerCheck3.Text = playerList[2].Name;
                
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            answerLabel.Visible = true;
            playerAnswer.Visible = true;
            correctButton.Visible = true;
            incorrectButton.Visible = true;
            playerAnswer.Text += answerTxtBox.Text;
        }
        //tracks which player checkbox is selected
        int selectedPlayer =-1;
        
        

        private void playerCheck1_CheckedChanged(object sender, EventArgs e)
        {
            //a player must be selected to submit an answer
            selectedPlayer = 0;
            submitButton.Visible = true;
        }

        private void playerCheck2_CheckedChanged(object sender, EventArgs e)
        {
            selectedPlayer = 1;
            submitButton.Visible = true;
        }

        private void playerCheck3_CheckedChanged(object sender, EventArgs e)
        {
            selectedPlayer = 2;
            submitButton.Visible = true;
        }

        private void correctButton_Click(object sender, EventArgs e)
        {
            //add money if correct answer
            playerList[selectedPlayer].Score += value;
            submitButton.Visible = false;

            this.Close();
        }

        private void incorrectButton_Click(object sender, EventArgs e)
        {
            //subtract money if incorrect answer
            playerList[selectedPlayer].Score -= value;
            submitButton.Visible = false;
            this.Close();
        }
        int timeLimit = 20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //20 second timer for questions
            timeLimit -= 1;
            clockLabel1.Text = Convert.ToString(timeLimit);
            if (timeLimit < 1)
            {
                //if there is a player selected to answer, they lose money if the time runs out
                if (selectedPlayer > -1)
                {
                    playerList[selectedPlayer].Score -= value;
                }
                this.Close();
            }
        }
    }
}
