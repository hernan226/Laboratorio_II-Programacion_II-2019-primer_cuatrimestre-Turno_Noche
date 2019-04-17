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

    public float CostoLlamada
    {
      get
      {
        return this.costo;
      }
    }
  }
}
