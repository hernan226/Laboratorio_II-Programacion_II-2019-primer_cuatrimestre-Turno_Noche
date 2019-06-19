using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Archivos
{
  public class Texto : IArchivo<Queue<Patente>>
  {
    public void Guardar(string archivo, Queue<Patente> datos)
    {
      try
      {
        using (StreamWriter sw = new StreamWriter(archivo, true))
        {
          foreach (var item in datos)
          {
            sw.WriteLine(item.ToString());
          }
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public void Leer(string archivo, out Queue<Patente> dato)
    {
      string Recuperado;
      Queue<Patente> aux = new Queue<Patente>();
      try
      {
        using (StreamReader sr = new StreamReader(archivo))
        {
          while ((Recuperado = sr.ReadLine()) != null)
          {
            aux.Enqueue(new Patente(Recuperado, Patente.Tipo.Mercosur));
          }
        }

        dato = aux;
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}
