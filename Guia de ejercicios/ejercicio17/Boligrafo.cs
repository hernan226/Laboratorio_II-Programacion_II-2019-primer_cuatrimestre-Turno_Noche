using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio17
{
  class Boligrafo
  {
    public const short cantidadTintaMaxima = 100;
    private ConsoleColor color;
    private short tinta;

    public Boligrafo(short tinta, ConsoleColor color)
    {
      this.color = color;
      this.tinta = tinta;
    }

    public ConsoleColor GetColor()
    {
      return this.color;
    }

    public short GetTinta()
    {
      return this.tinta;
    }
    /// <summary>
    /// Reutilizando codigo aunque no pidieron este ejercicio
    /// </summary>
    /// <param name="gasto">Cantidad de asteriscos a restar en tinta</param>
    /// <param name="iteracion">Cantidad de asteriscos a pintar</param>
    /// <returns></returns>
    private string Pintado(int gasto,int iteracion)
    {
      StringBuilder stb = new StringBuilder();
      for (int i = 0; i < iteracion; i++)
      {
        stb.Append("*");
      }      
      this.SetTinta((short)gasto);
      return stb.ToString();
    }

    public bool Pintar(int gasto, out string dibujo)
    {      
      if (gasto<=GetTinta())
      {
        dibujo = this.Pintado(gasto, gasto);
        return true;
      }
      else
      {
        dibujo = this.Pintado(gasto, tinta);
        return false;
      }
      
    }

    public void Recargar()
    {
      this.tinta = cantidadTintaMaxima;
    }

    private void SetTinta(short tinta)
    {
      if (tinta>0)
      {
        if ((tinta + this.tinta) >= cantidadTintaMaxima)
          this.Recargar();
        else
          this.tinta += tinta;
      }
      else
      {
        if ((this.tinta + tinta) >= 0)
          this.tinta += tinta;
        else
          this.tinta = 0;
      }

    }
  }
}
