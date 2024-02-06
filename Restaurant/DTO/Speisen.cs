using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DTO
{
    public class Speisen
    {
        private int id;
        private string name;
        private int idKategorie;
        private float price;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int IdKategorie { get => idKategorie; set => idKategorie = value; }

        public Speisen(int id,string name,int idKategorie ,float price) 
        {
            this.Id = id;
            this.Name = name;
            this.IdKategorie = idKategorie;
            this.Price = price;
        }

        public Speisen(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = (string)row["name"];
            this.IdKategorie = (int)row["idKategorie"];
            this.price = (float)Convert.ToDouble(row["price"].ToString());
        }
    }
}
