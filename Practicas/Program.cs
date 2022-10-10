using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* comentarios
             * de varias lineas
             * 
             */
            Console.WriteLine("¡¡¡¡¡Hola Mundo!"); // comentarios

            int edad = 25;
            int alumnos = 24;
            string curso = "DEINT";

            Console.WriteLine($"Tu edad es de {edad} años");
            Console.WriteLine("Tu edad es de {0}", edad);
            Console.WriteLine("Tu edad es de " + edad + " años");
            Console.WriteLine("En la clase de {1} alumnos hay personas con {0} años ", edad, alumnos);

            Console.WriteLine("Introduce el radio: ");
            int num = int.Parse(Console.ReadLine());
            const double PI = 3.14;
            double resultado = PI * Math.Pow(num, 2);
            Console.WriteLine($"El area del circulo del radio {num} es {resultado}");

        }
    }
}
