using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EJercicio1
{
  class Calculadora
  {
    static double num1;
    static double num2;
    static char signo;
    static bool error;

    public static void Calculo()
    {
      Console.WriteLine("ingrese el primer numero:");
      error = double.TryParse(Console.ReadLine(), out num1);
      if (error)
      {
        Console.WriteLine("ingrese el segundo numero:");
        error = double.TryParse(Console.ReadLine(), out num2);
        if (error)
        {
          Console.WriteLine("ingrese la operacion(/, *, -, +):");
          signo = Console.ReadKey().KeyChar;
          if (signo == '/' || signo == '*' || signo == '-' || signo == '+')
          {
            Console.WriteLine("\n" + "El resultado es: " + Calculos(num1, num2, signo));
            Console.ReadKey();
          }
          else { Console.WriteLine("Error"); Console.ReadKey(); }
        }
        else { Console.WriteLine("Error"); Console.ReadKey(); }
      }
      else { Console.WriteLine("Error"); Console.ReadKey(); }
    }

    static double Calculos(double num1, double num2, char signo)
    {
      switch (signo)
      {
        case '+':
          return num1 + num2;
        case '-':
          return num1 - num2;
        case '/':
          return num1 / num2;
        case '*':
          return num1 * num2;
        default:
          return 0;
      }

      
    }
  }
}
