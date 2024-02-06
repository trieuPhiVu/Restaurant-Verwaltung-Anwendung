using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance 
        { 
            
            get
            {
                if(instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
        }

        private DataProvider() { }

        private string strConnection = @"Data Source=DESKTOP-UK97B41\TRIEUPHIVU;Initial Catalog=Restaurant;Integrated Security=True;TrustServerCertificate=True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable table = new DataTable();
            using(SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int index = 0;
                    foreach(string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[index]);
                            index++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
            }
            return table;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int ergebnis = 0;
            using(SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int index = 0;
                    foreach(string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[index]);
                            index++;
                        }
                    }
                }
                ergebnis = command.ExecuteNonQuery();
                connection.Close();
            }
            return ergebnis;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object ergebnis = 0;
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int index = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[index]);
                            index++;
                        }
                    }
                }
                ergebnis = command.ExecuteScalar();
                connection.Close();
            }
            return ergebnis;
        }
    }
}
