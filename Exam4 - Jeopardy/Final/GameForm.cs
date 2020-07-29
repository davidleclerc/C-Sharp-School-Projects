using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Final
{
    public partial class GameForm : Form
    {


        private List<Player> playerList;
        int hiddenButtonCount = 0;

        public GameForm()
        {
            InitializeComponent();

        }

        public GameForm(List<Player> playerList)
        {
            
            this.playerList = playerList;
            InitializeComponent();
            //read xml file to list
            List<GameData> newGameList = FileReader.GetGameData();
            //create category titles from list
            category1Label.Text = newGameList[0].Topic;
            category2Label.Text = newGameList[1].Topic;
            category3Label.Text = newGameList[2].Topic;
            category4Label.Text = newGameList[3].Topic;
            category5Label.Text = newGameList[4].Topic;
            timer1.Enabled = true;
            timer1.Interval = 1000;
            int xOffset = 65;
            int yOffset = 0;
            int value = 1;
            //creates buttons with defined styles and positions them
            for (int i = 0; i < 25; i++)
            {
                Button button = new Button();
                button.Location = new Point(xOffset ,120+yOffset);
                button.Click += new EventHandler(ButtonClick);
                button.Tag = i;
                button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.ForeColor = System.Drawing.Color.Gold;
                button.Name = "square"+i;
                button.Size = new System.Drawing.Size(133, 76);                
                button.Text = "$"+value+"00";
                button.UseVisualStyleBackColor = true;
                this.Controls.Add(button);
                value++;
                yOffset += 85;
                if (i == 4) { yOffset = 0; xOffset = 255;value = 1; }
                else if (i == 9) { yOffset = 0; xOffset = 435; value = 1; }
                else if (i == 14) { yOffset = 0; xOffset = 615; value = 1; }
                else if (i == 19) { yOffset = 0; xOffset = 800; value = 1; }
            }

            
            void ButtonClick(object sender, EventArgs e)
            {
                Button button = sender as Button;
                if (button != null)
                {
                    //creates button events. probably the worst way i could have done this
                    switch ((int)button.Tag)
                    {
                        case 0:
                            value = 100 ;
                            Form newQuestion = new QandA(playerList,value,newGameList[0].Question1, newGameList[0].Answer1);
                            newQuestion.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 1:
                            value = 200;
                            Form newQuestion1 = new QandA(playerList, value, newGameList[0].Question2, newGameList[0].Answer2);
                            newQuestion1.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 2:
                            value = 300;
                            Form newQuestion2 = new QandA(playerList, value, newGameList[0].Question3, newGameList[0].Answer3);
                            newQuestion2.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 3:
                            value = 400;
                            Form newQuestion3 = new QandA(playerList, value, newGameList[0].Question4, newGameList[0].Answer4);
                            newQuestion3.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 4:
                            value = 500;
                            Form newQuestion4 = new QandA(playerList, value, newGameList[0].Question5, newGameList[0].Answer5);
                            newQuestion4.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 5:
                            value = 100;
                            Form newQuestion5 = new QandA(playerList, value, newGameList[1].Question1, newGameList[1].Answer1);
                            newQuestion5.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 6:
                            value = 200;
                            Form newQuestion6 = new QandA(playerList, value, newGameList[1].Question2, newGameList[1].Answer2);
                            newQuestion6.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 7:
                            value = 300;
                            Form newQuestion7 = new QandA(playerList, value, newGameList[1].Question3, newGameList[1].Answer3);
                            newQuestion7.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 8:
                            value = 400;
                            Form newQuestion8 = new QandA(playerList, value, newGameList[1].Question4, newGameList[1].Answer4);
                            newQuestion8.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 9:
                            value = 500;
                            Form newQuestion9 = new QandA(playerList, value, newGameList[1].Question5, newGameList[1].Answer5);
                            newQuestion9.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 10:
                            value = 100;
                            Form newQuestion10 = new QandA(playerList, value, newGameList[2].Question1, newGameList[2].Answer1);
                            newQuestion10.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 11:
                            value = 200;
                            Form newQuestion11 = new QandA(playerList, value, newGameList[2].Question2, newGameList[2].Answer2);
                            newQuestion11.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 12:
                            value = 300;
                            Form newQuestion12 = new QandA(playerList, value, newGameList[2].Question3, newGameList[2].Answer3);
                            newQuestion12.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 13:
                            value = 400;
                            Form newQuestion13 = new QandA(playerList, value, newGameList[2].Question4, newGameList[2].Answer4);
                            newQuestion13.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 14:
                            value = 500;
                            Form newQuestion14 = new QandA(playerList, value, newGameList[2].Question5, newGameList[2].Answer5);
                            newQuestion14.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 15:
                            value = 100;
                            Form newQuestion15 = new QandA(playerList, value, newGameList[3].Question1, newGameList[3].Answer1);
                            newQuestion15.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 16:
                            value = 200;
                            Form newQuestion16 = new QandA(playerList, value, newGameList[3].Question2, newGameList[3].Answer2);
                            newQuestion16.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 17:
                            value = 300;
                            Form newQuestion17 = new QandA(playerList, value, newGameList[3].Question3, newGameList[3].Answer3);
                            newQuestion17.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 18:
                            value = 400;
                            Form newQuestion18 = new QandA(playerList, value, newGameList[3].Question4, newGameList[3].Answer4);
                            newQuestion18.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 19:
                            value = 500;
                            Form newQuestion19 = new QandA(playerList, value, newGameList[3].Question5, newGameList[3].Answer5);
                            newQuestion19.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 20:
                            value = 100;
                            Form newQuestion20 = new QandA(playerList, value, newGameList[4].Question1, newGameList[4].Answer1);
                            newQuestion20.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 21:
                            value = 200;
                            Form newQuestion21 = new QandA(playerList, value, newGameList[4].Question2, newGameList[4].Answer2);
                            newQuestion21.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 22:
                            value = 300;
                            Form newQuestion22 = new QandA(playerList, value, newGameList[4].Question3, newGameList[4].Answer3);
                            newQuestion22.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 23:
                            value = 400;
                            Form newQuestion23 = new QandA(playerList, value, newGameList[4].Question4, newGameList[4].Answer4);
                            newQuestion23.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;
                        case 24:
                            value = 500;
                            Form newQuestion24 = new QandA(playerList, value, newGameList[4].Question5, newGameList[4].Answer5);
                            newQuestion24.Show();
                            button.Hide();
                            hiddenButtonCount += 1;
                            break;


                    }
                }
            }


        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            player1Name.Text = playerList[0].Name;
            //display player names and scores
            if (playerList.Count==2)
            {
                player2Name.Visible = true;
                player2ScoreLabel.Visible = true;
                player2Name.Text = playerList[1].Name;
                
            }
            if (playerList.Count==3)
            {
                player3Name.Visible = true;
                player3ScoreLabel.Visible = true;
                player3Name.Text = playerList[2].Name;
               
            }

        }
        //set 20 minute time limit for game            
        int timeLimit = 1200;
        private void timer1_Tick(object sender, EventArgs e)
        {
           //displays time limit in mm:ss format
            timeLimit -= 1;
            clockLabel.Text = timeLimit/60 +":"+((timeLimit%60) >= 10?(timeLimit % 60).ToString():"0"+timeLimit % 60);
            player1ScoreLabel.Text = (playerList[0].ToString());
            //updates scores every tick, so that score stays current throughout game
            if (playerList.Count > 1 )
            {                
                player2ScoreLabel.Text = (playerList[1].ToString());
            }
            if (playerList.Count > 2 )
            {               
                player3ScoreLabel.Text = (playerList[2].ToString());
            }
            //game over when timer runs out or all squares have been clicked
            if(timeLimit < 1 || hiddenButtonCount == 25)
            {
                Form newResults = new ResultsForm(playerList);
                newResults.Show();
                this.Close();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //start new game
            Form options = new OptionsForm();
            options.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

