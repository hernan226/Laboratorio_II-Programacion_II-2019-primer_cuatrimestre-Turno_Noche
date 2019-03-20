using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
  class MiClase
  {
    static int num1; static int num2; static int num3; static int num4; static int num5;
    static bool okay; static int mayor; static int menor; static int promedio;
    public static void Numeros()
    {
      Console.WriteLine("Ingrese pimer numero");
      okay = int.TryParse(Console.ReadLine(), out num1);
      if (okay)
      {
        Console.WriteLine("Ingrese segundo numero");
        okay = int.TryParse(Console.ReadLine(), out num2);
        if (okay)
        {
          Console.WriteLine("Ingrese tercer numero");
          okay = int.TryParse(Console.ReadLine(), out num3);
          if (okay)
          {
            Console.WriteLine("Ingrese cuarto numero");
            okay = int.TryParse(Console.ReadLine(), out num4);
            if (okay)
            {
              Console.WriteLine("Ingrese quinto numero");
              okay = int.TryParse(Console.ReadLine(), out num5);
              if (okay)
              {
                

              }
            }
          }
        }
      }
    }
  }
}
