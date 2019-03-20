using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
  class Program
  {
    static void Main(string[] args)
    {

      int num, suma = 0;
      bool okay;
      do
      {
        Console.WriteLine("Ingrese el numero a sumar");
        okay = int.TryParse(Console.ReadLine(), out num);
        if (okay)
        {
          suma += num;
          Console.WriteLine("Suma actual: " + suma);
          Console.WriteLine("Continuar? (S/N)");
          okay = ValidarRespuesta.ValidarS_N(Console.ReadKey(true).KeyChar);
        }
        else
        {
          Console.WriteLine("Error, reingrese");
          okay = true;
        }
      } while (okay);
    }
  }
}
