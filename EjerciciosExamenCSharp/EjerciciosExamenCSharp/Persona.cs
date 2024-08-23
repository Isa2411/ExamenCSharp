using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosExamenCSharp
{
    public class Persona
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
        public Persona()
        {
            Nombre = "Antonella";
            Edad = 2;
            Direccion = "Campoalegre";
        }

        // Metodo para mostrar la información de la persona en la consola
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Dirección: {Direccion}");
        }
    }
}
