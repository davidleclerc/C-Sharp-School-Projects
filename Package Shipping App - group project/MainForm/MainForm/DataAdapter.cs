using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace MainForm
{
    class DataAdapter
    {
        //database information removed
        static SqlConnection newConnect = new SqlConnection("Data Source=; " +
        "Initial Catalog=; User Id=; Password=");

        public static void Connect()
        {
            try
            {
                newConnect.Open();

            }
            catch(Exception E)
            {
                //make label with connection info and display error here
            }
        }

        public static void Disconnect()
        {
            try
            {
                newConnect.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Insert(string serializedData)
        {
           
            string sqlStatement = "INSERT INTO Invoices(Data) VALUES(@serialized)";

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sqlStatement, newConnect);
                cmd.Parameters.AddWithValue("@serialized", serializedData);
                cmd.ExecuteNonQuery();

            }
            catch (Exception E)
            {
                //update label with error
            }
            finally
            {
                Disconnect();
            }
        }
        
    }
}
