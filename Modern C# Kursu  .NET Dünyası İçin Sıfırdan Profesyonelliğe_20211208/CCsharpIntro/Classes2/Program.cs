// See https://aka.ms/new-console-template for more information


using Classes2;

Product product1 = new Product()
{
    ProductName = "Laptop",
    UnitPrice = 5000,
    UnitsInStock = 5
};


ProductManager productManager = new ProductManager();
productManager.Add(product1);
