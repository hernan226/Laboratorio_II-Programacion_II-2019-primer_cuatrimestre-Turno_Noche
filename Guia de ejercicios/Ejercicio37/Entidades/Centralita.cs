using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Centralita
  {
    private List<Llamada> listaDeLlamadas;
    private string razonSocial;

    #region Propiedades
    public float GananciaPorLocal
    {
      get
      {
        return this.CalcularGanancias(Llamada.TipoLlamada.Local);
      }
    }

    public float GananciaPorProvincial
    {
      get
      {
        return this.CalcularGanancias(Llamada.TipoLlamada.Provincial);
      }
    }

    public float GananciaPorTotal
    {
      get
      {
        return this.CalcularGanancias(Llamada.TipoLlamada.Todas);
      }
    }

    public List<Llamada> Llamadas
    {
      get
      {
        return this.listaDeLlamadas;
      }
    }
    #endregion
    
    public Centralita()
    {
      this.listaDeLlamadas = new List<Llamada>();
    }

    public Centralita(string nombreDeLaEmpresa):this()
    {
      this.razonSocial = nombreDeLaEmpresa;
    } 

    private float CalcularGanancias(Llamada.TipoLlamada tipo)
    {
      float count=0;
      if (tipo == Llamada.TipoLlamada.Local)
      {
        foreach (Local item in this.Llamadas)
        {
          count += item.CostoDeLlamada;
        }
      }
      else if (tipo == Llamada.TipoLlamada.Provincial)
      {
        foreach (Provincial item in this.Llamadas)
        {
          count += item.CostoDeLlamada;
        }
      }
      else
      {
        foreach (Llamada item in this.Llamadas)
        {
          count += item.CostoDeLlamada;
        }
      }
      return count;
    }

    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Razom social: " + this.razonSocial);
      sb.AppendLine("Ganancias totales: " + this.GananciaPorTotal);

      sb.AppendLine("Llamadas locales: ");
      foreach (Local item in listaDeLlamadas)
      {
        sb.AppendLine(item.Mostrar());
      }
      sb.AppendLine("Ganancias locales: " + this.GananciaPorLocal);

      sb.AppendLine("Llamadas provinciales: ");
      foreach (Provincial item in listaDeLlamadas)
      {
        sb.AppendLine(item.Mostrar());
      }
      sb.AppendLine("Ganancias provinciales: " + this.GananciaPorProvincial);

      return sb.ToString();
    }

    public void OrdenarLlamadas()
    {
      Llamadas.Sort(Llamada.OrdenarPorDuracion);
    }
  }
}
