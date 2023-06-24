Console.WriteLine("Inserisci una parola o una frase");
string? input = Console.ReadLine();

if (input == null || input == "")
{
    Console.WriteLine("Input non valido");
    Environment.Exit(1);
    return;
}

input = input.Replace(" ", "").ToLower();
string reverse = new(input.Reverse().ToArray());

if (input.Equals(reverse))
{
    Console.WriteLine("E un palindromo");
}
else
{
    Console.WriteLine("Non e un  palindromo");
}