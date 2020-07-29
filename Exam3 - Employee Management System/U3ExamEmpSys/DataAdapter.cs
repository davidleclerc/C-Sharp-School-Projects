using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace U3ExamEmpSys
{
    class DataAdapter
    {
        //database information removed
        static SqlConnection myConnection = new SqlConnection("Data Source=; " +
            "Initial Catalog=; User Id=; Password=");

        public static string Status { get; internal set; }

        public static void Connect()
        {
            try
            {
                myConnection.Open();
                Status = "Connected";
            }
            catch (Exception e)
            {
                Status = e.Message;
            }
        }
        public static void Disconnect()
        {
            try
            {
                myConnection.Close();
                Status = "Disconnected";
            }
            catch (Exception e)
            {
                Status = e.Message;
            }

        }
        public static void InsertFullTime(string newLname,string newFname,DateTime newHireDate,int newSocial,string newEmail,int newPhone,decimal newTaxrate, int newEmployeeID,int newSalary,int newVacationDays,int newInsurance,int newTaxExempt,int newSickDays)
        {
            string insertStatement = "INSERT INTO Employees(lastName, firstName, hireDate,social,email,phoneNumber,taxRate,employeeID) VALUES("+
                 newLname +","+ newFname + "," + newHireDate + "," + newSocial + "," + newEmail + "," + newPhone + "," + newTaxrate +","+ newEmployeeID+
                ");INSERT INTO FullTime(emplyeeID,Salary,VacationDays,HasInsurance,TaxExempt,SickDays) VALUES("
                + newEmployeeID +","+ newVacationDays + "," +newInsurance + "," +newTaxExempt + "," + newSickDays + ");";
            SqlCommand sql = new SqlCommand(insertStatement, myConnection);
        }

        public static void DeleteFullTime(int employeeID)
        {
            string deleteStatement = "DELETE FROM Employees WHERE employeeID = " + employeeID +";";
            SqlCommand sql = new SqlCommand(deleteStatement, myConnection);
            sql.ExecuteNonQuery();
            
            
        }
        public static void UpdateFullTime()
        {

        }

        public static List<FullTime> SelectAll()
        {
            var FTEmployees = new List<FullTime>();
            string selectStatement = "SELECT * FROM Employees LEFT JOIN FullTime ON Employees.employeeID = FullTime.employeeID; ";
            SqlCommand sql = new SqlCommand(selectStatement, myConnection);

            try
            {
                Connect();
                SqlDataReader reader = sql.ExecuteReader();

                while (reader.Read())
                {
                    var fullTimeEmployee = new FullTime
                    {
                        EmployeeID = Convert.ToInt32(reader["employeeID"]),
                        FName = reader["firstName"].ToString(),
                        LName = reader["lastName"].ToString(),
                        HireDate = Convert.ToDateTime(reader["hireDate"]),
                        Social = Convert.ToInt32(reader["SSN"]),
                        Email = reader["email"].ToString(),
                        PhoneNumber = Convert.ToInt32(reader["phone"]),
                        TaxRate = Convert.ToDecimal(reader["taxRate"]),
                        Salary = Convert.ToDecimal(reader["salary"]),
                        VacationDays = Convert.ToDecimal(reader["vacationDays"]),
                        HasInsurance = Convert.ToBoolean(reader["hasInsurance"]),
                        TaxExempt = Convert.ToBoolean(reader["taxExempt"]),
                        SickDays = Convert.ToDecimal(reader["sickDays"])
                    };

                    FTEmployees.Add(fullTimeEmployee);
                    Status = "Connected - Full Time Employee List Loaded";
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Status = e.Message;
            }
            return FTEmployees;
            


        }
    }
}

