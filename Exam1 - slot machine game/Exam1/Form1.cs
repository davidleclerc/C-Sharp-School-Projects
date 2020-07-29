using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// David Leclerc
//Exam 1
//9/23/2019
namespace Exam1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        double score = 0;      
        Slot[] slots = new Slot[3];

        private void Form1_Load(object sender, EventArgs e)
        {
            //button disabled until money is added
            button1.Enabled = false;
            scoreLabel.Text = score.ToString("C");
           
            //creates 3 slots as picture boxes
            for (int i = 0; i <slots.Length; i++)
            {
                slots[i] = new Slot();
                slots[i].Image = (Image)Properties.Resources.ResourceManager.GetObject("slot" + (i + 1));
                slots[i].Location = new System.Drawing.Point((150 + i * 180), 90);
                slots[i].Name = "pictureBox" + i;
                slots[i].Size = new System.Drawing.Size(150, 150);
                slots[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                slots[i].TabIndex = 0;
                slots[i].TabStop = false;
                this.Controls.Add(slots[i]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //disables play if user has no money
            if (score < .05)
            {
                button1.Enabled = false;
                label1.Text = "Add credit to play again";
            }
            //charges 5 cents to play
            score -= .05;
            for(int i =0; i < slots.Length; i++)
            {
                slots[i].SlotImage = Play.RollSlots();
                slots[i].Image = (Image)Properties.Resources.ResourceManager.GetObject("slot" + slots[i].SlotImage);
                
                
            }
            //if all slots are the same, win 1.00
            if (slots[0].SlotImage == slots[1].SlotImage && slots[0].SlotImage == slots[2].SlotImage)
            {
                //winner - 1.00
                label1.Text = "WINNER! - $1.00";
                score += 1.00;
            }
            //if 2 are the same win .10
            else if ((slots[0].SlotImage == slots[1].SlotImage && slots[0].SlotImage != slots[2].SlotImage) ||
                (slots[0].SlotImage == slots[2].SlotImage && slots[0].SlotImage != slots[1].SlotImage) ||
                (slots[1].SlotImage == slots[2].SlotImage && slots[0].SlotImage != slots[2].SlotImage))
            {
                //winner - .10
                label1.Text = "WINNER! - $0.10";
                score += .10;
            }
            else
            {
                //lose
                label1.Text = "TRY AGAIN";
                score += 0;

            }
            scoreLabel.Text = score.ToString("C");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //add 1.00 to credits, enable play button
            score += 1;
            button1.Enabled = true;
            label1.Text = "Click play to roll the slots";
            scoreLabel.Text = score.ToString("C");
        }
    }
}
