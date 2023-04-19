using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class OpsServicios
    {
        public static void Suma()
        {
            var ops = new Servicios.OperacionesServicesClient();

            Console.WriteLine("----- Suma -----");
            Console.WriteLine("Ingrese los numeros a sumar: ");
            Console.Write("Numero 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Numero 2: ");
            int b = int.Parse(Console.ReadLine());

            int result = ops.Suma(a, b);

            Console.WriteLine("\nEl resultado es: " + result);
        }

        public static void Resta()
        {
            var ops = new Servicios.OperacionesServicesClient();

            Console.WriteLine("----- Resta -----");
            Console.WriteLine("Ingrese los numeros a restar: ");
            Console.Write("Numero 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Numero 2: ");
            int b = int.Parse(Console.ReadLine());

            int result = ops.Resta(a, b);

            Console.WriteLine("\nEl resultado es: " + result);
        }

        public static void Multiplicacion()
        {
            var ops = new Servicios.OperacionesServicesClient();

            Console.WriteLine("----- Multiplicacion -----");
            Console.WriteLine("Ingrese los numeros a multiplicar: ");
            Console.Write("Numero 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Numero 2: ");
            int b = int.Parse(Console.ReadLine());

            int result = ops.Multiplicacion(a, b);

            Console.WriteLine("\nEl resultado es: " + result);
        }

        public static void Division()
        {
            var ops = new Servicios.OperacionesServicesClient();

            Console.WriteLine("----- Division -----");
            Console.WriteLine("Ingrese los numeros a dividir: ");
            Console.Write("Numero 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Numero 2: ");
            int b = int.Parse(Console.ReadLine());

            double result = ops.Division(a, b);

            Console.WriteLine("\nEl resultado es: " + result);
        }
    }
}
