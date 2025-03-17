using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Sales
{
    internal class CompositeProduct : Product
    {
        private List<Product> _products;
        private decimal _discount;

        public CompositeProduct(int id, string name, decimal discount)
        : base(id, name, 0)
        {
            _products = new List<Product>();
            _discount = discount;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public override decimal CalculateTotalPrice()
        {
            decimal total = 0;

            foreach (var product in _products)
            {
                total += product.CalculateTotalPrice();
            }

            return total * (1 - _discount);
        }

        public override string ToString()
        {
            var productDetails = string.Join("\n", _products.Select(p => $"  - {p.ToString()}"));
            return $"{base.ToString()} | Descuento: {_discount * 100}%\nProductos incluidos:\n{productDetails}";
        }

    }
}
