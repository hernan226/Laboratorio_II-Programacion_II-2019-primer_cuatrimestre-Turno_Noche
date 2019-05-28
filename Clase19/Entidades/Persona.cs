using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.IO;


namespace Entidades
{
  [Serializable]
  public class Persona
  {
    private string nombre;
    private string apellido;
    private int dni;
    private string tarjeta;

    public Persona()
    {

    }

    public Persona(string nombre, string apellido, string dni, string tarjeta)
    {
      this.Nombre = nombre;
      this.Apellido = apellido;
      try
      {
        this.Dni = dni;
      }
      catch (NoEsNumeroException e)
      {
        throw e;
      }
      this.tarjeta = tarjeta;
    }

    public string Nombre
    {
      get
      {
        return this.nombre;
      }
      set
      {
        if (value == "")
        {
          throw new NoIngresoNadaException
            ("El casillero 'Nombre' esta vacio");
        }
        else
          this.nombre = value;
      }
    }
    public string Apellido
    {
      get
      {
        return this.apellido;
      }
      set
      {
        if (value == "")
        {
          throw new NoIngresoNadaException
            ("El casillero 'Apellido' esta vacio");
        }
        else
          this.apellido = value;
      }
    }
    public string Dni
    {
      get
      {
        return this.dni.ToString();
      }
      set
      {
        int aux;
        if (value == "")
        {
          throw new NoIngresoNadaException
            ("El casillero 'DNI' esta vacio");
        }
        if (int.TryParse(value, out aux))
        {
          if (aux < 99999999 && aux > 11111111)
            this.dni = aux;
          else
            throw new NoEsNumeroException
              ("El numero debe ser entre 11111111 y 99999999");
        }
        else
          throw new NoEsNumeroException
            ("Lo ingresado no es un numero");
      }
    }

    public override string ToString()
    {
      return this.apellido + " " + this.nombre + " " + this.dni;
    }
  }
}
