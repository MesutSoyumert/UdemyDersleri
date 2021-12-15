//interface newlenemez
//IPersonManager customerManager = new CustomerManager();
//customerManager.Add();

//IPersonManager employeeManager = new EmployeeManager();
//employeeManager.Add();

ProjectManager projectManager = new ProjectManager();

projectManager.Add(new EmployeeManager());
projectManager.Update(new EmployeeManager());

projectManager.Add(new CustomerManager());
projectManager.Update(new CustomerManager());

projectManager.Add(new InternManager());
projectManager.Update(new InternManager());

interface IPersonManager
{
    //unimplemented operation
    void Add();

    void Update();
}

class CustomerManager : IPersonManager
{
    public void Add()
    {
        //müşteri ekleme kodları
        Console.WriteLine("Müşteri eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri güncellendi");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        //çalışan ekleme kodları
        Console.WriteLine("Çalışan eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Çalışan güncellendi"); ;
    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajyer eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Stajyer güncellendi");
    }
}

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }

    public void Update(IPersonManager personManager)
    {
        personManager.Update();
    }
}
