using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
  class MiClase
  {
    public static void calcular()
    {
      bool okay; int num1;
      do
      {        
        Console.WriteLine("Ingrese el numero");
        okay = int.TryParse(Console.ReadLine(), out num1);
        if (okay && num1 > 0)
          Console.WriteLine("el cuadrado es: " + Math.Pow(num1, 2) + "\n" + "el cubo es: " + Math.Pow(num1, 3));
        else
        {
          Console.WriteLine("ERROR. Reingrese numero");
          okay = false;
        }
          
      } while (!okay);

    }
  }
}
