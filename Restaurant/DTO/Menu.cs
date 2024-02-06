using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DTO
{
    public class Menu
    {
        private string foodName;
        private int count;
        private float price;
        private float totelPrice;

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotelPrice { get => totelPrice; set => totelPrice = value; }

        public Menu(string foodName, int count, float price, float totelPrice)
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.totelPrice = totelPrice;
        }

        public Menu(DataRow row)
        {
            this.FoodName = row["name"].ToString();
            this.Count = (int)row["count"];
            this.price = (float)Convert.ToDouble(row["price"].ToString());
            this.TotelPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }
    }
}
