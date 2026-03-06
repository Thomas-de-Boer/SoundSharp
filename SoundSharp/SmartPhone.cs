using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundSharp
{
    public class SmartPhone
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Size { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public SmartPhone(int id, string brand, string model, decimal size, decimal price, int stock)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Size = size;
            Price = price;
            Stock = stock;
        }
    }
}
