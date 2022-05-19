using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace kursach_prog
{
    internal class DataBaseConnector
    {
        public static string connectString = "server=localhost;database=cpjkurs;user=root;password=root;";

        static string host = "localhost";

        static string login = "root";
        static string password = "root";

        static string DB_Name = "cpjkurs";
        //static MySqlConnection conn = new MySqlConnection(connectString);


        

        public static List<string[]> ExecuteQuery (int columnCount)
        {
            string query = "SELECT * FROM catalog"; // set query to fetch data "Select * from  tabelname"; 
            

            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                
                List<string[]> resoult = new List<string[]>();
                MySqlDataReader reader = command.ExecuteReader();
                
                
                while (reader.Read())
                {
                    resoult.Add(new string[columnCount]);
                    for (int i = 0; i < columnCount; i++)
                    {
                        resoult[resoult.Count - 1][i] = reader[i].ToString();

                    }
                    
                    
                }
                reader.Close();
                
                
                if (resoult.Count != 0)
                {
                    return resoult;
                    
                }
                else
                {
                    return null;
                    
                }
                    
                
            }
            
            
        }


        





    }
}
