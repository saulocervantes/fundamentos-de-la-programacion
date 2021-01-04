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
             * 
             * 2- ¿Cómo comprobarías que se ha escrito exactamente igual?
             * 
             * 3- ¿Podrías escribir el pseudocódigo total de este proceso de seguridad?
             */

            //string Pin = null;
            //string Comprobacion = null;

            //while (true)
            //{
            //    Console.WriteLine("Ingrese el Pin de seguridad");
            //    Pin = Console.ReadLine();

            //    Console.WriteLine("Ingrese nuevamente el Pin de seguridad");
            //    Comprobacion = Console.ReadLine();

            //    if (Pin == Comprobacion)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("El Pin no coincide, favor de intentar de nuevo.");
            //    }
            //}

            //Console.WriteLine("El Pin ha sido establecido.");
            //Console.ReadLine();

            /* 4- ¿Qué bucle usarías en este caso para permitir iniciar y/o continuar la acción de añadir
             * productos al carrito?
             * Culquier bucle es viable pero usaría el ciclo while.
             * 
             * 5- Después de añadir un nuevo artículo a la compra que desea realizar, se debe actualizar
             * el valor total de la compra. ¿Recuerdas que operador habría que usar? ¿Podrías representar
             * esta acción en código?
             * +=
             * 
             * 6- ¿Qué operador de comparación usarías en el bucle del ejercicio 5 para
             * asegurarte que tenga saldo disponible?
             * b) saldo >= totalcompra
             * 
             * 7- ¿Sabrías explicar cuál es la diferencia y qué efecto tendría en la
             * app o en el usuario si escogieras el operador incorrecto?
             * En caso de elegir > el saldo jamás podría quedar en 0. Es decir que en realidad el saldo disponible sería igual a saldo disponible -1.
             */

            //string Producto;
            //string Precio;
            //decimal Saldo = 10000;
            //byte Respuesta;
            //decimal Total = 0;

            //while (true)
            //{
            //    Console.WriteLine("Ingrese el nombre del producto:");
            //    Producto = Console.ReadLine();

            //    Console.WriteLine("Ingrese el precio de {0}", Producto);
            //    Precio = Console.ReadLine();

            //    if (decimal.Parse(Precio) <= Saldo)
            //    {
            //        Console.WriteLine("¿Desea gregar otro producto al carrito  0.-No 1.-Sí");
            //        Respuesta = byte.Parse(Console.ReadLine());
            //    }
            //    else
            //    {
            //        Console.WriteLine("Saldo insuficiente.");
            //        continue;
            //    }

            //    Total += decimal.Parse(Precio);

            //    if (Respuesta == 0 || Total == Saldo)
            //    {
            //        Saldo -= Total;
            //        Console.WriteLine("Su saldo es {0}, Gracias por su compra.", Saldo);
            //        Console.ReadLine();
            //        break;
            //    }
            //    else if (Respuesta == 1 )
            //    {
            //        continue;
            //    }

            //}

            /* 8- En esta ventana podemos ver el listado de gastos. Imaginemos
             * que tales gastos se encuentran almacenados en una matriz donde
             * se almacena el concepto, la fecha y la cantidad del gasto.
             * 
             * ¿Qué bucle usarías para recorrer toda esa información y mostrarla?
             * Un bucle for.
             * 
             * 9- Dando por buena la estructura de la matriz descrita anteriormente,
             * ¿sabrías incluir un if dentro del bucle elegido en el ejercicio 8 para filtrar los gastos,
             * por ejemplo, mostrando solo aquellos superiores a 50€?
             */

            string[,] Movimientos = new string[5, 3];

            Movimientos[0, 0] = "Disposición de efectivo en cajero.";
            Movimientos[0, 1] = "18/05/11";
            Movimientos[0, 2] = "-60";

            Movimientos[1, 0] = "Pago con tarjeta de gasollineras.";
            Movimientos[1, 1] = "18/05/11";
            Movimientos[1, 2] = "-56";

            Movimientos[2, 0] = "Recibo de funddaciones y o.n.g.";
            Movimientos[2, 1] = "18/05/11";
            Movimientos[2, 2] = "-25";

            Movimientos[3, 0] = "Pago con tarjeta en medicina, farma...";
            Movimientos[3, 1] = "17/05/11";
            Movimientos[3, 2] = "-45.31";

            Movimientos[4, 0] = "Pago con tarjeta en gasolineras.";
            Movimientos[4, 1] = "17/05/11";
            Movimientos[4, 2] = "-60";

            for (int i = 0; i < Movimientos.GetLength(0); i++)
            {
                for (int j = 0; j < Movimientos.GetLength(1); j++)
                {
                    /* Aquí uso el método Math.Abs que devuelve el valor absoluto de un número (es decir que le quita el signo).
                     * También pude poner el valor positivo en el arreglo, pero decidi hacerlo de esta forma.
                     */

                    {
                        if (Math.Abs(decimal.Parse(Movimientos[i,2])) > 50) 
                        Console.WriteLine("{0}", Movimientos[i, j]);
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
