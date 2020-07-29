using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Label : Form
    {
        public Label(string carrier,string shipType,string senderInfo,string recipientInfo,string weight)
        {
            //set text on label window from package form
            InitializeComponent();
            carrierLabel.Text = carrier;
            weightLabel.Text = weight;
            dateLabel.Text = DateTime.Now.ToShortDateString();
            shipTypeLabel.Text = shipType;
            senderLabel.Text = senderInfo;
            shipToLabel.Text = "Ship To: \n" + recipientInfo;
        }

        private void Label_Load(object sender, EventArgs e)
        {
            
        }
        Bitmap printLabel;
        private void printLabelBtn_Click(object sender, EventArgs e)
        {
            //create print dialog from label
            printLabel = new Bitmap(labelPanel.Width, labelPanel.Height);
            labelPanel.DrawToBitmap(printLabel, new Rectangle(0, 0, labelPanel.Width, labelPanel.Height));
            printPreviewDialogLabel.ShowDialog();
        }
              

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(printLabel, 10, 10);
        }
        //return to package entry
        private void closeLabelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void shipToLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
