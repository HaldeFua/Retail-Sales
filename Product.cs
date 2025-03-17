using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Retail_Sales
{
    public abstract class Product : IProduct
    {

        public int ID { get; protected set; }
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public decimal Tax { get; protected set; } = 0.19m;

        public Product(int iD, string name, decimal price)
        {
            ID = iD;
            Name = name;
            Price = price;
        }

        public abstract decimal CalculateTotalPrice();

        public override string ToString()
        {
            return $"ID: {ID} | {Name} | Precio: ${Price:N2} | Impuesto: {Tax * 100}%";
        }

    }
}
