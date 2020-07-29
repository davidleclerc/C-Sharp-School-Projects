using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace DiceSample
{
    class DieD6 : PictureBox

    {
        //creates a die object with a score and face value
        private int score;
        private int faceValue;

        public int Score { get => score; set => score = value; }
        public int FaceValue { get => faceValue; set => faceValue = value; }
    }
}
