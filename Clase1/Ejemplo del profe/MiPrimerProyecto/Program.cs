using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto
{
    class Program
    {
        static int miEntero;
        static double miDouble = 20;
        static string miPalabra;
        static bool miBoolean;
        

        static void Main(string[] args)
        {

            int operador, primerNumero, segundoNumero;


            MiClase.mover();
            Console.WriteLine("Ingrese el operador");
            Console.WriteLine("1- Sumar");
            Console.WriteLine("2- Restar");
            Console.WriteLine("3- Multiplicar");
            Console.WriteLine("4- Dividir");
            int.TryParse(Console.ReadLine(), out operador);
            Console.WriteLine("Ingrese el primer número");
            int.TryParse(Console.ReadLine(), out primerNumero);
            Console.WriteLine("Ingrese el primer número");
            int.TryParse(Console.ReadLine(), out segundoNumero);
            miSwitch(operador, primerNumero, segundoNumero);

            
            Console.ReadKey();
            
        }

        static void miSwitch(int operador, int primerIngreso, int segundoIngreso)
        {
            Console.WriteLine("Resultado:");
            switch (operador)
            {
                case 1:
                    Console.WriteLine(primerIngreso + segundoIngreso);
                    break;
                case 2:
                    Console.WriteLine(primerIngreso - segundoIngreso);
                    break;
                case 3:
                    Console.WriteLine(primerIngreso * segundoIngreso);
                    break;
                case 4:
                    Console.WriteLine(primerIngreso / segundoIngreso);
                    break;
            }

        }
        
    }
}
