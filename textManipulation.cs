string Text, Revers = "";
int Length;
Console.Write("Scrivi quel che vuoi : ");
Text = Console.ReadLine();
Length = Text.Length - 1;
while (Length >= 0)
{
Revers = Revers + Text[Length];
Length--;
}
Console.WriteLine("Capovolgo il suo testo  {0}", Revers);
Console.ReadLine();