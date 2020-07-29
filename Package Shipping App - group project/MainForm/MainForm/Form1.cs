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
    public partial class Form1 : Form
    {
        //Creates counter to keep track of number of packages a sender has
        int counter = 0;
        int arrayCounter = 0;//Counter for arrays
        int lstBxIndex = 0;//Keeps track of listBox index
        string[] invoiceStrings = new string[100]; //Array to keep track of invoice strings
        decimal[] invoiceAmounts = new decimal[100]; //Array to keep track of invoice amounts 
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            //Checks if all fields are filled
            if (allFilled())
            {
                //Creates reference to the web service
                ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
                //If two day shipping is chosen
                if (cmbBxShipType.Text == "Two Day")
                {
                    //Calls web service to get the flatfee and cost per ounce
                    decimal flatFee = service.GetFlatFee(cmbBxCarrier.Text);
                    decimal costPerOunce = service.GetCostPerOunce(cmbBxCarrier.Text);
                    //creates new twodaypackage object
                    TwoDayPackage newPackage = new TwoDayPackage(txtBxSendName.Text, txtBxSendAddress.Text, txtBxSendCity.Text,
                        txtBxSendState.Text, txtBxSendZip.Text, txtBxRecpName.Text, txtBxRecpAddress.Text, txtBxRecpCity.Text,
                        txtBxRecpState.Text, txtBxRecpZip.Text, nudWeight.Value, costPerOunce, flatFee);

                    //If the package is the senders first package, then it outputs the sender information
                    if (counter == 0)
                    {
                        txtBxInfo.Text += newPackage.ToString();
                        invoiceStrings[arrayCounter] += newPackage.ToString();
                    }
                    //Outputs package information
                    txtBxInfo.Text += newPackage.PackageToString();
                    invoiceStrings[arrayCounter] += newPackage.PackageToString();//Saves string into array
                    invoiceAmounts[arrayCounter] += newPackage.CalculateCost();//Saves cost into array
                    counter++;//Increments counter
                }
                else //If overnight is chosen
                {
                    decimal additionalFee = service.GetAdditionalCost(cmbBxCarrier.Text);
                    decimal costPerOunce = service.GetCostPerOunce(cmbBxCarrier.Text);
                    //creates new overnightpackage object
                    OvernightPackage newPackage = new OvernightPackage(txtBxSendName.Text, txtBxSendAddress.Text, txtBxSendCity.Text,
                        txtBxSendState.Text, txtBxSendZip.Text, txtBxRecpName.Text, txtBxRecpAddress.Text, txtBxRecpCity.Text,
                        txtBxRecpState.Text, txtBxRecpZip.Text, nudWeight.Value, costPerOunce, additionalFee);
                    //If the package is the senders first package, then it outputs the sender information
                    if (counter == 0)
                    {
                        txtBxInfo.Text += newPackage.ToString();
                        invoiceStrings[arrayCounter] += newPackage.ToString();
                    }
                    //Outputs package information
                    txtBxInfo.Text += newPackage.PackageToString();
                    invoiceStrings[arrayCounter] += newPackage.PackageToString(); //Saves string into array
                    invoiceAmounts[arrayCounter] += newPackage.CalculateCost();//Saves cost into array
                    counter++;//Increments counter
                }
            } else
            {
                MessageBox.Show("All fields must be filled");
            }
            emptyFields();
        }

        private void emptyFields()
        {
            //Emptys all fields for recipient and package
            TextBox[] textArray = new TextBox[5] {txtBxRecpName, txtBxRecpAddress, txtBxRecpCity, txtBxRecpState, txtBxRecpZip}; //declare array of text boxes
            foreach (TextBox textBox in textArray)
            {
                textBox.Text = "";
            }
            nudWeight.Value = 0;
            cmbBxCarrier.SelectedIndex = -1;
            cmbBxShipType.SelectedIndex = -1;
        }

        public bool allFilled()
        {
            bool isValid = true; //Declare bool to see if all fields are filled
            TextBox[] textArray = new TextBox[10] {txtBxSendName, txtBxSendAddress, txtBxSendCity, txtBxSendState,
            txtBxSendZip, txtBxRecpName, txtBxRecpAddress, txtBxRecpCity, txtBxRecpState, txtBxRecpZip}; //declare array of text boxes
            foreach(TextBox textBox in textArray)
            {
                if(textBox.Text == "")
                {
                    isValid = false;//If any text box in the array is empty set isValid to false
                }
            }
            if(nudWeight.Value == 0.0m)
            {
                isValid = false; //If the weight is 0 set isValid to false
            }
            if(cmbBxCarrier.Text == "" || cmbBxShipType.Text == "")
            {
                isValid = false; //If no carrier or ship type is chosen set isValid to false
            }

            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtBxInfo.Lines[1];
            //lstBxInvoices.Items.Add(name.Remove(0, 5));
            lstBxInvoices.Items.Add(name);
            //MessageBox.Show(invoiceStrings[arrayCounter]);
            arrayCounter++;
            txtBxInfo.Text = "";//Clears info text box
            counter = 0;//Resets counter
            txtBxSendName.Text = "";
            txtBxSendAddress.Text = "";
            txtBxSendCity.Text = "";
            txtBxSendState.Text = "";
            txtBxSendZip.Text = "";
        }

        private void lstBxInvoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            //initiate placeholder variables
            decimal tax = 0.0m;
            decimal totalCost = 0.0m;
            Invoice newInvoice = new Invoice(); //Create new invoice
            lstBxIndex = lstBxInvoices.SelectedIndex;//Get index
            tax = newInvoice.CalculateTax(invoiceAmounts[lstBxIndex]);//Calculate tax through invoice
            totalCost = newInvoice.CalculateTotal(invoiceAmounts[lstBxIndex], tax);//Calculate total costs
            txtBxInfo2.Text = invoiceStrings[lstBxIndex] + $"\r\nSubtotal: {invoiceAmounts[lstBxIndex]:C}\r\nTax: {tax:C}\r\nTotal Cost: {totalCost:C}";//Updates info text box with information
        }

        
        //open print preview for invoices when clicked
        private void printButton_Click(object sender, EventArgs e)
        {
            string[] textArray = txtBxInfo2.Lines;
            string packageInfo = "";
            for (int i = 4; i < (textArray.Length - 3); i++)
            {
                
                packageInfo += (textArray[i] +"\n");
               
            }
            

            try
            {
                string senderInfo = textArray[0] + " " + textArray[1] + " " + textArray[2] + " " + textArray[3] ;
                string costInfo = textArray[textArray.Length - 3] + " " + textArray[textArray.Length - 2] + " " + textArray[textArray.Length - 1] ;

                InvoiceForm newForm = new InvoiceForm(senderInfo, packageInfo, costInfo);
                newForm.Show();
            }
            
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Please select an invoice to print");
            }
}

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
        }
        //open a new window with a shipping label from entered package information
        private void createLabelButton_Click(object sender, EventArgs e)
        {
            //send package information to label form
            string carrier = cmbBxCarrier.Text;
            string weight = nudWeight.Value.ToString() + " lbs";
            string shipType = cmbBxShipType.Text;
            string senderInfo = txtBxSendName.Text + "\n" + txtBxSendAddress.Text + "\n" + txtBxSendCity.Text + " " + txtBxSendState.Text + " " + txtBxSendZip.Text;
            string recipientInfo = txtBxRecpName.Text + "\n" + txtBxRecpAddress.Text + "\n" + txtBxRecpCity.Text + " " + txtBxRecpState.Text + " " + txtBxRecpZip.Text;
            Label newLabel = new Label(carrier,shipType,senderInfo,recipientInfo,weight);
            newLabel.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveInv_Click(object sender, EventArgs e)
        {
            //Loops though listbox
            for(int i = 0; i < lstBxInvoices.Items.Count; i++)
            {
                string info = getFullString(i);
                Serializer.SerializeNow(info);
                lstBxInvoices.Items.Clear();
                txtBxInfo2.Text = "";
            }
        }

        private string getFullString(int i)
        {
            //Creates full invoice string for 
            decimal tax = 0.0m;
            decimal totalCost = 0.0m;
            Invoice newInvoice = new Invoice(); //Create new invoice
            tax = newInvoice.CalculateTax(invoiceAmounts[i]);//Calculate tax through invoice
            totalCost = newInvoice.CalculateTotal(invoiceAmounts[i], tax);//Calculate total costs
            return invoiceStrings[lstBxIndex] + $"\r\nCost: {invoiceAmounts[i]:C}\r\nTax: {tax:C}\r\nTotal Cost: {totalCost:C}";//Updates info text box with information
        }
    }
}
