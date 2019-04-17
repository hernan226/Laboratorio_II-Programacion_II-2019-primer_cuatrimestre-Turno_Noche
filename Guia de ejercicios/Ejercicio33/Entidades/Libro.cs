using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Libro
  {
    List<string> paginas;

    public Libro()
    {
      this.paginas = new List<string>();
    }

    public string this[int i]
    {
      get
      {
        if (paginas[i] == null)
          return "";
        else
          return paginas[i];
      }

      set
      {
        if (i >= paginas.Count)
          paginas.Add(value);
        else
          paginas[i] = value;
      }
    }

    public string Mostrar()
    {
      string retorno = "Libros: ";

      foreach (string item in this.paginas)
      {
        retorno = retorno + item + ", ";
      }
      return retorno;
    }
  }
}
