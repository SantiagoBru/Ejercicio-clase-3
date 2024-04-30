using System.Security.Cryptography.X509Certificates;
using Clase3.Ejercicio_2;

namespace Clase3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1


            // Crear clase Vehiculo con las siguientes propiedades: Marca, Modelo
            // Crear clase Moto que herede de Vehiculo  
            // Crear clase Auto que herede de Vehiculo

            Moto moto = new Moto { Marca = "Honda", Modelo = "CBR" };
            Auto auto = new Auto { Marca = "Toyota", Modelo = "Corolla" };

            //Modificar el metodo "ImprimirDatosVehiculo" para que pueda imprimir los datos del Vehiculo independientemente de que si es una moto o un auto 

            //Uso
            ImprimirDatosVehiculo(moto);
            ImprimirDatosVehiculo(auto);

            

            #endregion


            #region Ejercicio 2
            // Crear una interfaz que se llame IBiblioteca
            // Definir en la interfaz con una sola firma que indique que se va a obtener todos los libros
            // Implementar la interfaz en la clase biblioteca para que devuelva los libros
            // Instanciar y utilizar la clase biblioteca

            Biblioteca biblioteca = new Biblioteca();
            List<string> libros = biblioteca.ObtenerodosLosLibros();

            Console.WriteLine("Lista de libros: ");
            foreach (var libro in libros)
            {
                Console.WriteLine(libro);
            }

            #endregion
        }

        public static void ImprimirDatosVehiculo(Vehiculo vehiculo) 
        {   
            Console.WriteLine ($"Marca: {vehiculo.Marca}, Modelo: {vehiculo.Modelo}");
        }


    }
}