using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
  public class NoIngresoNadaException : Exception
  {
    public NoIngresoNadaException()
      : base() { }
    public NoIngresoNadaException(string mensaje)
      : base(mensaje) { }
    public NoIngresoNadaException(string mensaje, Exception e)
      : base(mensaje, e) { }
  }
}
