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
        public List<Product> Products => _products;
        public decimal Discount;

        public CompositeProduct(int id, string name, decimal discount)
        : base(id, name, 0)
        {
            _products = new List<Product>();
            Discount = discount;
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

            return total * (1 - Discount);
        }

        public override string ToString()
        {
            var productDetails = string.Join("\n", _products.Select(p => $"  - {p.ToString()}"));
            return $"{base.ToString()} | Descuento: {Discount * 100}%\nProductos incluidos:\n{productDetails}";
        }

    }
}
