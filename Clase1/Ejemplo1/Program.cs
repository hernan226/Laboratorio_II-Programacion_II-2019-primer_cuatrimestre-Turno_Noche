using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
  class Program
  {
   static int num1;
    static double comas=20;
   static string palabra= "Hola mundo.";
   static bool boleano;

    static void Main(string[] args)
    {
      num1 = (int)comas;
      //num1 = int.Parse(palabra);
      boleano = int.TryParse(palabra, out num1);
      if (!boleano)
      {
        Console.WriteLine(palabra);
        Console.WriteLine(boleano.ToString());
        Console.ReadKey();
      }
    }
  }
}
