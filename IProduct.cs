using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Sales
{
    public interface IProduct
    {

        int ID { get; }        
        string Nombre { get; }  
        decimal Precio { get; }  
        decimal Impuesto { get; }
        
        decimal CalcularPrecioTotal();

        string ToString();

    }
}
