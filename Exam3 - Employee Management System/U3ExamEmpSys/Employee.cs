using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3ExamEmpSys
{
    public abstract class Employee
    {
        private int employeeID;
        private string fName;
        private string lName;
        private DateTime hireDate;
        private int social;
        private string email;
        private int phoneNumber;
        private decimal taxRate;

        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public DateTime HireDate { get => hireDate; set => hireDate = value; }
        public int Social { get => social; set => social = value; }
        public string Email { get => email; set => email = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public decimal TaxRate { get => taxRate; set => taxRate = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }

        public Employee() { }

        public Employee(int employeeID, string fName, string lName, DateTime hireDate, int social, string email, int phoneNumber, decimal taxRate)
        {
            this.employeeID = employeeID;
            this.fName = fName;
            this.lName = lName;
            this.hireDate = hireDate;
            this.social = social;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.taxRate = taxRate;
        }

        public void InsertFullTime()
        {

        }

        public void DeleteFullTime()
        {

        }
        public void UpdateFullTime()
        {

        }
        public abstract decimal CalcTaxes();

        public abstract decimal CalcTotalEarnings();

      

    }
}
  