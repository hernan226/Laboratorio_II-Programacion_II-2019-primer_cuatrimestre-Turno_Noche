using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caja
    {
    private List<string> filaClientes;

    public Caja()
    {
      FilaClientes = new List<string>();
    }

    public string this[int i]
    {
      get => filaClientes[i];
      set => filaClientes[i] = value;
    }

    public List<string> FilaClientes
    {
      get => filaClientes;
      set => filaClientes = value;
    }

    public void AtenderClientes()
    {

    }
  }
}
