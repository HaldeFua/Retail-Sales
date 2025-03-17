using Retail_Sales;

var wine = new StaticProduct(111, "Botella de vino Cabernet Sauvignon", 85000m);
var peanuts = new StaticProduct(222, "Bolsa de Maní salado La especial", 9500m);
var chocolate = new StaticProduct(333, "Barra de chocolate Hershey's grande", 20000m);
var grapes = new VariableProduct(444, "Uvas chilenas", 13000m, "Kilos", 2.5m);  
var cheese = new VariableProduct(555, "Queso cheddar", 50000m, "Kilos", 0.5m); 

//Factura 1: Productos individuales
var invoice1 = new Invoice();
invoice1.AddProduct(wine);
invoice1.AddProduct(peanuts);
invoice1.AddProduct(chocolate);
invoice1.AddProduct(grapes);
invoice1.AddProduct(cheese);

Console.WriteLine("Factura 1: Productos Individuales");
Console.WriteLine(invoice1.ToString());

//Factura 2: Producto Compuesto "Ancheta"
var ancheta = new CompositeProduct(999, "Ancheta especial", 0.12m); // 12% de descuento
ancheta.AddProduct(wine);
ancheta.AddProduct(peanuts);
ancheta.AddProduct(cheese);

var invoice2 = new Invoice();
invoice2.AddProduct(ancheta);
invoice2.AddProduct(chocolate);
invoice2.AddProduct(grapes);

Console.WriteLine("\nFactura 2: Producto Compuesto 'Ancheta' + Otros Productos");
Console.WriteLine(invoice2.ToString());