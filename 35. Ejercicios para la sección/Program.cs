using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.Ejercicios_para_la_sección
{
    class Program
    {
        /*
         * 1- Reproduce en código los siguientes objetos con sus consiguientes
         * atributos, métodos y establece las herencias oportunas para permitir
         * polimorfismo
         */

        /*
         * 2 - ¿Qué otros atributos y métodos añadirías a cada clase?
         * R.- Color, profundidad, marca, modelo, etc.
         */

        /*
         * 3 - ¿Qué funciones crearías para hacer uso del polimorfismo a nivel global?
         * R.- Cargar combustible, estacionar, maniobraDefensiva, etc.
         */

        /*
         * 4 - ¿Qué funciones crearías para hacer uso del polimorfismo únicamente
         * entre vehículos de tierra?
         * R.- Rebasar, derrapar, etc.
         */

        /*
         * 5 - ¿Qué otros objetos crearías? ¿Con qué atributos y métodos exclusivos?
         * R.- Bicicleta con saltar, ajustarCadena y aceitarCadena.
         */

        static void Main(string[] args)
        {
        }
    }

    public class Vehiculo
    {
        public float velocidadMaxima { get; set; }
        public byte capacidadPasajeros { get; set; }
        public string nombreConductor { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }

        public Vehiculo(float velocidadMaxima, byte capacidadPasajeros, string nombreConductor, string modelo, string marca)
        {
            this.velocidadMaxima = velocidadMaxima;
            this.capacidadPasajeros = capacidadPasajeros;
            this.nombreConductor = nombreConductor;
            this.modelo = modelo;
            this.marca = marca;
        }

        public void Acelerar()
        {

        }

        public void Frenar()
        {

        }
        public void IntroducirPasajero()
        {

        }

        public void Estacionar()
        {

        }

        public void CargarCombustible()
        {

        }
    }

    public class Acuatico : Vehiculo
    {
        public Acuatico(float longitud, string cubiertas, string estadoAncla, float velocidadMaxima, byte capacidadPasajeros, string nombreConductor, string marca, string modelo)
            : base(velocidadMaxima, capacidadPasajeros, nombreConductor, modelo, marca)
        {
            this.longitud = longitud;
            this.cubiertas = cubiertas;
            this.estadoAncla = estadoAncla;
        }

        public float longitud { get; set; }
        public string cubiertas { get; set; }
        public string estadoAncla { get; set; }
        public float profundidad { get; set; }

        public void Amarrar()
        {

        }

        public void Partir()
        {

        }

    }

    public class Terrestre : Vehiculo
    {
        public Terrestre(string matricula, float velocidadMaxima, byte capacidadPasajeros, string nombreConductor, string marca, string modelo)
            : base(velocidadMaxima, capacidadPasajeros, nombreConductor, modelo, marca)
        {
            Matricula = matricula;
        }

        public string Matricula { get; set; }
        public string Verificacion { get; set; }

        public void derrapar()
        {

        }

        public void cambiarNeumatico()
        {

        }
    }

    public class Aereo : Vehiculo
    {
        public Aereo(float pesoMaximo, float velocidadMaxima, byte capacidadPasajeros, string nombreConductor, string marca, string modelo)
            : base(velocidadMaxima, capacidadPasajeros, nombreConductor, modelo, marca)
        {
            PesoMaximo = pesoMaximo;
        }

        public float PesoMaximo { get; set; }
    }
    public class Lancha : Acuatico
    {
        public Lancha(string estadoRadio, float longitud, string cubiertas, string estadoAncla, float velocidadMaxima, byte capacidadPasajeros, string nombreConductor, string marca, string modelo)
            : base(longitud, cubiertas, estadoAncla, velocidadMaxima, capacidadPasajeros, nombreConductor, modelo, marca)
        {
            EstadoRadio = estadoRadio;
        }

        public string EstadoRadio { get; set; }
        public string Puerto { get; set; }

        public void encenderRadio()
        {

        }

        public void apagarRadio()
        {

        }
    }

    public class Camion : Terrestre
    {
        public Camion(byte ruedas, float altura, float kilosCargados, string matricula, float velocidadMaxima, byte capacidadPasajeros, string nombreConductor, string marca, string modelo)
            : base(matricula, velocidadMaxima, capacidadPasajeros, nombreConductor, modelo, marca)
        {
            Ruedas = ruedas;
            Altura = altura;
            KilosCargados = kilosCargados;
        }

        public byte Ruedas { get; set; }
        public float Altura { get; set; }
        public float KilosCargados { get; set; }
        public byte Remolques { get; set; }
        public void recogerCarga()
        {

        }

        public void entregarCarga()
        {

        }


    }

    public class Globo : Aereo
    {
        public Globo(float capacidadBolsa, string tipoGas, float pesoMaximo, float velocidadMaxima, byte capacidadPasajeros, string nombreConductor, string marca, string modelo)
            : base(pesoMaximo, velocidadMaxima, capacidadPasajeros, nombreConductor, modelo, marca)
        {
            CapacidadBolsa = capacidadBolsa;
            TipoGas = tipoGas;
        }

        public float CapacidadBolsa { get; set; }
        public string TipoGas { get; set; }

    }

    public class Barco : Acuatico
    {
        public Barco(byte camarotes, string nombreMedico, string estadoSatelite, float longitud, string cubiertas, string estadoAncla, float velocidadMaxima, byte capacidadPasajeros, string nombreConductor, string marca, string modelo)
            : base(longitud, cubiertas, estadoAncla, velocidadMaxima, capacidadPasajeros, nombreConductor, modelo, marca)
        {
            Camarotes = camarotes;
            NombreMedico = nombreMedico;
            EstadoSatelite = estadoSatelite;
        }

        public byte Camarotes { get; set; }
        public string NombreMedico { get; set; }
        public string EstadoSatelite { get; set; }
        public byte BarcosSalvavidas { get; set; }

        void conectarSatelite()
        {

        }

        void desconectarSatelite()
        {

        }

        void ocuparCamarote()
        {

        }

        void desocuparCamarote()
        {

        }
    }

    public class Tren : Terrestre
    {
        public Tren(byte vagones, string estacionOrigen, string estacionDestino, string matricula, float velocidadMaxima, byte capacidadPasajeros, string nombreConductor, string marca, string modelo)
            : base(matricula, velocidadMaxima, capacidadPasajeros, nombreConductor, modelo, marca)
        {
            Vagones = vagones;
            EstacionOrigen = estacionOrigen;
            EstacionDestino = estacionDestino;
        }

        public byte Vagones { get; set; }
        public string EstacionOrigen { get; set; }
        public string EstacionDestino { get; set; }
        public void definirTrayecto()
        {

        }
    }
    public class Avion : Aereo
    {
        public Avion(float pesoMaximo, float velocidadMaxima, byte capacidadPasajeros, string nombreConductor, string marca, string modelo)
            : base(pesoMaximo, velocidadMaxima, capacidadPasajeros, nombreConductor, marca, modelo)
        {
        }

        public byte Motores { get; set; }
        public byte SalidasEmergencia { get; set; }
        public string EstadoRuedaAuxiliares { get; set; }
        public void Despegar()
        {

        }
        public void Aterrizar()
        {

        }
    }

    public class Bicicleta : Terrestre
    {
        public Bicicleta(string matricula, float velocidadMaxima, byte capacidadPasajeros, string nombreConductor, string marca, string modelo) : base(matricula, velocidadMaxima, capacidadPasajeros, nombreConductor, marca, modelo)
        {
        }

        public void ajustarCadena()
        {

        }

        public void saltar()
        {

        }
    }
}
