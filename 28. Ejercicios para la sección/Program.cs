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
        static void Main(string[] args)
        {

        }

        public void reproducirEjercicio(string NombreEjercicio)
        {
            Console.WriteLine("Reproduciendo ejercicio {0}",NombreEjercicio);
        }
    }
}
