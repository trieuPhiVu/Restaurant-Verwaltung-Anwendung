using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.DTO;

namespace Restaurant.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new MenuDAO();
                }
                return instance;
            }
            private set { instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int tableId)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "select s.name, ri.count, s.price, s.price*ri.count as totalPrice  from dbo.RechnungInfo as ri , dbo.Rechnung as r, dbo.Speisen as s where ri.idRechnung = r.id and ri.idSpeisen = s.id and r.status = 0 and r.idTisch = @tableId";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] {tableId});

            foreach (DataRow row in table.Rows)
            {
                Menu menu = new Menu(row);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
