using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4CÓDIGO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Números mayores";
            double n1,n2,n3;
            Console.WriteLine("Digite el primer número");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo número");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el tercer número");
            n3 = double.Parse(Console.ReadLine());

            if (n1>n2 && n1>n3)
            {
                Console.WriteLine("El número mayor es " + n1);

            }
            else
            {
                if (n2>n3)
                {
                    Console.WriteLine("El número mayor es " + n2);
                }
                else
                {
                    Console.WriteLine("El número mayor es " + n3);
                }
            }

            Console.ReadKey();
        }
    }
}
