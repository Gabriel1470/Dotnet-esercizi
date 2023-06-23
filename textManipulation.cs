Console.WriteLine("Scrivi qualcosa da capovolgere ");
string input = Console.ReadLine();

Console.WriteLine("Quel qualcosa capovolto: "+ new string(input.Reverse().ToArray()));