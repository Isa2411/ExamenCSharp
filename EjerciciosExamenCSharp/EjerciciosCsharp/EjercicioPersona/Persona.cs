using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjerciciosCsharp;

namespace EjerciciosCsharp
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }


        //
        //
        // Constructor que inicializa los atributos
        public Persona(string nombre, int edad, string direccion)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
        }


        //
        //
        // Constructor sin parámetros que asigna valores predeterminados
        public Persona()
        {
            Nombre = "Antonella";
            Edad = 2;
            Direccion = "Campoalegre";
        }


        //
        //
        // Metodo para mostrar la información de la persona en la consola
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Dirección: {Direccion}");
        }

        //
        //
        //Async
        public async Task LeerDatosAsync()
        {
            Console.WriteLine("Iniciando la lectura de datos...");
            await Task.Delay(2000);
            Console.WriteLine("Datos leídos con éxito.");
            MostrarInformacion();
        }


        //
        //
        //Principios solid
        // Interface Segregation Principle (ISP)
        public interface IPersona
        {
            string Nombre { get; set; }
            int Edad { get; set; }
            string Direccion { get; set; }
            void MostrarInformacion();
        }

        // Single Responsibility Principle (SRP) y Dependency Inversion Principle (DIP)
        public class Persona : IPersona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Direccion { get; set; }

            // Constructor que inicializa los atributos
            public Persona(string nombre, int edad, string direccion)
            {
                Nombre = nombre;
                Edad = edad;
                Direccion = direccion;
            }

            // Constructor sin parámetros que asigna valores predeterminados
            public Persona() : this("Antonella", 2, "Campoalegre") { }

            public void MostrarInformacion()
            {
                Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Dirección: {Direccion}");
            }
        }

        // Liskov Substitution Principle (LSP) y Open/Closed Principle (OCP)
        public class PersonaConLecturaAsincronica : Persona
        {
            public PersonaConLecturaAsincronica(string nombre, int edad, string direccion)
                : base(nombre, edad, direccion) { }

            public PersonaConLecturaAsincronica() : base() { }

            public async Task LeerDatosAsync()
            {
                Console.WriteLine("Iniciando la lectura de datos...");
                await Task.Delay(2000);
                Console.WriteLine("Datos leídos con éxito.");
                MostrarInformacion();
            }
        }

        class Program
        {
            static async Task Main(string[] args)
            {
                IPersona persona = new PersonaConLecturaAsincronica();
                await ((PersonaConLecturaAsincronica)persona).LeerDatosAsync();
            }

        }

    }
}


