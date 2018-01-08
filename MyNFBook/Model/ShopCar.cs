using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ShopCar
    {
        public ShopCar() { }

        public ShopCar(string bookID,string title,decimal price,int count)
        {
            BookID = bookID;
            Title = title;
            Price = price;
            Count = count;
        }

        public string BookID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
    }
}