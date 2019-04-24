using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Local:Llamada
  {
    private float costo;

    public Local(Llamada call, float costo):base(call.Duracion, call.NumeroDeDestino, call.NumeroDeOrigen)
    {
      this.costo = costo;
    }

    public Local(string origen, float duracion, string destino, float costo)
      : base(duracion, destino, origen)
    {
      this.costo = costo;
    }

    public override float CostoDeLlamada
    {
      get
      {
        return this.CalcularCosto();
      }
    }

    public override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(base.Mostrar());
      sb.AppendLine("Costo: " + this.CostoDeLlamada);
      return " ";
    }

    private float CalcularCosto()
    {
      return this.costo*base.Duracion;
    }

  }
}
