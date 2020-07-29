using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3ExamEmpSys
{
    class FullTime : Employee
    {
        private decimal salary;
        private decimal vacationDays;
        private bool hasInsurance;
        private bool taxExempt;
        private decimal sickDays;

        public decimal Salary { get => salary; set => salary = value; }
        public decimal VacationDays { get => vacationDays; set => vacationDays = value; }
        public bool HasInsurance { get => hasInsurance; set => hasInsurance = value; }
        public bool TaxExempt { get => taxExempt; set => taxExempt = value; }
        public decimal SickDays { get => sickDays; set => sickDays = value; }


        public FullTime()
        {

        }

        public FullTime(int employeeID, string fName, string lName, DateTime hireDate, int social, string email,
            int phoneNumber, decimal taxRate, decimal salary, decimal vacationDays, bool hasInsurance,
            bool taxExempt, decimal sickDays)
            : base(employeeID, fName, lName, hireDate, social, email, phoneNumber, taxRate)
        {
            this.Salary = salary;
            this.VacationDays = vacationDays;
            this.HasInsurance = hasInsurance;
            this.TaxExempt = taxExempt;
            this.SickDays = sickDays;
        }

        public override string ToString()
        {
            return "Name: " + FName + " " + LName + "  Status: Full Time  Salary: " + Salary + "  vacation days: " + VacationDays +
                "  Sick Days: " + SickDays + "  Insured?: " + HasInsurance + "  Tax Exempt?: " + TaxExempt;
        }

        public override decimal CalcTaxes()
        {
            if (TaxExempt)
            {
                return 0;
            }
            else
            {
                return (TaxRate * Salary);
            }
        }
        public override decimal CalcTotalEarnings()
        {
            return Salary;
        }

        public void GetAllFullTime()
        {
            DataAdapter.SelectAll();

        }
    }
}
