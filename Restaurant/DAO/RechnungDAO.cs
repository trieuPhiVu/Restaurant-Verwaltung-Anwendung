using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.DTO;
namespace Restaurant.DAO
{
    public class RechnungDAO
    {
        private static RechnungDAO instance;

        public static RechnungDAO Instance
        {
            get { if (instance == null) instance = new RechnungDAO(); return instance; }
            private set { instance = value; }
        }

        private RechnungDAO() { }

        public List<Rechnung> GetListRechnung()
        {
            List<Rechnung> listRechnung = new List<Rechnung>();
            string query = "select * from Rechnung";

            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in table.Rows) 
            {
                Rechnung rechnung = new Rechnung(row);
                listRechnung.Add(rechnung);
            }

            return listRechnung;
        }

        public int GetUncheckBillByTableId(int tableId)
        {
            string query = "select * from Rechnung where idTisch = @idTisch and status = 0";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { tableId });
            if(table.Rows.Count > 0)
            {
                Rechnung rechnung = new Rechnung(table.Rows[0]);
                return rechnung.Id;
            }
            return -1;
        }

        public void InsertBill(int idTisch)
        {
            string query = "exec USP_InsertBill @idTisch";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idTisch });
        }

        public int GetMaxIdBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(id) from Rechnung");
            }
            catch
            {
                return 1;
            }
        }

        public void CheckOut(int id,int rabatt)
        {
            string query = "update dbo.Rechnung set dateCheckOut = GETDATE() , status = 1 , rabatt = @rabatt where id = @id";
            DataProvider.Instance.ExecuteNonQuery (query, new object[] {rabatt,id});
        }
    }
}
