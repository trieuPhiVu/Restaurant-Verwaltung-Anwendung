using Restaurant.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAO
{
    public class RechnungInfoDAO
    {
        private  static RechnungInfoDAO instance;

        public static RechnungInfoDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new RechnungInfoDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private RechnungInfoDAO() { }

        public List<RechnungInfo> GetListRechnungInfo()
        {
            List<RechnungInfo> listRechnungInfo = new List<RechnungInfo>();
            string query = "select * from listRechnungInfo";

            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                RechnungInfo ri = new RechnungInfo(row);
                listRechnungInfo.Add(ri);
            }

            return listRechnungInfo;
        }

        public void InsertBillInfo(int idRechnung,int idSpeisen,int anzahl)
        {
            string query = "exec USP_InsertBillInfo @idBill , @idFood , @count ";
            DataProvider.Instance.ExecuteNonQuery(query,new object[] {idRechnung,idSpeisen,anzahl});
        }
    }
}
