using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    internal class Program
    {
        const String REPETIR_BUCLE = "S";
        const String NO_REPETIR_BUCLE = "N";


        static void Main(string[] args)
        {

            // Practica1();
            // Practica2();
            // Practica3();
            // Practica4();
            // Excepciones();
            Practica5();



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

        #region
        static void Practica3()
        {
            string respuesta = string.Empty;



            respuesta = LeerRespuesta();

            while (String.Equals(respuesta, REPETIR_BUCLE))
            {
                respuesta = LeerRespuesta();
            }

            Console.WriteLine("Has salido del bucle");
        }

        static string LeerRespuesta()
        {
            String respuesta = String.Empty;


            Console.WriteLine("Quieres entrar al bucle? (S/N)");
            respuesta = Console.ReadLine().ToUpper();

            while (!respuesta.Equals(REPETIR_BUCLE) && !respuesta.Equals(NO_REPETIR_BUCLE))
            {
                Console.WriteLine("Debes introducir N o S");
                respuesta = Console.ReadLine().ToUpper();
            }

            return respuesta;
        }

        #endregion


        /*
         * PRACTICA 4
         */

        #region
        static void Practica4()
        {
            String respuesta = String.Empty;

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

        #endregion


        /*
         * EXCEPCIONES
         */
        #region
        static void Excepciones()
            
        {
            try
            {
                Console.WriteLine("Introduce un numero");
                int valor = int.Parse(Console.ReadLine());
                Console.WriteLine($"Se ha leido {valor}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("El numero introducido es demasiado grande");
            }
            finally
            {
                Console.WriteLine("Fin del metodo");
            }
            //no dejar archivos abiertos ni conexiones
        }
        #endregion


        /*
         * PRACTICA 5
         */

        static void Practica5()
        {
            const string PATH = @"E:\Visual\source\repos\practica5.txt";

            System.IO.StreamReader archivo = null;
            string linea = string.Empty;

            try
            {
                archivo = new System.IO.StreamReader(PATH);
                linea = archivo.ReadLine();
                while (!String.IsNullOrEmpty(linea))
                {
                    Console.WriteLine(linea);
                    linea = archivo.ReadLine();
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(archivo != null)
                {
                    archivo.Close();
                }
                Console.WriteLine("Conexion en el fichero cerrada");
            }
        }



    }
}
