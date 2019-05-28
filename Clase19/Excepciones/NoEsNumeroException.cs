using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
  public class NoEsNumeroException : Exception
  {
    public NoEsNumeroException()
      : base() { }
    public NoEsNumeroException(string mensaje)
      : base(mensaje) { }
    public NoEsNumeroException(string mensaje, Exception e)
      : base(mensaje, e) { }
  }
}
