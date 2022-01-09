// See https://aka.ms/new-console-template for more information
//value types
//Console.WriteLine("Hello, World!");

byte number = 255; // 0-255 arası değer, 1 byte

short number5 = -32768; // max -32768 ile 32767 16 bit 
Console.WriteLine("short Number 5 is {0}", number5);

int number1 = 2147483647;//maximum integer değeri, 32 bit
int number2 = 1111111111;
Console.WriteLine("int Number 1 is {0}", number1);

long number3 = -9223372036854775808; //maximum 19 digit, 64 bit
long number4 = 9223372036854775807; //maximum 19 digit
Console.WriteLine("long Number 3 is {0}", number3);

bool condition = false;

char character = 'A'; //ascii character veri tutar

string city = "Ankara"; //char dizisidir

Console.WriteLine("Character is {0}", character);

Console.WriteLine("Character is {0}", (int)character);// ascii karşılığını verir

double doubleNumber = 10.4; //

Console.WriteLine("Double is {0}", doubleNumber);

decimal decimalNumber = 10.4M; //

Console.WriteLine("Decimal is {0}", decimalNumber);

Console.WriteLine(Days.Friday);

Console.WriteLine((int)Days.Friday);

var number7 = 10;

number7 = 'A';

//number = "A" hatalı atama
Console.WriteLine("var Number 7 is {0}", number7);

enum Days
{
    Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}
