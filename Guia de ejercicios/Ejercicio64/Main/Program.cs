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
      Negocio negocio = new(new Caja(), new Caja());
    }
  }
}
