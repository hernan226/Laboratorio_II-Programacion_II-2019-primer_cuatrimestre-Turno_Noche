using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      Libro miLibro = new Libro();

      miLibro[0] = "condorito";
      miLibro[1] = "don quijote";
      miLibro[15] = "martin fierro";
      miLibro[0] = "El eternauta";

      Console.WriteLine(miLibro.Mostrar());

      Console.ReadKey();

    }
  }
}
