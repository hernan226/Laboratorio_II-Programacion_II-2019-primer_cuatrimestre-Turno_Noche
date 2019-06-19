using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
  public class Xml<T> : IArchivo<T>
  {
    public void Guardar(string archivo, T datos)
    {
      XmlSerializer xs = new XmlSerializer(typeof(T));
      try
      {
        using (XmlTextWriter xtw = new XmlTextWriter(archivo, Encoding.UTF8))
          xs.Serialize(xtw, datos);        
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public void Leer(string archivo, out T dato)
    {
      XmlSerializer xs = new XmlSerializer(typeof(T));
      T aux;
      try
      {
        using (XmlTextReader xtr = new XmlTextReader(archivo))
          aux = (T)xs.Deserialize(xtr);
        dato = aux;
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}
