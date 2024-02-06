using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.DTO;

namespace Restaurant.DAO
{
    public class TischDAO
    {
        private static TischDAO instance;

        public static TischDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new TischDAO();
                }
                return instance;
            }
            private set { instance = value; }
        }

        private TischDAO() { }

        public static int tischWidth = 90;
        public static int tischHeight = 90;

        public List<Tisch> TischLaden()
        {
            List<Tisch> tischList = new List<Tisch>();
            string query = "USP_GetTableList";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                Tisch tisch = new Tisch(row);
                tischList.Add(tisch);
            }
            return tischList;
        }
    }
}
