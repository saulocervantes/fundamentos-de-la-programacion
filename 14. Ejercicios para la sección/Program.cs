using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Ejercicios_para_la_sección
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1-Declara en el lenguaje que prefiera variables o constantes para guardar lo siguientes datos.
             * Escoja el tipo de dato correcto, que menos espacio ocupen en memoria. 
             */

            float PrecioCamiseta = 14.99f;
            byte Edad = 26;
            const double VelocidadLuz = 2998e+8;
            string Slogan = "\"Just do it\", \"Impossible is nothing\"";
            const float Impuesto = 0.7f;
            long RadioEstrella = 468346864571;
            var EficienciaEnergética = "A";
            bool Resultado;
            const float Gravedad = 9.80665f;

            /*2-El precio base de cierto producto alimenticio es de 4.56€. A tal precio se le tiene
             * que aplicar un impuesto de 7% para conocer el precio final de venta. Utiliza una
             * variable para el precio base, una constante para el impuesto y otra variable para
             * el precio final. Calcula el precio final.
             */

            var Precio = 4.56;
            const float Impuesto2 = 0.7f;
            double PrecioFinal = Precio + Precio * Impuesto2;

            /*3- Vuelve a realizar el mismo ejercicio, sin usar otra variable disinta para el precio
             * final. Igualmente debes calcular el precio final de venta, esta vez usando el
             * operador *=
             */
            const float Impuesto3 = 7;

            Precio *= Impuesto3;
            Precio /= 100;
            PrecioFinal = Precio;
        }
    }
}
