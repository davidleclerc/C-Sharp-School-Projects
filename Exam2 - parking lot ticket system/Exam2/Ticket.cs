using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class Ticket
    {
        //data fields
        private string ticketNumber;
        private DateTime ticketDate;
        private string ticketStatus;
        private DateTime outDate;
        //publis properties
        public string TicketNumber { get => ticketNumber; set => ticketNumber = value; }
        public DateTime TicketDate { get => ticketDate; set => ticketDate = value; }
        public string TicketStatus { get => ticketStatus; set => ticketStatus = value; }
        public DateTime OutDate { get => outDate; set => outDate = value; }
        //constructors
        public Ticket() { }
        public Ticket( string ticketNumber, DateTime ticketDate,string ticketStatus)
        {
            this.ticketNumber = ticketNumber;
            this.ticketDate = ticketDate;
            this.ticketStatus = ticketStatus;

        }
        //tostring override
        public override string ToString()
        {
            return "Ticket No.: " + TicketNumber + " Status: " + ticketStatus;
        }
        //method to calculate ticket price based on hours parked and fee rates
        public decimal CalculateCharge()
        {
            decimal rate = .5M;
           decimal hours = Convert.ToDecimal(outDate.Subtract(ticketDate).TotalHours);
            //more than 17 hours is $10
            if (hours >= 17)
            {
                return 10;
            }
            //min fee is $2
            else if (hours <= 3)
            {
                return 2;
            } 
            //calculate rate if parked more than 3 hours but less than 17
            else
            {
                return ((hours - 3) *  rate) + 2;
            }
        }


    }
}
