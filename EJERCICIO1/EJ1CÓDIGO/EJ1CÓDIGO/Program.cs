using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1CÓDIGO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora de pago por artículo";
            double precio, cantarticulos, total;
            Console.WriteLine("Bienvenido, para calcular el precio a pagar escriba el precio individual del artículo: \n");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ahora, por favor digite la cantidad de artículos que usted lleva: \n");
            cantarticulos = double.Parse(Console.ReadLine());
            total = precio * cantarticulos;
            Console.WriteLine("El total a pagar por "+cantarticulos+ " artículo/s es de: $"+total);
            Console.ReadKey();


        }
    }
}
