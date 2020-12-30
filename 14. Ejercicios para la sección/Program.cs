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

            /*4- Aplícale a ese producto una oferta de descuento del 15%.
             * Puedes hacerlo de muchas maneras, por ejemplo:
             * primero multiplicando el precio base por 85 y después diviendo entre 100,
             * o también multiplicando el precio base por 0.85.
             * No importa si escoges alguno de estos procedimientos u otros cálculos matemáticos.
             * Pero hazlo con operadores acumulativos.
             */
            PrecioFinal *= 0.85;

            /*5- Piensa qué tipos de datos se habrán empleado para estos valores del juego:
             * Abreviatura del nombre de los Equipos    string
             * Contador de goles                        int
             * Mensajes al usuario                      string
             * Nombres de Jugadores                     string
             * Dorsales de Jugadores                    int
             * Barra de Energía del Jugador             double
             */

            /*6- Esta es una app para control de tu
             * cuenta bancaria. Puedes observar tu saldo total y
             * enviar dinero a otras cuentas.
             * 
             * ¿Qué operación y variables usarías con esos 2 datos (Saldo disponible y valor a enviar)
             * cuando el usuario pulse el botón “Continuar” ?
             */

            Double SaldoDisponible, Envio;
            SaldoDisponible = 13521.52;
            Envio = 0;
            SaldoDisponible -= Envio;

            /*7- Este caso es más complejo. El usuario quiere
             * enviar dinero, pero usando una moneda diferente.
             * Por lo tanto primero hay que aplicar un valor
             * al tipo de cambio que se empleará en la cantidad.
             * Imagina que el usuario quiere enviar 200 dólares.
             * ¿Qué variables y operaciones usarías para
             * calcular el saldo final después de pulsar el botón
             * “Envía dinero”?
             */

            double TipoDeCambio = 13.1503;
            double Total = 2695.679997;
            double DolaresEnvio = 200;

            Total -= DolaresEnvio * TipoDeCambio;

            /*8- Imagina un multicine con 7 salas donde proyectar películas.
             * Crea un array donde almacenar los títulos de cada una de ellas.
             */

            string[] Titulos = new string[7];

            /*9- Las 3 primeras salas proyectan en 3D, de modo que el precio de entrada es más caro.
             * Así que ahora tienes que guardar el precio de entrada para cada película.
             * Para ello usa una matriz, en lugar de un array, donde sigas almacenando el título
             * de cada película y además su correspondiente precio.
             */

            string[,] Salas = new string[7,2];

            Salas[0,0] = "Spiderman";
            Salas[0,1] = "80mxn";

            /*10- Este multicine hace un exhaustivo mantenimiento de limpieza semanal en
             * cada sala. De modo que cada sala cierra un día diferente de la semana.
             * Añade una dimensión a la matriz creada. Almacena el día de la semana
             * en el que no se podrá ver cada película y así poder informar a los
             * espectadores.
             */

            string[,,] SalasCine = new string[7,2,2];

            SalasCine[0,0,0] = "Spiderman";
            SalasCine[0,1,0] = "80mxn";
            SalasCine[0, 1, 1] = "Lunes";

        }
    }
}
