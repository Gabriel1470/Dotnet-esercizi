using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_esercizi
{
    internal class Gatto : Animal
    {
        ovveride public void Speak()
        {
            Console.WriteLine("Miaoo miaaooooo!!");
        }
    }
}