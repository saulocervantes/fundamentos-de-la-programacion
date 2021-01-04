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

            //string[,] Movimientos = new string[5, 3];

            //Movimientos[0, 0] = "Disposición de efectivo en cajero.";
            //Movimientos[0, 1] = "18/05/11";
            //Movimientos[0, 2] = "-60";

            //Movimientos[1, 0] = "Pago con tarjeta de gasollineras.";
            //Movimientos[1, 1] = "18/05/11";
            //Movimientos[1, 2] = "-56";

            //Movimientos[2, 0] = "Recibo de funddaciones y o.n.g.";
            //Movimientos[2, 1] = "18/05/11";
            //Movimientos[2, 2] = "-25";

            //Movimientos[3, 0] = "Pago con tarjeta en medicina, farma...";
            //Movimientos[3, 1] = "17/05/11";
            //Movimientos[3, 2] = "-45.31";

            //Movimientos[4, 0] = "Pago con tarjeta en gasolineras.";
            //Movimientos[4, 1] = "17/05/11";
            //Movimientos[4, 2] = "-60";

            //for (int i = 0; i < Movimientos.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Movimientos.GetLength(1); j++)
            //    {
            //        /* Aquí uso el método Math.Abs que devuelve el valor absoluto de un número (es decir que le quita el signo).
            //         * También pude poner el valor positivo en el arreglo, pero decidi hacerlo de esta forma.
            //         */

            //        {
            //            if (Math.Abs(decimal.Parse(Movimientos[i,2])) > 50) 
            //            Console.WriteLine("{0}", Movimientos[i, j]);
            //        }
            //    }
            //}
            //Console.ReadLine();

            /* 10- La ventana de la derecha presenta varios listados, unos dentro de otros.
             * De forma jerárquica vemos los diferentes servicios que tiene el cliente en letra azul
             * “Cuentas, Préstamos, Tarjetas y Seguros” y dentro de cada uno de tales servicios
             * se listan todos los tipos de servicios que tiene disponibles.
             * 
             * ¿Con qué 2 bucles podrías recorrer tal información? ¿De qué forma los
             * anidarías? ¿Serías capaz de representar en código la manera de
             * listar estos diferentes servicios generales y cada uno de los específicos
             * que tenga el cliente?
             * 
             * Puedes elegir tú mismo con que arrays/matrices
             * estructurar los datos que simulen la ventana mostrada.
             */

            //string[,] Saldos = new string[4, 3];
            //string Header = null;
            //decimal Total = 0;

            //// Llenado de la Tabla.
            //Saldos[0, 0] = "Cuentas corrientes";
            //Saldos[0, 1] = "2100";
            //Saldos[0, 2] = "Cuentas ";
            //Saldos[1, 0] = "Cuentas corrientes";
            //Saldos[1, 1] = "1000";
            //Saldos[1, 2] = "Cuentas ";
            //Saldos[2, 0] = "Préstamos personales";
            //Saldos[2, 1] = "10000";
            //Saldos[2, 2] = "Préstamos";
            //Saldos[3, 0] = "Tarjetas de crédito";
            //Saldos[3, 1] = "5250";
            //Saldos[3, 2] = "Tarjetas";

            //for (int i = 0; i < Saldos.GetLength(0); i++)
            //{
                
            //    for (int j = 0; j < Saldos.GetLength(1)-1; j++)
            //    {
            //        // Condición para cambiar el encabezado.
            //        if (Header != Saldos[i, 2])
            //        {
            //            Header = Saldos[i, 2];
            //            // Ciclo para determinar el total del encabezado.
            //            for (int k = 0; k <= Saldos.GetLength(1); k++)
            //            {
            //                if (Header == Saldos[k,2])
            //                {
            //                    Total += decimal.Parse(Saldos[k, 1]);
            //                }
            //            }

            //            // Impresión para el encabezado con el total.
            //            Console.WriteLine("{0}\t\t\t{1} Gs.", Saldos[i, 2], Total);
            //            Total = 0;
            //        }
            //        // Impresión de datos
            //        if (j == 0)
            //        {
            //            Console.Write("{0}\t", Saldos[i, j]);
            //        }
            //        else
            //        {
            //            Console.WriteLine("{0} Gs.", Saldos[i, j]);
            //        }
            //    }
            //}
            //Console.ReadLine();

            /* 11- Si una casa tiene un valor de 75.000€ usa el elemento switch para establecer
             * el precio final de venta dependiendo del tipo de consumo eléctrico que tenga.
             * 
             * 12 - ¿Te diste cuenta de la importancia de usar un elemento break en cada caso?
             * ¿Observaste también que no era necesario añadir nada en caso de ser tipo “C”?
             */

            decimal Precio = 75000;
            decimal PrecioFinal = 0;
            char Categoria = 'C';

            Console.WriteLine("Ingresa la categoría del consumo de energía de la casa, representada por una letra de la A-E.");
            char.TryParse(Console.ReadLine(), out Categoria);
            switch (Categoria)
            {
                case 'A':
                    PrecioFinal = Precio * 1.20m;
                    break;
                case 'B':
                    PrecioFinal = Precio * 1.10m;
                    break;
                case 'D':
                    PrecioFinal = Precio * 0.90m;
                    break;
                case 'E':
                    PrecioFinal = Precio * 0.80m;
                    break;
                default:
                    PrecioFinal = Precio;
                    break;
            }
            Console.WriteLine("El precio de la casa es de ${0} y su categoría de consumo eléctrico es {1}.",PrecioFinal,Categoria);
            Console.ReadKey();
        }
    }
}
