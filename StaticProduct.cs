using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Sales
{
    public class StaticProduct : Product
    {
        public StaticProduct(int id, string name, decimal price)
            : base(id, name, price)
        {
        }

        public override decimal CalculateTotalPrice()
        {
            return Price * (1 + Tax);
        }
    }
}
