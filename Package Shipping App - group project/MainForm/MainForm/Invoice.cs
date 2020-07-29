using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    class Invoice
    {
        private decimal tax;
        private decimal totalCost;

        public decimal Tax { get => tax; set => tax = value; }
        public decimal TotalCost { get => totalCost; set => totalCost = value; }
        public Invoice() { }
        public Invoice(decimal tax, decimal totalCost)
        {
            this.tax = tax;
            this.totalCost = totalCost;
        }

        public decimal CalculateTax(decimal cost)
        {
            return cost * 0.08m;
        }

        public decimal CalculateTotal(decimal cost, decimal taxAmount)
        {
            return cost + taxAmount;
        }
    }
}
