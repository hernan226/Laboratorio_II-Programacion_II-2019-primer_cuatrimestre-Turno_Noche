using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
  class Calculador
  {
    private int acumulador;

    public Calculador() { this.acumulador = 0; }

    public void Acumular(string sBin)
    {
      this.acumulador += Conversor.BinarioEntero(sBin);
    }

    public string getResultadoBinario()
    {

      return Conversor.EnteroBinario(this.acumulador);
    }

    public int getResultadoEntero()
    {
      return this.acumulador;
    }
  }
}
