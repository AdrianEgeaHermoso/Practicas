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

            //Practica1();
            Practica2();
            // Practica3();
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
                if(carnet.Equals("S")) 
                {
                    Console.WriteLine("Puedes conducir");
                }
                else 
                {
                    Console.WriteLine("No puedes conducir");
                }
            }
        }
        #endregion
        /*
         * PRACTICA 3
         */
        static void Practica3()
        {
            Console.WriteLine("Practica 3");
        }


    }
}
