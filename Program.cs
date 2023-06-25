Console.WriteLine("Option 1: Celsius to Fahrenheit / Option 2: Fahrenheit to Celsius ");

int choise = int.Parse(Console.ReadLine());
int num = 0;
if (choise != 1 && choise != 2)
{
    Console.WriteLine("Not a valid input");
    Environment.Exit(1);
}else 
{
    Console.WriteLine("Insert a number to convert:");
    num = int.Parse(Console.ReadLine());
}if (choise == 1)
{
double result = (num * 1.8) + 32;
Console.WriteLine($"{num} degrees Celsius equals {result} degrees Fahrenheit");
}else
{
double result = (num - 32) * 0.5556;
    Console.WriteLine($"{num} degrees Fahrenheit equals {result} degrees Celsius");
}

