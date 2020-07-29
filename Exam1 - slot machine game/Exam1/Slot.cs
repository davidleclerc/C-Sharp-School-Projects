using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Exam1
{
    class Slot : PictureBox
    {

        private int slotImage;

        public int SlotImage { get => slotImage; set => slotImage = value; }
    }
}
