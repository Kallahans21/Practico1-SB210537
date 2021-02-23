using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2CODIGO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Suma y producto de números";
            Double n1, n2, n3, n4, suma, producto;
            Console.WriteLine("Bienvenido, para comenzar, digite el primer número: ");
            n1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite el segundo número: ");
            n2 = Double.Parse(Console.ReadLine()); 
            Console.WriteLine("\nDigite el tercer número: ");
            n3 = Double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite el cuerto número: ");
            n4 = Double.Parse(Console.ReadLine());

            suma = n1 + n2;
            producto = n3 * n4;
            Console.WriteLine("\nLa suma de " + n1 + " + " + n2 + " es de " + suma + "\nEl producto de " + n3 + " x " + n4 + " es de " + producto);
            Console.ReadKey();


        }
    }
}
