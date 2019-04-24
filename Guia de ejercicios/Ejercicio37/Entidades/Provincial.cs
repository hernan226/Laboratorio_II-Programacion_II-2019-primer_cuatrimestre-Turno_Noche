using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Provincial:Llamada
  {
    private const float Franja1precio = (float)0.99;
    private const float Franja2precio = (float)1.25;
    private const float Franja3precio = (float)0.66;
    Franja franjaHoraria;

    public Provincial(Franja miFranja, Llamada call)
      : base(call.Duracion, call.NumeroDeDestino, call.NumeroDeOrigen)
    {
      this.franjaHoraria = miFranja;
    }

    public Provincial(string origen, Franja miFranja, string destino, float duracion)
      : base(duracion, destino, origen)
    {
      this.franjaHoraria = miFranja;
    }

    public override float CostoDeLlamada
    {
      get
      {
        return this.CalcularCosto();
      }
    }

    private float CalcularCosto()
    {
      switch (this.franjaHoraria)
      {
        case Franja.Franja_1:
          return base.Duracion * Franja1precio;
        case Franja.Franja_2:
          return base.Duracion * Franja2precio;
        case Franja.Franja_3:
          return base.Duracion * Franja3precio;
        default:
          return 0;
      }
    }

    public override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(base.Mostrar());
      sb.AppendLine("Costo: "+this.CostoDeLlamada);

      return sb.ToString();
    }

    public enum Franja
    {
      Franja_1,
      Franja_2,
      Franja_3
    }
  }
}
