
Console.WriteLine("Primo numero:");

string textA =Console.ReadLine();
int numberA = int.Parse(textA);

Console.WriteLine("Secondo numero:");
string textB =Console.ReadLine();
int numberB = int.Parse(textB);

int result = numberA + numberB;
Console.Write($"Il risultato di {numberA} + {numberB} = ");
Console.WriteLine(result); 