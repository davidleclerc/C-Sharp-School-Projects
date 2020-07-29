using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Final
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int height = 100;
        int width = 100;
        int alexHeight = 0;
        int alexWidth = 0;
        int tick = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
         //animations based on timer, first the jeopardy logo appears   
            if (height <700)
            {
                height += 10;
                width += 10;
                Size newSize = new Size(height, width);
                splashImage.Size = newSize;
                
            }
            tick += 1;
            //then alex appears
            if (tick > 70)
            {
                alexHeight += 10;
                alexWidth += 10;
                alex.Visible = true;
                alex.Size = new Size(alexHeight, alexWidth);
                
            }
            //finally the splash window minimizes and options form is loaded
            if (tick == 350)
            {
                Form options = new OptionsForm();
                options.Show();
                timer1.Enabled = false;
                this.WindowState = FormWindowState.Minimized;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 10;

            label1.Text = "Jeopardy! \n Programmed by David Leclerc ";

            splashImage.Height = height;
            splashImage.Width = width;
            
        }
    }
}
