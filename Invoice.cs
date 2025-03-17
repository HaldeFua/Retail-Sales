using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Sales
{
    public class Invoice
    {
        private static int _invoiceCounter = 0;
        private int _invoiceNumber;
        private List<IProduct> _products;

        public Invoice()
        {
            _products = new List<IProduct>();
            _invoiceNumber = ++_invoiceCounter;
        }

        public void AddProduct(IProduct product)
        {
            _products.Add(product);
        }

        public decimal CalculateTotalAmount()
        {
            decimal total = 0;
            foreach (var product in _products)
            {
                total += product.CalculateTotalPrice();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder invoiceDetails = new StringBuilder();

            invoiceDetails.AppendLine($"INVOICE # {_invoiceNumber}");
            invoiceDetails.AppendLine("-------------------------------------------------");

            foreach (var product in _products)
            {
                invoiceDetails.AppendLine(product switch
                {
                    StaticProduct staticProduct => FormatStaticProduct(staticProduct),
                    VariableProduct variableProduct => FormatVariableProduct(variableProduct),
                    CompositeProduct compositeProduct => FormatCompositeProduct(compositeProduct),
                    _ => string.Empty
                });
            }

            invoiceDetails.AppendLine("================================");
            invoiceDetails.AppendLine($"TOTAL: ${CalculateTotalAmount():N2}");

            return invoiceDetails.ToString();
        }

        private string FormatStaticProduct(StaticProduct product)
        {
            return $"{product.ID} {product.Name}\n" +
                   $" Price......: ${product.Price:N2}\n" +
                   $" Tax........: {product.Tax * 100:N2} %\n" +
                   $" Value......: ${product.CalculateTotalPrice():N2}";
        }

        private string FormatVariableProduct(VariableProduct product)
        {
            return $"{product.ID} {product.Name}\n" +
                   $" Measurement.: {product.UnitOfMeasure}\n" +
                   $" Quantity...: {product.Quantity:N2}\n" +
                   $" Price......: ${product.Price:N2}\n" +
                   $" Tax........: {product.Tax * 100:N2} %\n" +
                   $" Value......: ${product.CalculateTotalPrice():N2}";
        }

        private string FormatCompositeProduct(CompositeProduct product)
        {
            string productNames = string.Join(", ", product.Products.Select(p => p.Name));
            return $"{product.ID} {product.Name}\n" +
                   $" Products...: {productNames}\n" +
                   $" Discount...: {product.Discount * 100:N2} %\n" +
                   $" Value......: ${product.CalculateTotalPrice():N2}";
        }
    }

}
