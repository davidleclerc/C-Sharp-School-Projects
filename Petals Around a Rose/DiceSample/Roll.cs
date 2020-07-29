using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceSample
{
    public static class Roll
    {
        private static Random randNumber = new Random();
       
        //generates random number for each die
        public static int RollD6()
        {
            int faceValue = randNumber.Next(1, 7);
            return faceValue;

        }

    }
}
