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
    public partial class ResultsForm : Form
    {
        private List<Player> playerList;
        
        public ResultsForm()
        {
            InitializeComponent();
        }

        public ResultsForm(List<Player> playerList)
        {
            //display winner and call database methods to pull past game data from database
            this.playerList = playerList;
            string winner = getWinner(playerList);
            InitializeComponent();
            resultLabel.Text = winner;
            pastGameLabel.Text = Database.GetData();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            Database.Serialize(getWinner(playerList));
            
        }
        public static string getWinner(List<Player> playerList)
        {
            //decide winner, could probably be done easier
            if (playerList.Count == 3)
            {
                if (playerList[0].Score > playerList[1].Score && playerList[0].Score > playerList[2].Score)
                {
                    return "Winner: " + playerList[0].Name + " " + "Score: " + playerList[0].ToString();
                }
                else if (playerList[1].Score > playerList[0].Score && playerList[1].Score > playerList[2].Score)
                {
                    {
                        return "Winner: " + playerList[1].Name + " " + "Score: " + playerList[1].ToString();
                    }

                }
                else
                {
                    return "Winner: " + playerList[2].Name + " " + "Score: " + playerList[2].ToString();
                }
            }
            else if (playerList.Count == 2)
            {
                if (playerList[0].Score > playerList[1].Score)
                {
                    return "Winner: " + playerList[0].Name + " " + "Score: " + playerList[0].ToString();
                }
                else 
                {
                    return "Winner: " + playerList[1].Name + " " + "Score: " + playerList[1].ToString();                    
                }
                
            }
            else { return "Winner: " + playerList[0].Name + " " + "Score: " + playerList[0].ToString(); }
        }
        private void ResultsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //start new game
            Form options = new OptionsForm();
            options.Show();            
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //close application
            Application.Exit();
        }
    }
}
