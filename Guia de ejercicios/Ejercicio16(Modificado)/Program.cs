using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using otroSpace;

namespace Ejemplo1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Alumno alumno1 = new Alumno("uno", "a", 1);
      Alumno alumno2 = new Alumno("dos", "b", 2);
      Alumno alumno3 = new Alumno("tres", "c", 3);

      alumno1.Estudiar();
      alumno2.Estudiar();
      alumno3.Estudiar();

      alumno1.Mostrar();
      alumno2.Mostrar();
      alumno3.Mostrar();

      Console.ReadKey();
    }
  }
}
