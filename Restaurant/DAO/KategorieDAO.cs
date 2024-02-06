using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant.DTO;

namespace Restaurant.DAO
{
    public class KategorieDAO
    {
        private static KategorieDAO instance;

        public static KategorieDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new KategorieDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private KategorieDAO() { }

        public List<Kategorie> GetListKategorie()
        {
            List<Kategorie> listKategorie = new List<Kategorie>();
            string query = "select * from SpeiseKatagorie";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in table.Rows) 
            {
                Kategorie kategorie = new Kategorie(row);
                listKategorie.Add(kategorie);
            }
            return listKategorie;
        }
    }
}
