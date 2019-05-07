using System;
using System.Collections.Generic;
using System.Linq;

namespace TestOrdenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ordenar> lista = new List<Ordenar>();

            Ordenar p1 = new Ordenar(16, "dieciseis");
            Ordenar p2 = new Ordenar(2, "dos");
            Ordenar p3 = new Ordenar(8, "ocho");
            Ordenar p4 = new Ordenar(7, "siete");
            Ordenar p5 = new Ordenar(546, "quinientos cuarenta y seis");
            Ordenar p6 = new Ordenar(1, "uno");

            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);
            lista.Add(p4);
            lista.Add(p5);
            lista.Add(p6);

            IEnumerable<Ordenar> ordenada = lista.OrderBy(orden => orden.id);

            foreach (var item in ordenada)
            {
                Console.WriteLine("" + item.nombre);
            }
            Console.ReadKey();
        }
    }

    class Ordenar
    {
        public int id;
        public string nombre;

        public Ordenar(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}
