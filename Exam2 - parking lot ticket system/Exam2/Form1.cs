using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//use XML
using System.Xml;

namespace Exam2
{
    public partial class Form1 : Form
    {
        //selected index counter
        int i;
        //keep track of how many tickets exist
        int tickCounter;
        public Form1()
        {
            InitializeComponent();
            
        }
             
        //displays current time for ticket creation
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            //if there is a space available, display lot information
            if (Lot.spacesUsed<Lot.spacesTotal)
            {
                //set font to 11pt
                displayTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
                //parking lot info
                displayTxtBox.Text = "\n Current Time: " + dateTime.ToString() + "\n" +
                "First 3 hours: $2.00\n" +
                "$0.50 for each additional hour\n" +
                "up to $10.00\n "+  
                //calculates number of spaces left
                + (Lot.spacesTotal - Lot.spacesUsed) + "/" + Lot.spacesTotal + " Spaces Available"+
                "\n\nCARS PARKED LONGER THAN 24 HOURS\n    WILL BE TOWED";
                //enable print ticket button
                btnPrintTicket.Enabled = true;
            }
            //if lot is full
            else
            {
                //disable ticket printing
                btnPrintTicket.Enabled = false;
                //sets font to 24pt
                displayTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24, System.Drawing.FontStyle.Bold);
                //displays lot full message
                displayTxtBox.Text = "Parking lot is full";
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //centers text in the text box
            displayTxtBox.SelectionAlignment = HorizontalAlignment.Center;

            //enable pay button
            btnPayTicket.Enabled = false;
            //load test data file
            XmlReader reader = XmlReader.Create("TestData.xml");
            Ticket aTicket = new Ticket();

            
            while (reader.Read())
            {
                //find beginning of xml file
                if (reader.IsStartElement()) 
                {
                    switch (reader.Name)    
                    {
                        //read tags and assign data to ticket object
                        case "ticket":    
                            if (aTicket.TicketNumber != null)   
                            {
                                //check that there is data entered
                                listTickets.Items.Add(aTicket);   
                                aTicket = new Ticket();          
                            }
                            break;
                        case "ticketNumber":      
                            reader.Read();  
                            aTicket.TicketNumber = reader.Value;
                            //assigns ticket number to object, updates ticker count
                            if(Convert.ToInt32(reader.Value) > tickCounter)
                            {
                                tickCounter = Convert.ToInt32(reader.Value);
                            }
                            break;
                        case "ticketDate":
                            reader.Read();
                             //assigns ticket date, converts to datetime type
                            aTicket.TicketDate = Convert.ToDateTime(reader.Value);

                            break;
                        case "ticketStatus":
                            reader.Read();
                            //checks loaded tickets and updates their status
                            if (DateTime.Now.Subtract(aTicket.TicketDate).TotalHours < 24)
                            {
                                //if the ticket time is not over 24 hours, status does not change
                                aTicket.TicketStatus = reader.Value;
                                //if ticket is open and not over time, one parking space is being used
                                if (reader.Value != "Paid")
                                {
                                    Lot.spacesUsed += 1;
                                }
                                
                            }
                            else
                            {
                                //if ticket is over 24 hours, car gets towed
                                aTicket.TicketStatus = "OVER LIMIT - TOWED";
                            }
                            break;
                            }  
                }  

            } 
            //add ticket to the listbox
            if (aTicket.TicketNumber != null)        
            {
                listTickets.Items.Add(aTicket);
                
            } 

        }
                     

        private void btnPrintTicket_Click_1(object sender, EventArgs e)
        {
            //prints ticket, uses 1 parking space, adds 1 ticket to counter
            Lot.spacesUsed += 1;
            tickCounter += 1;
            //adds new ticket with current time, ticket number and open status
            Ticket aTicket = new Ticket(Convert.ToString(tickCounter), DateTime.Now, "Open");
            listTickets.Items.Add(aTicket);

        }

        private void btnPayTicket_Click_1(object sender, EventArgs e)
        {
            
            //if (listTickets.SelectedIndex != -1)
            //{
                i = listTickets.SelectedIndex;
                Ticket aTicket = (Ticket)listTickets.Items[i];
                if (aTicket.TicketStatus == "Open")
                {
                    //if the ticked is unpaid, allow the user to click pay button and call fee calculation method
                    aTicket.OutDate = DateTime.Now;
                    MessageBox.Show("Total parking fee for ticket #" + aTicket.TicketNumber +"\n"+
                        aTicket.CalculateCharge().ToString("C"));
                    //ticket is now paid
                    aTicket.TicketStatus = "Paid";
                    //updates listbox
                    listTickets.Items[i] = listTickets.Items[i];
                    //disable pay button again until new open ticket is selected
                    btnPayTicket.Enabled = false;
                    //free up a parking space
                    Lot.spacesUsed -= 1;
                }
                
                
            //}
        }

        private void listTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTickets.SelectedIndex != -1)
            {
                //propogates text boxes with ticket information and enables/disables pay button depending on ticket status
                i = listTickets.SelectedIndex;
                Ticket aTicket = (Ticket)listTickets.Items[i];
                if (aTicket.TicketStatus == "Open")
                {
                    btnPayTicket.Enabled = true;
                }
                else
                {
                    btnPayTicket.Enabled = false;
                }
                //assign text box text from selected ticket 
                textTicketNum.Text = aTicket.TicketNumber;
                textTicketDate.Text = Convert.ToString(aTicket.TicketDate);
                textTicketStatus.Text = aTicket.TicketStatus;


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //write listbox to xml file
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineHandling = NewLineHandling.Replace;

            XmlWriter writer = XmlWriter.Create("TicketsUpdated.xml", settings);

            writer.WriteStartDocument();

            writer.WriteStartElement("tickets");
            //loops through each item in the list and write to xml element
            foreach (Ticket item in listTickets.Items)
            {
                writer.WriteStartElement("ticket");
                writer.WriteElementString("ticketNumber", item.TicketNumber);
                writer.WriteElementString("ticketDate", Convert.ToString(item.TicketDate));
                writer.WriteElementString("ticketStatus", item.TicketStatus);
                writer.WriteEndElement();
            }
            writer.Dispose();
        }
    }
}
