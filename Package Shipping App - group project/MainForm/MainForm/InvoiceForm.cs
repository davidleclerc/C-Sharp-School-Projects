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
    public partial class InvoiceForm : Form
    {
        public InvoiceForm(string senderInfo, string packageInfo, string costInfo)
        {
            InitializeComponent();
            senderLabel.Text = senderInfo;
            packageLabel.Text = packageInfo;
            costLabel.Text = costInfo;
        }
        //setup printing for invoice
        Bitmap printInvoice;
        private void prntInvoiceBtn_Click(object sender, EventArgs e)
        {
            //create image from invoice panel and open print preview
            
                printInvoice = new Bitmap(invoicePanel.Width, invoicePanel.Height);
                invoicePanel.DrawToBitmap(printInvoice, new Rectangle(0, 0, invoicePanel.Width, invoicePanel.Height));
                printPreviewDialog1.ShowDialog();
            

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(printInvoice, 10, 10);
        }

        private void closeInvoiceBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
