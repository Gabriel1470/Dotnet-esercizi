using Dotnet_esercizi;

DeniedCl denied = new DeniedCl();
Console.WriteLine(denied.Get_Private());
Console.WriteLine(denied.Get_Protected());
Console.WriteLine(denied._internal);
Console.WriteLine(denied._public);