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
        public static string connectString;

        static string host = "localhost";

        static string login = "root";
        static string password = "root";

        static string DB_Name = "cpjkurs";
        static MySqlConnection conn = new MySqlConnection(connectString);


        public static void OpenConnection() 
        {
            try
            {
                connectString = "server=localhost;port=3306;database=cpjkurs;user=root;password=root;" /*+ host + ";Database=" + DB_Name + ";Uid=" + login + ";pwd=" + password + ";"*/;
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public static List<string[]> ExecuteQuery (int columnCount)
        {
            try
            {
                string query = "SELECT * FROM catalog"; // set query to fetch data "Select * from  tabelname"; 
                MySqlCommand command = new MySqlCommand(query, conn);

                MySqlDataReader reader = command.ExecuteReader();  

                MessageBox.Show("Error reader");

                List<string[]> resoult = new List<string[]>();

                while (reader.Read())
                {
                    resoult.Add(new string[columnCount]);

                    for (int i = 0; i < columnCount; i++)
                    {
                        resoult[resoult.Count - 1][i] = reader[i].ToString();
                    }
                    reader.Close();
                }
                MessageBox.Show("Error while");
                if (resoult.Count != 0)
                {
                    return resoult;
                    MessageBox.Show("Error return");
                }
                else
                {
                    return null;
                    MessageBox.Show("Error return");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public static void CloseConnection()
        {
            conn.Close();
        }





    }
}
