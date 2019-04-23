using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Ejercicio38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº38-39 Guía 2017";
            SobreSobreescrito sobrecarga = new SobreSobreescrito();
            Console.WriteLine(sobrecarga.ToString());
            string objeto = "¡Este es mi método ToString sobreescrito!";
            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(sobrecarga.Equals(objeto));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.GetHashCode());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.MiMetodo());
            Console.ReadKey();
        }
    }
}
