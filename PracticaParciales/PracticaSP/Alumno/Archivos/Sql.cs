using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
  public class Sql : IArchivo<Queue<Patente>>
  {
    private SqlCommand comando;
    private SqlConnection conexion;

    public Sql()
    {
      conexion = new SqlConnection(Properties.Settings.Default.Valor);
      comando = new SqlCommand();
      comando.CommandType = CommandType.Text;
      comando.Connection = conexion;
    }

    public void Guardar(string archivo, Queue<Patente> datos)
    {
      try
      {
        conexion.Open();
        foreach (var item in datos)
        {
          comando.CommandText = string.Format("INSERT INTO {0} (codPatente, tipoCodigo) " +
            "VALUES({1}, {2})", archivo, item.CodigoPatente, item.TipoCodigo);

          comando.ExecuteNonQuery();
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
      finally
      {
        conexion.Close();
      }
    }

    public void Leer(string archivo, out Queue<Patente> dato)
    {

      dato = new Queue<Patente>();
      Patente.Tipo aux;
      comando.CommandText = "SELECT * FROM" + archivo;

      try
      {
        conexion.Open();
        SqlDataReader dataReader = comando.ExecuteReader();

        while (dataReader.Read())
        {
          if (Enum.TryParse(dataReader["tipoCodigo"].ToString(), out aux))
            dato.Enqueue(new Patente(dataReader["codPatente"].ToString(), aux));
          else
            throw new Exception();
        }
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        conexion.Close();
      }
    }
  }
}
