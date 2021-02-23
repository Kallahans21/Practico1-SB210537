using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3CODIGO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora de promedio";
            double nota1, nota2, nota3, prom;
            Console.WriteLine("Bienvenido, para comenzar a calcular su promedio y su estado actual, por favor, ingrese su primera nota");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, escriba la segunda nota");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, escriba la tercera nota");
            nota3 = double.Parse(Console.ReadLine());

            prom = (nota1 + nota2 + nota3) / 3;

            if (prom >= 7) 
            {
                Console.WriteLine("Su promedio es de: " + prom + ". Estado actual: Promocionado.");
            }
            else
            {
                if (prom >=4)
                {
                    Console.WriteLine("Su promedio es de: " + prom + ". Estado actual: Regular.");
                }
                else
                {
                    Console.WriteLine("Su promedio es de: " + prom + ". Estado actual: Reprobado.");
                }
            }

            Console.ReadKey();
        }
    }
}
