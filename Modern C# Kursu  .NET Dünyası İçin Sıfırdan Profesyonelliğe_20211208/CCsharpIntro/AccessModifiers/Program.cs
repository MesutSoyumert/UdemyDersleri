using AccessModifiers;



Customer customer = new Customer();

House house = new House();
house.Id = 1;
house.City = "Ankara";

Console.WriteLine("Hello, World!");

class Customer
{
    House house1 = new House();
}