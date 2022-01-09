
Add();
Add(); 
Add();
Add(); 

var result = Add2(2, 3);
Console.WriteLine(result);

result = Add2(3);
Console.WriteLine(result);


static void Add()
{
    Console.WriteLine("Added !");
}

static int Add2(int number1, int number2=30)
{
    var result = number1 + number2;
    return result;
}