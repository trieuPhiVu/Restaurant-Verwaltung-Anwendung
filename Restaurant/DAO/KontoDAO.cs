using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAO
{
    public class KontoDAO
    {
        private static KontoDAO instance;
        public static KontoDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new KontoDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private KontoDAO() { }

        public bool Login(string username, string passwort)
        {
            string query = "USP_Login @userName , @passWort";
            DataTable table = DataProvider.Instance.ExecuteQuery(query,new object[] { username, passwort });
            return table.Rows.Count > 0;
        }
    }
}
