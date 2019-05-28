using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
  public class NoSeCreoException : Exception
  {
    public NoSeCreoException()
      : base() { }
    public NoSeCreoException(string mensaje)
      : base(mensaje) { }
    public NoSeCreoException(string mensaje, Exception e)
      : base(mensaje, e) { }
  }
}
