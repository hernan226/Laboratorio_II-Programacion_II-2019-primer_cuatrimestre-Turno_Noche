using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otroSpace
{
   class Persona
  {
    private string _nombre;
    public string Nombre { get => _nombre; set => _nombre = value; }
    private string _apellido;
    public string Apellido { get => _apellido; set => _apellido = value; }
    private int _legajo;
    public int Legajo { get => _legajo; set => _legajo = value; }

    public Persona()
    {
      this.Nombre = "";
      this.Apellido = "";
      this.Legajo = 0;
    }

    public Persona(string name, string apel, int legajo)
    {
      this.Nombre = name;
      this.Apellido = apel;
      this.Legajo = legajo;
    }

    
  }
}
