using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_esercizi
{
    internal  class Animal
    {
        public string Name = "";
        public int Age = 0;

      virtual  public  void Speak();
      {
Console.WriteLine("Suono animalesco!!!");
      }
    } 
}