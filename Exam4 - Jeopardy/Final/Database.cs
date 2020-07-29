using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Data.SqlClient;


namespace Final
{
    //contains database methods as well as serializer methods
    class Database
    {
        
        public static string pastGames;
        //sql connection string
        //database information removed
        static SqlConnection newConnection = new SqlConnection("Data Source=; " +
        "Initial Catalog=; User Id=; Password=");
        //serializer
        public static void Serialize(string gameInfo)
        {
            MemoryStream newStream = new MemoryStream();
            BinaryFormatter newFormat = new BinaryFormatter();
            newFormat.Serialize(newStream, gameInfo);
            string serialized = Convert.ToBase64String(newStream.ToArray());
            Insert(serialized);
            newStream.Close();
        }
        //database connect method
        public static void Connect()
        {
            try
            {
                newConnection.Open();

            }
            catch (Exception E)
            {
                
            }
        }
        public static void Disconnect()
        {
            try
            {
                newConnection.Close();
            }
            catch (Exception ex)
            {
                
            }
        }
        //insert serialized data into the database
        public static void Insert(string data)
        {
            string sqlStatement = "INSERT INTO jeopardy(gameData) VALUES(@serialized)";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sqlStatement, newConnection);
                cmd.Parameters.AddWithValue("@serialized", data);
                cmd.ExecuteNonQuery();

            }
            catch (Exception E)
            {
                
            }
            finally
            {
                Disconnect();
            }
        }
        //get data from database and deserialize
        public static string GetData()
        {
            
            string sqlStatement = "SELECT * FROM jeopardy";
            SqlCommand cmd = new SqlCommand(sqlStatement, newConnection);
            {
                string pastGames ="";
                try
                {
                    Connect();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                         pastGames += "\n" + Convert.ToString(DeSerialize(reader["gameData"].ToString()))+ "\n";
                        
                    }
                    
                }
                catch (Exception ex)
               {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    
                    Disconnect();
                    
                }
                return pastGames;
            }
            
        }
        //deserializer
        public static object DeSerialize(string data)
        {

            object myObj;            
            MemoryStream myStream = new MemoryStream(Convert.FromBase64String(data));
            BinaryFormatter myFormat = new BinaryFormatter();
            myObj = myFormat.Deserialize(myStream); 
            myStream.Close();
            return myObj;
        }
    }
}

