using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    abstract class Package : IPayable
    {
        private string senderName;
        private string senderAddress;
        private string senderCity;
        private string senderState;
        private string senderZipCode;
        private string recipientName;
        private string recipientAddress;
        private string recipientCity;
        private string recipientState;
        private string recipientZipCode;
        private decimal weight;
        private decimal costPerOunce;

        public string SenderName { get => senderName; set => senderName = value; }
        public string SenderAddress { get => senderAddress; set => senderAddress = value; }
        public string SenderCity { get => senderCity; set => senderCity = value; }
        public string SenderState { get => senderState; set => senderState = value; }
        public string SenderZipCode { get => senderZipCode; set => senderZipCode = value; }
        public string RecipientName { get => recipientName; set => recipientName = value; }
        public string RecipientAddress { get => recipientAddress; set => recipientAddress = value; }
        public string RecipientCity { get => recipientCity; set => recipientCity = value; }
        public string RecipientState { get => recipientState; set => recipientState = value; }
        public string RecipientZipCode { get => recipientZipCode; set => recipientZipCode = value; }
        public decimal Weight { get => weight; set => weight = value; }
        public decimal CostPerOunce { get => costPerOunce; set => costPerOunce = value; }

        public Package() { }

        public Package(string senderName, string senderAddress, string senderCity, string senderState,
            string senderZipCode, string recipientName, string recipientAddress, string recipientCity, 
            string recipientState, string recipientZipCode, decimal weight, decimal costPerOunce)
        {
            this.senderName = senderName;
            this.senderAddress = senderAddress;
            this.senderCity = senderCity;
            this.senderState = senderState;
            this.senderZipCode = senderZipCode;
            this.recipientName = recipientName;
            this.recipientAddress = recipientAddress;
            this.recipientCity = recipientCity;
            this.recipientState = recipientState;
            this.recipientZipCode = recipientZipCode;
            this.weight = weight;
            this.costPerOunce = costPerOunce;
        }
        //Base calculate cost
        decimal IPayable.CalculateCost()
        {
            return (weight * costPerOunce);
        }
        //Information about sender
        public override string ToString()
        {
            return $"Sender:\n {senderName} \r\nAddress: {senderAddress}\r\n{senderCity}, {senderState},  {senderZipCode}\r\n";
        }

        
    }
}
