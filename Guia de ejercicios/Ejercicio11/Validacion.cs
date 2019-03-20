using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
  class Validacion
  {
    public static bool Validar(int numero, int min, int max)
    {
      if (numero >= min && numero <= max)
        return true;
      else
        return false;
    }
  }
}
