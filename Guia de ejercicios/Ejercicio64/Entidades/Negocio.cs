using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Negocio
  {
    private Caja[] caja;
    private List<string> clientes;

    public Negocio(Caja c1, Caja c2)
    {
      this.caja = new Caja[2];
      this.clientes = new List<string>();
      this.caja[0] = c1;
      this.caja[1] = c2;
    }

    public Caja Caja1
    {
      get => this.caja[0];
    }
    public Caja Caja2
    {
      get => this.caja[1];
    }
    public List<string> Clientes
    {
      get => clientes;
    }

    public void AsignarCaja()
    {

    }
  }
}
