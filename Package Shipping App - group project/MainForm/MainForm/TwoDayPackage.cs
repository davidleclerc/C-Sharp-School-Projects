using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    class TwoDayPackage : Package, IPayable
    {
        private decimal flatFee;

        public decimal FlatFee { get => flatFee; set => flatFee = value; }

        public TwoDayPackage() { }

        public TwoDayPackage(string senderName, string senderAddress, string senderCity, string senderState,
            string senderZipCode, string recipientName, string recipientAddress, string recipientCity,
            string recipientState, string recipientZipCode, decimal weight, decimal costPerOunce, decimal flatFee)
            : base(senderName, senderAddress, senderCity, senderState, senderZipCode, recipientName,
                  recipientAddress, recipientCity, recipientState, recipientZipCode, weight, costPerOunce)
        {
            this.flatFee = flatFee;
        }

        public decimal CalculateCost()
        {
            return flatFee + (CostPerOunce * Weight);
            
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public string PackageToString()
        {
            return $"\r\n Recipient: {RecipientName} \r\n Address: {RecipientAddress} {RecipientCity}, {RecipientState},  {RecipientZipCode}\r\n"
                + $"Package Information: \r\n {Weight} oz | {CostPerOunce:C}/oz | Flat Fee: {flatFee:C}\r\n - - - - - - - - - - - - - - - - - \n";
        }
    }
}
