using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Sales
{
    public abstract class Products
    {

        public int ID { get; protected set; }
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public decimal Tax { get; protected set; } = 0.19m;

        private decimal _discount;

        public Products()
        {
        }

        public Products(int iD, string name, decimal price)
        {
            ID = iD;
            Name = name;
            Price = price;
        }


    }
}
