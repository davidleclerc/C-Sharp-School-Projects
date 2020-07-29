using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class Player
    {
        //player class, stores player name and score
        private string name;
        private int score;

        public Player(string Name,int score)
        {
            this.name = Name;
            this.score = Score;
        }

        public string Name { get => name; set => name = value; }
        public int Score { get => score; set => score = value; }

        public override string ToString()
        {
            return "$"+Score;
        }
    }
    
}
