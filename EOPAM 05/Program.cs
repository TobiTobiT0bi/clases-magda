using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

/*  Crearemos una clase llamada Serie con las siguientes características:
Sus atributos son título, número de temporadas, entregado, genero y creador.
Por defecto, el número de temporadas es de 3 temporadas y entregado false. El resto de atributos serán valores por defecto según el tipo del atributo.
Los constructores que se implementarán serán:
Un constructor por defecto.
Un constructor con título y creador. El resto por defecto.
Un constructor con todos los atributos, excepto de entregado.
Los métodos que se implementara serán:
Métodos de todos los atributos, excepto de entregado.
Métodos set de todos los atributos, excepto de entregado.
Crearemos una clase Videojuego con las siguientes características:
Sus atributos son titulo, horas estimadas, entregado, genero y compañia.
Por defecto, las horas estimadas serán de 10 horas y entregado false. El resto de atributos serán valores por defecto según el tipo del atributo.
Los constructores que se implementarán serán:
Un constructor por defecto.
Un constructor con el título y horas estimadas. El resto por defecto.
Un constructor con todos los atributos, excepto de entregado.
Los métodos que se implementara serán:
Métodos get de todos los atributos, excepto de entregado.
Métodos set de todos los atributos, excepto de entregado.
Como vemos, en principio, las clases anteriores no son padre-hija, pero si tienen en común, por eso vamos a hacer una interfaz llamada Entregable con los siguientes métodos:
entregar(): cambia el atributo prestado a true.
devolver(): cambia el atributo prestado a false.
isEntregado(): devuelve el estado del atributo prestado.
Método compareTo (Object a), compara las horas estimadas en los videojuegos y en las series el número de temporadas. Como parámetro que tenga un objeto, no es necesario que implementen la interfaz Comparable. Recuerda el uso de los casting de objetos.
Implementa los anteriores métodos en las clases Videojuego y Serie. Ahora crea una aplicación ejecutable y realiza lo siguiente:
Crea dos arrays, uno de Series y otro de Videojuegos, de 5 posiciones cada uno.
Crea un objeto en cada posición del array, con los valores que desees, puedes usar distintos constructores.
Entrega algunos Videojuegos y Series con el método entregar().
Cuenta cuantos Series y Videojuegos hay entregados. Al contarlos, devuelvelos.
Por último, indica que el Videojuego tiene más horas estimadas y la serie con mas temporadas. Muestran en pantalla con toda su información
*/

namespace EOPAM5
{

    interface IEntregable
    {
        void Entregar();

        void Devolver();

        bool isEntregado();

        string mostrar();

    }
    class Serie : IEntregable
    {
        public const int tempodefecto = 3;


        private string titulo;
        private int temporadas = tempodefecto;
        public bool entregado = false;
        private string genero = "";
        private string creador = "";

        public Serie() { }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;

        }

        public Serie(string titulo, int temporadas, bool entregado, string genero)
        {
            this.titulo = titulo;
            this.temporadas = temporadas;
            this.entregado = entregado;
            this.genero = genero;
        }

        public string Titulo { get { return this.titulo; } set { this.titulo = value; } }

        public int Tempodefecto { get { return this.temporadas; } set { this.temporadas = value; } }

        public string Genero { get { return this.genero; } set { this.genero = value; } }

        public string Creador { get { return this.creador; } set { this.creador = value; } }

        void IEntregable.Entregar() {
            entregado = true;
        }

        void IEntregable.Devolver() {
            entregado = false;
        }

        bool IEntregable.isEntregado() { 
            return entregado;
        }

        string IEntregable.mostrar() {
            return $"Titulo: {titulo}, nro de temporadas: {temporadas}, ¿Esta entregado? {entregado}, genero: {genero}, creador: {creador}";
        }

        public Serie CompareTo(Serie a) {
            /*
            if (this.temporadas < a.temporadas) {
                return a; 
            }
            return this; */

            return this.temporadas < a.temporadas ? a : this;
        }
        
    }

    class Videojuego : IEntregable
    {
        private string titulo = "";
        private int horasEsti = 10;
        public bool entregado = false;
        private string genero = "";
        private string compania = "";

        public Videojuego() { }

        public Videojuego(string titulo, int horasesti)
        {
            this.titulo = titulo;
            this.horasEsti = horasesti;
        }

        public Videojuego(string titulo, int horasesti, string genero, string compania)
        {
            this.titulo = titulo;
            this.horasEsti = horasesti;
            this.genero = genero;
            this.compania = compania;
        }

        public string Titulo { get { return this.titulo; } set { this.titulo = value; } }

        public int horasesti { get { return this.horasEsti; } set { this.horasEsti = value; } }

        public string Genero { get { return this.genero; } set { this.genero = value; } }

        public string Compania { get { return this.compania; } set { this.compania = value; } }

        void IEntregable.Entregar()
        {
            entregado = true;
        }

        void IEntregable.Devolver()
        {
            entregado = false;
        }

        bool IEntregable.isEntregado()
        {
            return entregado;
        }

        string IEntregable.mostrar()
        {
            return $"Titulo: {titulo}, horas estimadas: {horasEsti}, ¿Esta entregado? {entregado}, genero: {genero}, compañia: {compania}";
        }

        public Videojuego CompareTo(Videojuego a)
        {
            /*
            if (this.horasesti < a.horasesti) {
                return a; 
            }
            return this; */

            return this.horasesti < a.horasesti ? a : this;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Serie[] series = new Serie[5];
            Videojuego[] videojuegos = new Videojuego[5];

            Videojuego mayorVideo = new Videojuego();
            Serie mayorSerie = new Serie();

            series[0] = new Serie("pepe", "tobias");
            series[1] = new Serie("magdacoin", 2, true, "magda");
            series[2] = new Serie("minecraft", "GASPAR");
            series[3] = new Serie("barbie", 7, false, "azul");
            series[4] = new Serie("panflines", 5, true, "comedia");

            videojuegos[0] = new Videojuego("fortnite", 4770);
            videojuegos[1] = new Videojuego("brawhalla", 50000);
            videojuegos[2] = new Videojuego("csgo", 1512, "shooter", "valve");
            videojuegos[3] = new Videojuego("rocket league", 1116);
            videojuegos[4] = new Videojuego("darksoul", 15115);

            ((IEntregable)series[2]).Entregar();
            ((IEntregable)series[3]).Entregar();

            ((IEntregable)videojuegos[3]).Entregar();
            ((IEntregable)videojuegos[4]).Entregar();

            Console.WriteLine($"Series entregadas: {series.Count(s => s.entregado == true)}");
            Console.WriteLine($"Videojuegos entregadaos: {videojuegos.Count(s => s.entregado == true)}");

            for (int i = 0; i < 5; i++) {
                mayorSerie = mayorSerie.CompareTo(series[i]);
                mayorVideo = mayorVideo.CompareTo(videojuegos[i]);
            }

            Console.WriteLine($"Serie con mas temporadas: {mayorSerie.Titulo}");
            Console.WriteLine($"Videojuego con mas horas: {mayorVideo.Titulo}");

            Console.WriteLine(((IEntregable)mayorSerie).mostrar());
            Console.WriteLine(((IEntregable)mayorVideo).mostrar());

            Console.ReadKey();
        }
    }
}