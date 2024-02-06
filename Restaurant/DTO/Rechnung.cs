using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DTO
{
    public class Rechnung
    {
        private int id;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int idTisch;
        private int status;
        private int rabatt;
        public int Id { get => id; set => id = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int IdTisch { get => idTisch; set => idTisch = value; }
        public int Status { get => status; set => status = value; }
        public int Rabatt { get => rabatt; set => rabatt = value; }

        public Rechnung(int id,DateTime dateCheckIn,int idTisch,int status,int rabatt) 
        {
            this.Id = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = null;
            this.IdTisch = idTisch;
            this.Status = status;
            this.Rabatt = rabatt;
        }

        public Rechnung(DataRow row)
        {
            this.Id = (int)row["id"];
            this.dateCheckIn = (DateTime?)row["dateCheckIn"];
            this.dateCheckOut = null;
            this.IdTisch = (int)row["idTisch"];
            this.Status = (int)row["status"];
            this.Rabatt = (int)row["rabatt"];
        }
    }
}
