using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5CODIGO
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre1 = null, nombre2 = null, nombre3 = null;
    double hora1 = 0, hora2 = 0, hora3 = 0;
    double salario1 = 0, salario2 = 0, salario3 = 0;
    int cargo1 = 0, cargo2 = 0, cargo3 = 0;
    bool hayBono = false;

    /* Validacion de numeros negativos */
    Console.WriteLine("Ingrese el nombre del empleado 1");
    nombre1 = Console.ReadLine();
    Console.WriteLine("Ingrese el número de cargo. 1) Gerente, 2) Asistente, 3) Secretaria, 4) Otro");
    cargo1 = Int32.Parse(Console.ReadLine());
    if (cargo1 == 1) {
      hayBono = true;
    } else {
      hayBono = false;
    };
    do {
      Console.WriteLine("Ingrese las horas trabajadas del empleado 1");
      hora1 = Convert.ToDouble(Console.ReadLine());
    } while (hora1 <= 0);

    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Ingrese el nombre del empleado 2");
    nombre2 = Console.ReadLine();
    Console.WriteLine("Ingrese el número de cargo. 1) Gerente, 2) Asistente, 3) Secretaria, 4) Otro");
    cargo2 = Int32.Parse(Console.ReadLine());
    if (cargo2 == 2) {
      hayBono = true;
    } else {
      hayBono = false;
    };
    do {
      Console.WriteLine("Ingrese las horas trabajadas del empleado 2");
      hora2 = Convert.ToDouble(Console.ReadLine());
    } while (hora2 <= 0);

    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Ingrese el nombre del empleado 3");
    nombre3 = Console.ReadLine();
    Console.WriteLine("Ingrese el número de cargo. 1) Gerente, 2) Asistente, 3) Secretaria, 4) Otro");
    cargo3 = Int32.Parse(Console.ReadLine());
    if (cargo3 == 3) {
      hayBono = true;
    } else {
      hayBono = false;
    };
    do {
      Console.WriteLine("Ingrese las horas trabajadas del empleado 3");
      hora3 = Convert.ToDouble(Console.ReadLine());
    } while (hora3 <= 0);

    /* Calcular sueldos */
    if (hora1 <= 160) {
      salario1 = hora1 * 9.75;
    } else {
      double restantes = hora1 - 160;
      salario1 = 160 * 9.75;
      salario1 = (salario1) + restantes * 11.50;
      salario1 = salario1 - (salario1 * 0.2213);
    }
    if (!hayBono) {
      if (cargo1 == 1) {
        salario1 = salario1 + (salario1 * 0.10);
      } else {
        if (cargo1 == 2) {
          salario1 = salario1 + (salario1 * 0.05);
        } else {
          if (cargo1 == 3) {
            salario1 = salario1 + (salario1 * 0.03);
          } else {
            salario1 = salario1 + (salario1 * 0.02);
          }
        }
      }
    }

    if (hora2 <= 160) {
      salario2 = hora2 * 9.75;
    } else {
      double restantes = hora2 - 160;
      salario2 = 160 * 9.75;
      salario2 = (salario2) + restantes * 11.50;
      salario2 = salario2 - (salario2 * 0.2213);
    }
    if (!hayBono) {
      if (cargo2 == 1) {
        salario2 = salario2 + (salario2 * 0.10);
      } else {
        if (cargo2 == 2) {
          salario2 = salario2 + (salario2 * 0.05);
        } else {
          if (cargo2 == 3) {
            salario2 = salario2 + (salario2 * 0.03);
          } else {
            salario2 = salario2 + (salario2 * 0.02);
          }
        }
      }
    }

    if (hora3 <= 160) {
      salario3 = hora3 * 9.75;
    } else {
      double restantes = hora1 - 160;
      salario3 = 160 * 9.75;
      salario3 = (salario3) + restantes * 11.50;
      salario3 = salario3 - (salario3 * 0.2213);
    }
    if (!hayBono) {
      if (cargo3 == 1) {
        salario3 = salario3 + (salario3 * 0.10);
      } else {
        if (cargo3 == 2) {
          salario3 = salario3 + (salario3 * 0.05);
        } else {
          if (cargo3 == 3) {
            salario3 = salario3 + (salario3 * 0.03);
          } else {
            salario3 = salario3 + (salario3 * 0.02);
          }
        }
      }
    }
            if(salario1>salario2&&salario1>salario3)
            {
               Console.WriteLine(!hayBono ? "NO HAY BONO" : "");
               Console.WriteLine("\nEmpleado 1 " + nombre1 + ", descuento total: 22.13%, su sueldo liquido es de $" + salario1);
               Console.WriteLine("\nEmpleado 2 " + nombre2 + ", descuento total: 22.13%, su sueldo liquido es de $" + salario2);
               Console.WriteLine("\nEmpleado 3 " + nombre3 + ", descuento total: 22.13%, su sueldo liquido es de $" + salario3);
               Console.WriteLine("\nEl salario mayor es de $" + salario1);
            }
            else
            {
                if (salario2>salario1)
                {
                    Console.WriteLine(!hayBono ? "NO HAY BONO" : "");
                    Console.WriteLine("\nEmpleado 1 " + nombre1 + ", descuento total: 22.13%, su sueldo liquido es de $" + salario1);
                    Console.WriteLine("\nEmpleado 2 " + nombre2 + ", descuento total: 22.13%, su sueldo liquido es de $" + salario2);
                    Console.WriteLine("\nEmpleado 3 " + nombre3 + ", descuento total: 22.13%, su sueldo liquido es de $" + salario3);
                    Console.WriteLine("\nEl salario mayor es de $" + salario2);
                }
                else
                {
                    Console.WriteLine(!hayBono ? "NO HAY BONO" : "");
                    Console.WriteLine("\nEmpleado 1 " + nombre1 + ", descuento total: 22.13%, su sueldo liquido es de $" + salario1);
                    Console.WriteLine("\nEmpleado 2 " + nombre2 + ", descuento total: 22.13%, su sueldo liquido es de $" + salario2);
                    Console.WriteLine("\nEmpleado 3 " + nombre3 + ", descuento total: 22.13%, su sueldo liquido es de $" + salario3);
                    Console.WriteLine("\nEl salario mayor es de $" + salario3);
                }
            }

    Console.ReadKey();

  }
}
        }


//   \ 