using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Ejercicios_para_la_sección
{
    class Program
    {
        /*
         * 1- Necesitamos una función a la que llamar o invocar para que reproduzca el
         * video con el movimiento muscular a realizar. A esa función le diremos exactamente
         * qué ejercicio reproducir, ya que esa función será la misma tanto para
         * abdominales, pecho, pierna, etc.
         * 
         * Esta función reproducirá el ejercicio solo una vez. ¿Cómo haremos para recrear la serie completa?
         * R = Agregando como parámetro el número de repeticiones y un ciclo.
         */

        /*
         * 2- Crearemos otra función en la que administraremos cada serie, indicándole
         * el número de veces que se tiene que realizar el movimiento y el número de
         * segundos de descanso que corresponde a tal serie.
         */

        /*
         * 3- Ahora necesitamos otra función a la que llamar para reproducir el gif
         * del personaje descansando tras cada serie ¿Creamos otra función nueva? ¿O podríamos reutilizar la que reproduce
         * los movimientos del ejercicio para también reproducir los descansos? Al fin y
         * al cabo...se trata de archivos en ambos casos. De modo que podemos hacerlo
         * en una misma función. A esto se le llama reutilizar código para optimizar
         */
        static void Main(string[] args)
        {
            reproducirEjercicio("sentadilla", 5, 5);
        }

        public static void reproducirEjercicio(string NombreEjercicio)
        {
            Console.WriteLine("Reproduciendo ejercicio {0}", NombreEjercicio);
        }

        public static void reproducirArchivo(string NombreEjercicio, byte Descanso, int CursorDescanso, int Repeticion)
        {
            DateTime Fin = DateTime.Now.AddSeconds(Descanso);
            Console.CursorVisible = false;

            if (Descanso > 0)
            {
                while (DateTime.Now < Fin)
                {
                    Console.SetCursorPosition(0, CursorDescanso);
                    var Diferencia = Fin - DateTime.Now;
                    Console.WriteLine($"Descanso restante: {Diferencia.Seconds} segundos");
                }
            }
            else
            {
                Console.WriteLine("Reproduciendo ejercicio {0} serie: {1}", NombreEjercicio, Repeticion);
            }

            
        }

        public static void reproducirEjercicio(string NombreEjercicio, byte Repeticiones, byte Descanso = 0)
        {
            var CursorEjercicio = 0;
            var CursorDescanso = 1;
            for (int i = 1; i <= Repeticiones; i++)
            {
                Console.SetCursorPosition(0, CursorEjercicio);
                CursorEjercicio += 2;

                reproducirArchivo(NombreEjercicio, 0, CursorDescanso, i);
                if (i == Repeticiones)// Si esta es es la última repetición no se reproduce el descanso.
                    break;
                reproducirArchivo(NombreEjercicio, Descanso, CursorDescanso, i);

                CursorDescanso += 2;
            }
            Console.ReadLine();
        }
    }
}
