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

            // Practica1();
            // Practica2();
            Practica3();
        }

        /*
         * PRACTICA 1
         */
        #region
        static void Practica1()
        {
            Console.WriteLine("Introduce el radio: ");
            int num = int.Parse(Console.ReadLine());
            const double PI = 3.14;
            double resultado = PI * Math.Pow(num, 2);
            Console.WriteLine($"El area del circulo del radio {num} es {resultado}");

        }
        #endregion

        /*
         * PRACTICA 2
         */
        #region
        static void Practica2()

        {
            Console.WriteLine("Introduzca su edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("Eres menor de edad, no puedes conducir");
            }
            else
            {
                Console.WriteLine("¿Tienes carnet de conducir? Introduce S(si) o N(no)");
                String carnet = Console.ReadLine();
                if (carnet.Equals("S"))
                {
                    Console.WriteLine("Puedes conducir");
                }
                else if (carnet.Equals("N"))
                {
                    Console.WriteLine("No puedes conducir");
                }
                else
                {
                    Console.WriteLine("Dato introducido incorrecto, debe introducir S para decir 'si' o N para decir 'no'");
                }
            }
        }
        #endregion
        /*
         * PRACTICA 3
         */
        static void Practica3()
        {
            String respuesta;

            do
            {
                Console.WriteLine("Quieres entrar?: 'S' o 'N'");
                respuesta = Console.ReadLine().ToUpper();

                if (respuesta.Equals("S"))
                { 
                    Console.WriteLine("Bienvenido");
                }else if (respuesta.Equals("N"))
                {
                    Console.WriteLine("Adios");
                }else
                { 
                    Console.WriteLine("Debe teclear S o N");
                }
            } while (!respuesta.Equals("S") && !respuesta.Equals("N"));
        }


    }
}
