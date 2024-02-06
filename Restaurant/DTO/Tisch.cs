using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DTO
{
    public class Tisch
    {
        private string name;
        private int iD;
        private string status;

        public string Name { get => name; set => name = value; }
        public int ID { get => iD; set => iD = value; }
        public string Status { get => status; set => status = value; }

        public Tisch(int id,string name,string status)
        {
            this.ID = id;
            this.Name = name;   
            this.Status = status;
        }

        public Tisch(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = (string)row["name"];
            this.Status = (string)row["status"];
        }
    }
}
