using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio17
{
  class Program
  {
    static void Main(string[] args)
    {
      Boligrafo boliRed = new Boligrafo(50, ConsoleColor.Red);
      Boligrafo boliBlu = new Boligrafo(100, ConsoleColor.Blue);
      string retorno;

      bool pudo = boliBlu.Pintar(600, out retorno);
      if (!pudo)
        Console.Write("Solo pudo pintar esto: ");
      Console.ForegroundColor = boliBlu.GetColor();
      Console.WriteLine(retorno);
      Console.ReadKey();

      pudo = boliRed.Pintar(40, out retorno);
      if (!pudo)
        Console.Write("Solo pudo pintar esto: ");
      Console.ForegroundColor = boliRed.GetColor();
      Console.WriteLine(retorno);
      Console.ReadKey();
    }
  }
}
