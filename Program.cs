using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proyecto04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";
            int contador = 0;
            int numero = 2;
            Console.WriteLine("Los numeros perfectos son:");
            while (contador < 4)
            {
                int total = 0;
                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        total += i;
                    }
                }
                if (total == numero)
                {
                    contador++;
                    Console.WriteLine("{0}", numero);
                }
                numero++;
            }
            Console.ReadKey();
        }
    }
}
