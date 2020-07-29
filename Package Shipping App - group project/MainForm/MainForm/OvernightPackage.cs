using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    class OvernightPackage : Package, IPayable
    {
        private decimal additionalFeePerOunce;

        public decimal AdditionalFeePerOunce { get => additionalFeePerOunce; set => additionalFeePerOunce = value; }

        public OvernightPackage() { }
        public OvernightPackage(string senderName, string senderAddress, string senderCity, string senderState,
            string senderZipCode, string recipientName, string recipientAddress, string recipientCity, 
            string recipientState, string recipientZipCode, decimal weight, decimal costPerOunce, decimal additionalFeePerOunce) 
            : base(senderName, senderAddress, senderCity, senderState, senderZipCode, recipientName, 
                  recipientAddress, recipientCity, recipientState, recipientZipCode, weight, costPerOunce)
        {
            this.additionalFeePerOunce = additionalFeePerOunce;
        }

        public decimal CalculateCost()
        {
            return ((Weight * CostPerOunce) + (Weight * additionalFeePerOunce));
        }
        //Information about sender
        public override string ToString()
        {
            return base.ToString();
        }
        //Information about recipient and package
        public string PackageToString()
        {
            return $"\r\n Recipient: {RecipientName} \r\n Address: {RecipientAddress} {RecipientCity}, {RecipientState},  {RecipientZipCode}\r\n"
                + $"Package Information:\r\n {Weight}oz | {CostPerOunce:C}/oz | Additional Fee: {additionalFeePerOunce:C}\r\n - - - - - - - - - - - - - - - - - \n";
        }
    }
}
