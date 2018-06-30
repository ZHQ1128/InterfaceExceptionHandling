using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExceptionHandling.Models
{
    class Products : Iproduct
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }

        public Products(string name, int price, string description, int id)
        {
            Name = name;
            Price = price;
            Description = description;
            ID = id;
        }

        public int ChangePrice(int newPrice)
        {
            Price = newPrice;
            return Price;
        }

        public int GetPrice()
        {
            return Price;
        }

        public void SetPrice(int value)
        {
            Price = value;
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Product name: {Name}\nProduct price: {Price}\ndescription: {Description}");
        }
    }
}
