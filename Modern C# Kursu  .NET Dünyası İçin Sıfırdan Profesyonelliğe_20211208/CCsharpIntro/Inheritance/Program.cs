
Console.WriteLine("Hello, World!");

class PersonManager
{
    public void Add()
    {
        PersonManager personManager = new PersonManager();
        personManager.Add();

        CustomerManager customerManager = new CustomerManager();
        customerManager.GetBestCustomer();

        EmployeeManager employeeManager = new EmployeeManager();
        employeeManager.GetBestEmployee();
    }

    public void Update()
    {
        Console.WriteLine("Güncellendi");
    }
}

class CustomerManager : PersonManager
{
    public void GetBestCustomer()
    {

    }
}

class EmployeeManager : PersonManager
{
    public void GetBestEmployee()
    {

    }
}

class Person
{
    public int Id { get; set; }

    public string? NationalIdentity { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }
}

class Employe : Person
{
    public string? EmployeeNumber { get; set; }
}

class Customer : Person
{
    public string? CreditCardNumber { get; set; }
}