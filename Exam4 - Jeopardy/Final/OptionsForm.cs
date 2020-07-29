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
    public partial class OptionsForm : Form
    {
        public List<Player> playerList = new List<Player>();
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //sets number of text boxes depending on how many players
            if (numPlayers.Value == 1)
            {
                player1Label.Visible = true;
                player1Txt.Visible = true;
                player2Label.Visible = false;
                player2Txt.Visible = false;
                player3Label.Visible = false;
                player3Txt.Visible = false;
            }
            else if (numPlayers.Value == 2)
            {
                player2Label.Visible = true;
                player2Txt.Visible = true;
                player3Label.Visible = false;
                player3Txt.Visible = false;
            }
            else if (numPlayers.Value == 3)
            {
                player3Label.Visible = true;
                player3Txt.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             //create player objects and add them to a list to be sent to other forms           
            Player player1 = new Player(player1Txt.Text,0);
            playerList.Add(player1); 
            if (player2Txt.Text != "")
            {
                Player player2 = new Player(player2Txt.Text,0);
                playerList.Add(player2);
            }
            if (player3Txt.Text != "")
            {
                Player player3 = new Player(player3Txt.Text,0);
                playerList.Add(player3);
            }

            Form newGame = new GameForm(playerList);
            newGame.Show();
            this.Close();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
