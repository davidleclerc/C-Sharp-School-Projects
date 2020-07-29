using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class GameData
    {
        string topic;
        string question1;
        string answer1;
        string question2;
        string answer2;
        string question3;
        string answer3;
        string question4;
        string answer4;
        string question5;
        string answer5;

        public GameData()
        {
        }
        //game data class, stores all questions and answers for each category
        public GameData(string topic, string question1, string answer1, string question2,
            string answer2, string question3, string answer3, string question4, string answer4,
            string question5, string answer5)
        {
            this.Topic = topic;
            this.Question1 = question1;
            this.Answer1 = answer1;
            this.Question2 = question2;
            this.Answer2 = answer2;
            this.Question3 = question3;
            this.Answer3 = answer3;
            this.Question4 = question4;
            this.Answer4 = answer4;
            this.Question5 = question5;
            this.Answer5 = answer5;
        }

        public string Topic { get => topic; set => topic = value; }
        public string Question1 { get => question1; set => question1 = value; }
        public string Answer1 { get => answer1; set => answer1 = value; }
        public string Question2 { get => question2; set => question2 = value; }
        public string Answer2 { get => answer2; set => answer2 = value; }
        public string Question3 { get => question3; set => question3 = value; }
        public string Answer3 { get => answer3; set => answer3 = value; }
        public string Question4 { get => question4; set => question4 = value; }
        public string Answer4 { get => answer4; set => answer4 = value; }
        public string Question5 { get => question5; set => question5 = value; }
        public string Answer5 { get => answer5; set => answer5 = value; }
    }
}
