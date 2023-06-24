Console.WriteLine("Inserire un percorso valido per il file: ");

string filePath = Console.ReadLine();

string content = File.ReadAllText(filePath); 
Console.WriteLine(content);
