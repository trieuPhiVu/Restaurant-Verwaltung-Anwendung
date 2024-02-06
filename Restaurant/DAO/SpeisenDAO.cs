using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.DTO;
namespace Restaurant.DAO
{
    public class SpeisenDAO
    {
        private static SpeisenDAO instance;

        public static SpeisenDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SpeisenDAO();
                }
                return instance;
            }
            private set 
            {
                instance = value;    
            }
        }

        private SpeisenDAO() { }

        public List<Speisen> GetListSpeisenNachKategorieId(int id)
        {
            List<Speisen> listSpeisen = new List<Speisen>();

            string query = "select * from dbo.Speisen where idKategorie = @id";

            DataTable table = DataProvider.Instance.ExecuteQuery(query,new object[] { id });

            foreach (DataRow row in table.Rows) 
            {
                Speisen speise = new Speisen(row);
                listSpeisen.Add(speise);
            }

            return listSpeisen;
        }
    }
}
