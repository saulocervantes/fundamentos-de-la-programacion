using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Ejercicios_para_la_sección
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Para establecer el Pin de Seguridad, se pide al usuario que lo introduzca 2 veces
             * hasta que ambas veces coincida.
             * 
             * 1- ¿Qué bucle y variables usarías para hacer la comprobación después que el
             * usuario introduzca 2 veces el pin?
             */

            string Pin = null;
            string Comprobacion = null;

            while (true)
            {
                Console.WriteLine("Ingrese el Pin de seguridad");
                Pin = Console.ReadLine();

                Console.WriteLine("Ingrese nuevamente el Pin de seguridad");
                Comprobacion = Console.ReadLine();

                if (Pin == Comprobacion)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("El Pin no coincide, favor de intentar de nuevo.");
                }
            }
            
            Console.WriteLine("El Pin ha sido establecido.");
            Console.ReadLine();

        }
    }
}
