using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DTO
{
    public class Kategorie
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Kategorie(int id,string name) 
        {
            this.Id = id;
            this.Name = name;
        }

        public Kategorie(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = (string)row["name"];
        }
    }
}
