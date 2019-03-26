using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otroSpace
{
  class Alumno:Persona
  {
    private float nota1;
    private float nota2;
    private float notaFinal;
    public static string colegio;
    private static Random rnd; // si no se declara un random estatico siempre tirara el mismo numero para todos los.next()


    public Alumno() : base() { }
    static Alumno() { rnd = new Random(); colegio = "UTN"; }//rnd inicializdo aca
    public Alumno(string nombre, string apellido, int legajo) : base(nombre, apellido, legajo) { }

    public void Estudiar()
    {
      
      float rand = (float)Math.Round(10 * rnd.NextDouble(), 1);
      if (rand < 4)
        this.nota1 = 2;
      else
        this.nota1 = rand;
      rand = (float)Math.Round(10 * rnd.NextDouble(), 1);
      if (rand < 4)
        this.nota2 = 2;
      else
        this.nota2 = rand;
    }

    public void CalcularFinal()
    {
      if (this.nota1 >= 4 && this.nota2 >= 4)
      {
        float rand= (float)Math.Round(10 * rnd.NextDouble(), 1);
        if (rand < 4)
          this.notaFinal = 2;
        else
          this.notaFinal = rand;
      }
      else
        this.notaFinal = -1;
    }

    public void Mostrar()
    {
      this.CalcularFinal();
      Console.WriteLine("Nombre:" + Apellido + " " + Nombre + "\n" + "Legajo: " + Legajo);
      if (this.notaFinal!=-1)
      {
        Console.WriteLine("Nota final: " + this.notaFinal);
      }
      else
        Console.WriteLine("Alumno desaprobado.");
    }

    
  }
}
