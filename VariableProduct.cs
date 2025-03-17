using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Sales
{
    internal class VariableProduct : Product
    {
        
        public string UnitOfMeasure { get; private set; }
        public decimal Quantity { get; private set; }

        public VariableProduct(int id, string name, decimal price, string unitOfMeasure, decimal quantity)
       : base(id, name, price)
        {
            UnitOfMeasure = unitOfMeasure;
            Quantity = quantity;
        }

        public override decimal CalculateTotalPrice()
        {
            return (Price * Quantity) * (1 + Tax);
        }

        public override string ToString()
        {
            return $"{base.ToString()} | Cantidad: {Quantity} {UnitOfMeasure}";
        }


    }
}
