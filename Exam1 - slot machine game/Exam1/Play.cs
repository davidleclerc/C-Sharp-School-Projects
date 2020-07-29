using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public static class Play
    {
        //generates a random number for the slots
        private static Random randNumber = new Random();

        public static int RollSlots()
        {
            int slotImage = randNumber.Next(1, 13);
            return slotImage;
        }
             
    }
}
