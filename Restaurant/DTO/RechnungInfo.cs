using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DTO
{
    public class RechnungInfo
    {
        private int id;
        private int idRechnung;
        private int idSpeisen;
        private int anzahl;

        public int Id { get => id; set => id = value; }
        public int IdRechnung { get => idRechnung; set => idRechnung = value; }
        public int IdSpeisen { get => idSpeisen; set => idSpeisen = value; }
        public int Anzahl { get => anzahl; set => anzahl = value; }

        public RechnungInfo(int id,int idRechnung,int idSpeisen,int anzahl) 
        {
            this.Id = id;
            this.IdRechnung = idRechnung;
            this.IdSpeisen = idSpeisen;
            this.Anzahl = anzahl;
        }

        public RechnungInfo(DataRow row) 
        {
            this.Id = (int)row["ID"];
            this.IdRechnung = (int)row["idRechnung"];
            this.IdSpeisen = (int)row["idSpeisen"];
            this.anzahl = (int)row["count"];
        }
    }
}
