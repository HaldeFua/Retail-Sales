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
        string Name { get; }  
        decimal Price { get; }  
        decimal Tax { get; }
        
        decimal CalculateTotalPrice();

        string ToString();

    }
}
