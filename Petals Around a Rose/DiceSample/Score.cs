using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceSample
{
    class Score
    {

        public static int RoundScore { get; set; }

        public static int GetScore(int faceValue)
        {
            // assigns the score of each die by the face value
            int pointValue;
            
            if (faceValue == 3)
            { pointValue = 2; }
            else if (faceValue == 5)
            { pointValue = 4; }
            else { pointValue = 0; }
            return pointValue;
        }

    }

 }

