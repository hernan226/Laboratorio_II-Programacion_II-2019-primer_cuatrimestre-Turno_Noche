using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Llamada
  {
    protected float duracion;
    protected string numeroDeDestino;
    protected string numeroDeOrigen;

    public Llamada(float duracion, string numeroDeDestino, string numeroDeOrigen)
    {
      this.duracion = duracion;
      this.numeroDeDestino = numeroDeDestino;
      this.numeroDeOrigen = numeroDeOrigen;
    }

    #region Propiedades
    public float Duracion
    {
      get
      {
        return this.duracion;
      }
    }

    public string NumeroDeDestino
    {
      get
      {
        return this.numeroDeDestino;
      }
    }

    public string NumeroDeOrigen
    {
      get
      {
        return this.numeroDeOrigen;
      }
    }

    public virtual float CostoDeLlamada { get; }
    #endregion


    public static int OrdenarPorDuracion(Llamada call1, Llamada call2)
    {
      if (call1.Duracion > call2.Duracion)
        return (int)call2.Duracion;
      else
        return (int)call1.Duracion;
    }

    public virtual string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Duracion: "+this.Duracion);
      sb.AppendLine("Destino: " + this.NumeroDeDestino);
      sb.AppendLine("Origen: " + this.NumeroDeOrigen);
      return sb.ToString();
    }

    public enum TipoLlamada
    {
      Local,
      Provincial,
      Todas
    }





  }
}
